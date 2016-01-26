<?php
session_start();
$email = $_SESSION['userEmail'];
include '../model/User.class.php' ;
include '../functions/generalFunctions.php';
include '../model/Camp.class.php';
$campInfo = Camp::getCampResNo($email);
$campDates = Camp::getCampDates($campInfo['CampRes_No']);
$emailMessage='Thank you for making a camp reservation with us. Your camp reservation number is '.
        $campInfo['CampRes_No'].' and your reservation is from '. $campDates['Start_Date'].
        ' till '.$campDates['End_Date'].'.';

sentEmail($email, $emailMessage, 'Camp Reservation Confirmation');
$back = filter_input(INPUT_POST, "BackPersonPage");
if(isset($_POST['BackPersonPage'])){
    header("Location: personalPage.php");
    exit();
}

include '../webPages/campSuccess.view.php';


