<?php
session_start();
include '../model/User.class.php' ;
include '../functions/generalFunctions.php';

$errors = array();
if(empty($_POST) === false){
    $email = $_POST['email'];
    $password = $_POST['password'];
    
    if(empty($email) === true || empty($password)=== true){
       $errors[] = "Please enter your email or your password";
    }
    else if (User::user_exists($email)===FALSE){
        $errors[] = "This email is not valid";
    }
    else if (User::user_active($email)=== FALSE){
        $errors[] = "Please activate your account. May be it has not activated yet!";
    } 
    else {
        $result = User::authenticate($email, $password);
        if($result === false){
            $errors[] = "Your email or password is not correct";
        }
        else{
            $_SESSION['userEmail'] = $result;
            //Redirect to personal page
            header('Location: personalPage.php');  
            exit();
        }
    }
}


function HandleErrors(){
    global $errors;
    if(empty($errors) === false) {
            //oput errors
                echo output_error($errors); 
           }
}

include '../webPages/Login.view.php';