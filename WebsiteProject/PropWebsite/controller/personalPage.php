<?php
    session_start();
    require_once '../model/User.class.php' ;
    require_once '../functions/generalFunctions.php';
    require_once '../model/Camp.class.php';
    if(isset($_SESSION['userEmail'])){
        $email = $_SESSION['userEmail'];
        $eventAccount = EventAccount::getByEmailAddress($email);
        $infors = $eventAccount->GetData();
        if(!empty(Camp::getCampResNo($_SESSION['userEmail'])))
        {$campInfo = Camp::getCampResNo($_SESSION['userEmail']);
        $campDates=  Camp::getCampDates($campInfo['CampRes_No']);
        }
        else{$campInfo;$campDates;}
    }
    else{
        echo "Opps! You need to login for this page!";
    }   
    
   
   if(isset($_POST)){
       if(isset($_POST['CampReserve']))
       {
           global $email;
           $_POST["EmailOfCamper"]=$email;
           //redirect to campreservation page
           $_SESSION['redirectURL']=$_SERVER['REQUEST_URI'];
           header('Location: campregister.php');
           //include '../webPages/campreservation.view.php';
           exit();
       }
   }
    
   include '../webPages/personalPage.view.php';
        

