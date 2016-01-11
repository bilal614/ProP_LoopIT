<?php

session_start();
    include '../model/Camp.class.php';
    include '../functions/generalFunctions.php';

//Validate the form in server side
    $errors = array();
    if (!empty($_POST) && empty($_POST['Skip'])){
        $required_fields = array('co_camper1', 'co_camper2', 'co_camper3', 'start_date','end_date');
        //echo '<pre>',print_r($_POST,true), '</pre>';
        foreach ($_POST as $key=>$value){
            if(empty($value) && in_array($key, $required_fields) === true)
            {
                $errors[] = 'Please enter the required fields';
                break 1; // break out of the loop
            }   
        }
//validate the start date entered by the user
        $beginning =  strtotime('2016-01-30');
        $ending=  strtotime('2016-02-08');
        
        if($startDate = strtotime($_POST['start_date']))
        {            
            if($startDate>=$beginning && $startDate<=$ending)
                {$stDate=date('Y-m-d',$startDate);}
            else{ $errors[]='Starting date must be during event week.';}
        }
//validate the end date entered by the user        
        if($endDate = strtotime($_POST['end_date']))
        {
            if($endDate>=$beginning && $endDate<=$ending && $startDate<=$endDate)
            {$eDate=date('Y-m-d',$endDate);}
            else{ $errors[]='End date must be during event week.';}
        }
               
//Validates that all the emails entered in the co-camper emails are infact valid emails.
        if($_POST['co_camper1']===$_SESSION['userEmail'] && $_POST['co_camper2']===$_SESSION['userEmail'] && 
                $_POST['co_camper3']===$_SESSION['userEmail'] && $_POST['co_camper4']===$_SESSION['userEmail'] && 
                $_POST['co_camper5']===$_SESSION['userEmail'])
        {
            $errors[]='You are already inlcuded in camping reservation, you do not need to include your own'
                    . 'email in any of the e-mail fields.';
        }
        if(!empty($_POST['co_camper1'])){
            if(filter_var($_POST['co_camper1'],FILTER_VALIDATE_EMAIL)===FALSE)
            {$errors[] = 'Co-camper 1 must have a valid email address.';}
        }
        if(!empty($_POST['co_camper2'])){
            if(filter_var($_POST['co_camper2'],FILTER_VALIDATE_EMAIL)===FALSE)
            { $errors[] = 'Co-camper 2 must have a valid email address.'; }
        }
        
        if(!empty($_POST['co_camper3'])){
            if(filter_var($_POST['co_camper3'],FILTER_VALIDATE_EMAIL)===FALSE)
            { $errors[] = 'Co-camper 3 must have a valid email address.'; }
        }
        
        if(!empty($_POST['co_camper4'])){
            if(filter_var($_POST['co_camper4'],FILTER_VALIDATE_EMAIL)===FALSE)
            { $errors[] = 'Co-camper 4 must have a valid email address.'; }
        }
        
        if(!empty($_POST['co_camper5'])){
            if(filter_var($_POST['co_camper5'],FILTER_VALIDATE_EMAIL)===FALSE)
            { $errors[] = 'Co-camper 5 must have a valid email address.'; }
        }
        
        $goBack=filter_input(INPUT_POST, 'Skip');
        $submitForm=  filter_input(INPUT_POST, 'Reserve');
        if(!empty($submitForm) && empty($errors)){
            $formVars=array
                (
                "co_camper1"=>$_POST['co_camper1'],
                "co_camper2"=>$_POST['co_camper2'],
                "co_camper3"=>$_POST['co_camper3'],
                "co_camper4"=>$_POST['co_camper4'],
                "co_camper5"=>$_POST['co_camper5'],
                "start_date"=>$stDate,
                "end_date"=>$eDate
                );
            $Camper=new Camp($formVars);//creates new Camp object using the data required from the variable formVars
            $Camper->putInCampers();//puts the co_camper emails in a separate array belonging to Camp object
            $Camper->verifyEmails();//verifies all the emails that were put in if they exist in database
            if(empty($Camper->unregistered) && !isset($Camper->unregistered)){
                $errors[]='Some of your co-campers are not registered for this event. We have sent them an'
                        . ' invitation for registration. You will be able to make a camp reservation with them'
                        . ' once they are registered.';
                //sorry the user's co-campers are not all registered
                //echo 'All users not registered';
                //here we will implement sending emails to other un-registered users to get them to register
            }
            else{
                if($Camper->makeReservation($_SESSION['userEmail']))//'bilalbutt.614@gmail.com',use this but for now use an 
                //example email registered in the DB!!!!IMPORTANT!!!
                {
                    
                    header('Location: campRegSuccess.php');
                    exit();
                }
                else{
                    $errors[]='There are no available camps for rent at the moment.';
                }
            }
        }
        //else if(isset($errors) && empty($errors) === false) { echo output_error($errors);  }
        
    }
    else if(isset($_POST['Skip'])){
        header('Location: '.$_SESSION['redirectURL']);
        exit();
    }
    
    include '../webPages/campreservation.view.php';
?>
