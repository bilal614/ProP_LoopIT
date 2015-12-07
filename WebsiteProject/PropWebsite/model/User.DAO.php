        <?php
        
        include '../config/DBconnection.inc.php';
        include '../includes/phpClasses/EventAccount.php';
        
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
        ?>