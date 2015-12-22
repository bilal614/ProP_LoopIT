<?php
    session_start();
    include '../model/User.class.php' ;
    include '../functions/generalFunctions.php';
    if(isset($_SESSION['userEmail'])){
        $email = $_SESSION['userEmail'];
        $eventAccount = EventAccount::getByEmailAddress($email);
        $infors = $eventAccount->GetData(); 
        include '../webPages/personalPage.view.php';
    }
    else{
        echo "Opps! You need to login for this page!";
    }   
    
   
   
    
        

