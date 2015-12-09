<?php
    session_start();
    include '../model/User.DAO.php' ;
    include '../functions/generalFunctions.php';
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
                $errors[] = 'Sorry, the email \''. $_POST['email'] . '\' is already taken.';
            }
        }
        
        if(strlen($_POST['password'])< 8 && strlen($_POST['password'])>25){
            $errors[] = 'Your password must be at least 6 characters';
        }
        if($_POST['password'] !== $_POST['repeatpassword']){
            $errors[] = 'Your passwords do not match';
        }
        if(filter_var($_POST['email'],FILTER_VALIDATE_EMAIL)===FALSE)
        {
            $errors[] = 'A valid email address is required';
        }
    }

    function Register()
    {
        global $errors;
         //Show the message to the user
              if(empty($_POST) === false && empty($errors) === true){
                //register user
                  $register_data = array(
                    'lastname' => $_POST['last_name'],
                    'firstname'=> $_POST['first_name'],
                    'phone' => $_POST['phone'],
                    'email'=> $_POST['email'],
                    'password'=> $_POST['password']
                  );
                  //Insert users' data into database
                  $result = register_user($register_data);
                  if($result === true){
                      //redirect the user                  
                      $_SESSION['email'] = $register_data['email'];
                      header('Location: registerSuccess.php');
                  }
                  
              }
               else if(empty($errors) === false) {
             //oput errors
                 echo output_error($errors); 
           }
    }
    include '../webPages/register.view.php';

?>
