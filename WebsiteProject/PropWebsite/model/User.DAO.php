        <?php
        
        include 'DBconnection.inc.php';
        include 'EventAccount.php';
        
        //this function takes in an email as an argument and returns 
        function fetchEventAccount($email){
            $exampleQuery="SELECT * FROM E_ACCOUNT WHERE E_mail='$email';";
            $query_run=  mysql_query($exampleQuery);

            while($QueryRow = mysql_fetch_assoc($query_run)){
                $id= $QueryRow['Account_ID'];
                $rfid=$QueryRow['RFID_Code'];
                $bal=$QueryRow['Balance'];
                $Email=$QueryRow['E_mail'];
                $Fname=$QueryRow['First_Name'];
                $Lname=$QueryRow['Last_Name'];
                $phone=$QueryRow['Phone'];
                $pmtStat=$QueryRow['Payment_Status'];
                $inAdv=$QueryRow['Pay_InAdvance'];
    
                $eventAccount=new EventAccount();
                $eventAccount->setEventId($id);
                $eventAccount->setRFID($rfid);
                $eventAccount->setBalance($bal);
                $eventAccount->setEmail($Email);
                $eventAccount->setFirstName($Fname);
                $eventAccount->setLastName($Lname);
                $eventAccount->setPhone($phone);
                $eventAccount->setPmtStat($pmtStat);
                $eventAccount->setPmtAdv($inAdv);
    return $eventAccount;}
        }
        
        //this method will return true if the given username and password match an instance in the database
        //otherwise it will return false
        function checkLogin($userName,$passWord){
            $exampleQuery="SELECT * FROM USER_ACCT WHERE UserEmail='$userName' AND PassWord='$passWord';";
            $query_run=  mysql_query($exampleQuery);

            while($QueryRow = mysql_fetch_assoc($query_run)){
                $user= $QueryRow['UserEmail'];
                $active=$QueryRow['Active'];
            }
            if($user===$userName && $active==1)
            {return true;}
            else {return false;}
        }
        
        //this method will return true if the given user's email is exist in the database
        //used for registration 
        function user_exists($userEmail){
            $query = "SELECT UserEmail FROM USER_ACCT WHERE UserEmail = '$userEmail';";
            $query_run = mysql_query($query); //return false if query cannot run
            
            if (mysql_num_rows($query_run) != 0){
                return true; // user's email exist on the database;
            }
            else{
                return false;
            }
        }
        
        //this method will insert an array of register data into 2 tables, E_ACCOUNT and USER_ACCOUNT
        function register_user($register_data){
            // go through the array and apply array_sanitize, remove space
            array_walk($register_data, 'array_sanitize');
            //encoding the password by md5
            $register_data['password'] = md5($register_data['password']);
            $password = $register_data['password'];
            $email = $register_data['email'];
            $lastname = $register_data['lastname'];
            $firstname = $register_data['firstname'];
            $phone = $register_data['phone'];
            $accountID = getAccountID();
            
           //Insert new users into USER_ACCOUNT
           $queryAccount = "INSERT INTO User_Acct (UserEmail,PassWord,HASH,Active) VALUES('$email','$password','', 0); ";
           mysql_query($queryAccount);
           //Insert new users into E_ACCOUNT
           $queryEvent = "INSERT INTO E_Account (Account_ID,RFID_code,First_Name,Last_Name,Phone,E_mail,Balance,Payment_Status,Pay_InAdvance)
                         VALUES('$accountID',null,'$firstname', '$lastname','$phone','$email', 0.0, false, false);";
           $result  =  mysql_query($queryEvent);  
           //Inserting value into E_ACCOUNT depend on USER_ACCOUNT (foreign key contraint), therefore just check for the insert of event account.
           //If $return true, that means the one for User_Account is sucessful as well.
           return $result;
        }
        
        function getAccountID()
        {
            $query = "SELECT Account_ID FROM E_ACCOUNT";
            $result = mysql_query($query);
            $ids = Array();
            while($row = mysql_fetch_array($result,MYSQL_ASSOC)){
                 $ids[] =  $row['Account_ID'];  
            }
            sort($ids);
            return end($ids) + 1;
           
        }
        ?>
