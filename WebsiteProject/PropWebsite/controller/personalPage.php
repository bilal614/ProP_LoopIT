<?php
    session_start();
    require_once '../model/User.class.php' ;
    require_once '../functions/generalFunctions.php';
    if(isset($_SESSION['userEmail'])){
        $email = $_SESSION['userEmail'];
        $eventAccount = EventAccount::getByEmailAddress($email);
        $infors = $eventAccount->GetData(); 
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
        

