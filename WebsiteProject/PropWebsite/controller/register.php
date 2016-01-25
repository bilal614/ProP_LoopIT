<?php
    session_start();
    include '../model/User.class.php' ;
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
            if(User::user_exists($_POST['email']) === true){
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
                    'password'=> $_POST['password'],
                    'hash'=> md5($register_data['email']+  microtime())
                  );
                  //Insert into user account
                  $userData = array (
                        "UserEmail"=>$register_data['email'],
                        "PassWord"=>$register_data['password'],
                        "Hash"=> $register_data['hash'],
                        "Active"=>"0"  
                  );
                  $UserData = new User($userData);
                  $UserData->register();
                  $eventData=array(
                      "Account_ID"=>"",
                      "RFID_Code"=>"",
                      "Balance"=>0.0,
                      "E_mail"=>$register_data['email'],
                      "First_Name"=>$register_data['firstname'],
                      "Last_Name"=>$register_data['lastname'],
                      "Phone"=>$register_data['phone'],
                      "Payment_Status"=>"",
                      "Pay_InAdvance"=>""
                  );
                  $EventData=new EventAccount($eventData);
                  $EventData->generateUniqueId();
                  //if EventData is able to insert the EventAccount in the database the user is re-directed to a 
                  //registerScuccess page
                  if($EventData->insert())
                  {
                       $_SESSION['email'] = $register_data['email'];
                       $_SESSION['name'] = $register_data['lastname'];
                       header('Location: registerSuccess.php');
                       //email to user
                       $link = 'http://ec2-54-152-33-198.compute-1.amazonaws.com/controller/activate.php?email='.$register_data['email'].'&hash='.$register_data['hash'];
                       $msg = "<p>Hello ".$register_data['lastname'].",<\p> <p>You need to activate your account, please click the link below: <\p> <p>".$link."<\p> <p> Kind regards,</p> <p>Jazz festival team</p>";
                       $subject = "Activate jazz festival event";
                       sentEmail($register_data['email'], $msg, $subject);
                  }
              }
              else if(empty($errors) === false) {
                //oput errors
                    echo output_error($errors); 
               }
    }
    include '../webPages/register.view.php';

?>
