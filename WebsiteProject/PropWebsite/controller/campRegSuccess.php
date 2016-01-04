<?php
session_start();
$email = $_SESSION['email'];
include '../model/User.class.php' ;
include '../functions/generalFunctions.php';
include '../model/Camp.class.php';
$campInfo=  Camp::getCampResNo($_SESSION['email']);
$back=  filter_input(INPUT_POST, "BackPersonPage");
if(isset($_POST['BackPersonPage'])){
    header("Location: personalPage.php");
    exit();
}

include '../webPages/campSuccess.view';


