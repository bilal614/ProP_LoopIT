<?php

//session_start();
//session was already started when the user logged in
    include '../model/Camp.class.php';
    include '../functions/generalFunctions.php';

//Validate the form in server side
    $errors = array();
    if (empty($_POST)=== false){
        $required_fields = array('co_camper1', 'co_camper2', 'co_camper3', 'start_date','end_date');
        //echo '<pre>',print_r($_POST,true), '</pre>';
        foreach ($_POST as $key=>$value){
            if(empty($value) && in_array($key, $required_fields) === true)
            {
                $errors[] = 'Please enter the required fields';
                break 1; // break out of the loop
            }   
        }
        
        if(empty($errors) === true)//no errors with the list of input, check for password and repeatpassword
        {
            //Check wheather the users exist or not
            if(User::user_exists($_POST['email']) === true){
                $errors[] = 'Sorry, the email \''. $_POST['email'] . '\' is already taken.';
            }
        }
        
//validate the start date entered by the user
        if($startDate = strtotime($_POST['start_date']))
        { $stDate=date('Y-m-d',$startDate);}
        else { $errors[]='Starting date must be during event week.';}
//validate the end date entered by the user        
        if($endDate = strtotime($_POST['end_date']))
        {$eDate=date('Y-m-d',$endDate);}
        else { $errors[]='End date must be during event week.'; } 
               
//Validates that all the emails entered in the co-camper emails are infact valid emails.
        if(filter_var($_POST['co_camper1'],FILTER_VALIDATE_EMAIL)===FALSE)
        {$errors[] = 'Co-camper 1 must have a valid email address.';}
        if(filter_var($_POST['co_camper2'],FILTER_VALIDATE_EMAIL)===FALSE)
        { $errors[] = 'Co-camper 2 must have a valid email address.'; }
        if(filter_var($_POST['co_camper3'],FILTER_VALIDATE_EMAIL)===FALSE)
        { $errors[] = 'Co-camper 3 must have a valid email address.'; }
        if(filter_var($_POST['co_camper4'],FILTER_VALIDATE_EMAIL)===FALSE)
        { $errors[] = 'Co-camper 4 must have a valid email address.'; }
        if(filter_var($_POST['co_camper5'],FILTER_VALIDATE_EMAIL)===FALSE)
        { $errors[] = 'Co-camper 5 must have a valid email address.'; }
        
    }

    function campRegistration()
    {
        global $errors;
        if(empty($_POST) === false && empty($errors) === true){
            $formVars=array
                (
                "co_camper1"=>$_POST['co_camper1'],
                "co_camper2"=>$_POST['co_camper2'],
                "co_camper3"=>$_POST['co_camper3'],
                "co_camper4"=>$_POST['co_camper4'],
                "co_camper5"=>$_POST['co_camper5'],
                "start_date"=>$_POST['start_date'],
                "end_date"=>$_POST['end_date']
                );
            $Camper=new Camp($formVars);//creates new Camp object using the data required from the variable formVars
            $Camper->putInCampers();//puts the co_camper emails in a separate array belonging to Camp object
            $Camper->verifyEmails();//verifies all the emails that were put in if they exist in database
        
            if(empty($Camper->unregistered) && isset($Camper->unregistered)){
                
            }
        }
        else if(isset($errors) && empty($errors) === false) { echo output_error($errors);  }
    }
?>
