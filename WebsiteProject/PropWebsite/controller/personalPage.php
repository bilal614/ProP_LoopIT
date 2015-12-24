<?php
    session_start();
    require_once '../model/User.class.php' ;
    require_once '../functions/generalFunctions.php';
    if(isset($_SESSION['userEmail'])){
        $email = $_SESSION['userEmail'];
        $eventAccount = EventAccount::getByEmailAddress($email);
        $infors = $eventAccount->GetData(); 
        include '../webPages/personalPage.view.php';
    }
    else{
        echo "Opps! You need to login for this page!";
    }   
    
   
   /*if(!empty($_POST) && $_POST){
       if(isset($_POST['CampReserve']))
       {
           global $email;
           $_POST["EmailOfCamper"]=$email;
           //redirect to campreservation page
           header('Location: campreservation.php');
       }
   }*/
    
        

