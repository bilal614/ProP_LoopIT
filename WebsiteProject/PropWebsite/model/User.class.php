        <?php
        
        require_once 'DataObject.class.php';
        require_once 'EventAccount.class.php';
        
        //this function takes in an email as an argument and returns 
        class User extends DataObject{
            protected $data=array(
                "UserEmail"=>"",
                "PassWord"=>"",
                "Hash"=>"",
                "Active"=>""
            );
            
            public static function getUserAccount($userEmail){
            $conn=parent::connect();
            $sql ="SELECT * FROM ".TBL_USER. " WHERE UserEmail= :userEmail";
    
            try{
                $st=$conn->prepare($sql);
                $st->bindValue(":userEmail", $userEmail,PDO::PARAM_STR);
                $st->execute();
                $row=$st->fetch();
                parent::disconnect($conn);
                if($row) 
                {return new User ($row);}
                }  catch (PDOException $e){
                    parent::disconnect($conn);
                    die("Query failed: ".$e->getMessage());
                }
            }
            
            public static function authenticate($email,$password){
                $password = md5($password);
                $conn=  parent::connect();
                $sql="SELECT * FROM ".TBL_USER." WHERE UserEmail= :userEmail AND PassWord= :password AND Active = 1";
                try{
                    $st=$conn->prepare($sql);
                    $st->bindValue(":userEmail", $email,PDO::PARAM_STR);
                    $st->bindValue(":password", $password,PDO::PARAM_STR);
                    $st->execute();
                    $row=$st->rowCount();
                    parent::disconnect($conn);
                    if($row != 0)
                    {
                        return $email;
                    }
                    else 
                    {
                        return false;
                    } 
                }
                catch(PDOException $e){
                    parent::disconnect($conn);
                    die("Query failed: ".$e->getMessage());
                }
            }
            
            //first you pass all the information of the user such as UserName, password etc. to the data array 
            //of a User object, then you call the register function to create an instance of the user in the
            //database
            public function register(){
                $pword=  md5($this->data["PassWord"]);
                $conn=  parent::connect();
                $sql="INSERT INTO ".TBL_USER. " (UserEmail,PassWord,Hash,Active)
                VALUES(:userName,:password,:hash,:active)";
                try{
                    $st=$conn->prepare($sql);
                    $st->bindValue(":userName",$this->data["UserEmail"],PDO::PARAM_STR);
                    $st->bindValue(":password",$pword,PDO::PARAM_STR);
                    $st->bindValue(":hash",$this->data["Hash"],PDO::PARAM_STR);
                    $st->bindValue(":active",$this->data["Active"],PDO::PARAM_INT);
                    $st->execute();
                    parent::disconnect($conn);
                }catch(PDOException $e){
                    parent::disconnect($conn);
                    die("Query failed: ".$e->getMessage());
                }
            }
            
            //this method will return true if the given user's email is exist in the database
            //used for registration 
            public static function user_exists($userEmail){
                $conn=parent::connect();
                $sql ="SELECT UserEmail FROM ".TBL_USER. " WHERE UserEmail= :userEmail";
                try{
                    $st=$conn->prepare($sql);
                    $st->bindValue(":userEmail", $userEmail,PDO::PARAM_STR);
                    $st->execute();
                    $row=$st->rowCount();
                    parent::disconnect($conn);
                    if($row != 0)
                    {
                        return true;
                    }
                    else 
                    {
                        return false;
                    } 
                }
                catch(PDOException $e){
                    parent::disconnect($conn);
                    die("Query failed: ".$e->getMessage());
                }
        
            }
            
            //activate user account
            public static function activate_user($email,$hash){
                $conn = parent::connect();
                $sql = "SELECT * FROM ".TBL_USER. " WHERE UserEmail= :userEmail AND Hash= :hash AND Active=0 ";
                $sqlUpdate = "UPDATE ".TBL_USER." SET Active = 1 WHERE UserEmail= :userEmail";
                try{
                    $st = $conn->prepare($sql);
                    $st->bindValue(":userEmail", $email, PDO::PARAM_STR);
                    $st->bindValue(":hash", $hash, PDO::PARAM_STR);
                    $st->execute();
                    $row=$st->rowCount();
                    if($row == 1){
                        $update = $conn->prepare($sqlUpdate);
                        $update->bindValue(":userEmail", $email, PDO::PARAM_STR);
                        $update->execute();
                        return true;
                    }
                    else
                        return FALSE;
                }
                catch(PDOException $e){
                    parent::disconnect($conn);
                    die("Query failed: ".$e->getMessage());
                }
            }
            //Check the given email of user is active or not. This method will return true if the account is activated. 
            public static function user_active($email){
                $conn = parent::connect();
                $sql = "SELECT * FROM ".TBL_USER. " WHERE UserEmail= :userEmail AND Active=1 ";
                try{
                    $st = $conn->prepare($sql);
                    $st->bindValue(":userEmail", $email, PDO::PARAM_STR);
                    $st->execute();
                    $row=$st->rowCount();
                    if($row == 1){
                        return TRUE;
                    }
                    else
                        return FALSE;
                }
                catch(PDOException $e){
                    parent::disconnect($conn);
                    die("Query failed: ".$e->getMessage());
                }
            }
    }
