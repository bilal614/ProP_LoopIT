<?php
    session_start();
    $email = $_SESSION['email'];
    include '../model/User.class.php' ;
    include '../functions/generalFunctions.php';
    include '../webPages/RegisterSuccess.view.php';
?>
