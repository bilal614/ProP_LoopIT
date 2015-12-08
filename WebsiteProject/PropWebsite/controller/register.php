<?php
    include '../model/User.DAO.php' ;
    include '../webPages/register.view.php';
    //Validate the form in server side
    $errors = array();
    if (empty($_POST)=== false){
        $required_fields = array('first_name', 'last_name', 'email', 'password','repeatpassword');
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
            if(user_exists($_POST['email']) === true){
                $errors[] = 'Sorry, the email \''. $_POST['email'] . '\'is already taken.';
            }
        }
    }
    

?>
