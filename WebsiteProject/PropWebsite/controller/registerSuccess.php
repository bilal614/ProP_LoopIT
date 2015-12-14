<?php
    session_start();
    include '../model/User.class.php' ;
    include '../functions/generalFunctions.php';
    $email = $_SESSION['email'];
    $eventAccount = fetchEventAccount($email);    
    include '../webPages/RegisterSuccess.view.php';
    session_destroy();
?>