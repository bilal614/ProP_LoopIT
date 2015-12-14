<?php
/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 * Description of EventAccount
 *
 * @author bilalbutt.614
 */
require_once "DataObject.class.php";

class EventAccount extends DataObject {
    
    //instance variables for the class EventAccount
    //these variables will be read and updated from the database for an EventAccount object
    protected $data=array(
    "Account_ID"=>"",
    "RFID_Code"=>"",
    "Balance"=>"",
    "E_mail"=>"",
    "First_Name"=>"",
    "Last_Name"=>"",
    "Phone"=>"",
    "Payment_Status"=>"",
    "Pay_InAdvance"=>""
    );
     
    public static function getEventAccount($eventAccountId){
        $conn=parent::connect();
        $sql ="SELECT * FROM ".TBL_E_ACCOUNT. " WHERE Account_ID= :eventAccountId";
    
        try{
            $st=$conn->prepare($sql);
            $st->bindValue(":eventAccountId", $eventAccountId,PDO::PARAM_INT);
            $st->execute();
            $row=$st->fetch();
            parent::disconnect($conn);
            if($row) 
            {return new EventAccount ($row);}
        }  catch (PDOException $e){
            parent::disconnect($conn);
            die("Query failed: ".$e->getMessage());
        }
    }

    public static function getByEmailAddress($email){
        $conn=parent::connect();
        $sql ="SELECT * FROM ".TBL_E_ACCOUNT. " WHERE E_mail= :email";
    
        try{
            $st=$conn->prepare($sql);
            $st->bindValue(":email", $email,PDO::PARAM_STR);
            $st->execute();
            $row=$st->fetch();
            parent::disconnect($conn);
            if($row) 
            {return new EventAccount ($row);}
        }  catch (PDOException $e){
            parent::disconnect($conn);
            die("Query failed: ".$e->getMessage());
        }
    }
    
//generateUniqueId function must be called before calling insert function in order to give the EventAccount AccountId a
    //unique AccountId
    public function generateUniqueId()
    {
        $x=  rand(11111, 99999);
        $conn=  parent::connect();
        $sql="SELECT Account_ID FROM ".TBL_E_ACCOUNT." WHERE Account_ID=:x";
        $row;
        do{
        try{
            $st=$conn->prepare($sql);
            $st->bindValue(":x", $x,PDO::PARAM_INT);
            $st->execute();
            $row=$st->fetch();
            if($row) 
            {
                $x=rand(11111,99999);
                $sql="SELECT Account_ID FROM ".TBL_E_ACCOUNT." WHERE Account_ID=:x";
            }
            else{$row=null;}
            }  catch (PDOException $e){
            parent::disconnect($conn);
            die("Query failed: ".$e->getMessage());
            }
            }while($row!=null);
            parent::disconnect($conn);
            $this->data["Account_ID"]=$x;
    }
    
    public function insert(){
        $conn=  parent::connect();
        $sql="INSERT INTO ".TBL_E_ACCOUNT." (Account_ID,RFID_code,First_Name,Last_Name,Phone,E_mail,Balance,
            Payment_Status,Pay_InAdvance)
            VALUES(:accountId,:rfid,:firstName,:lastName,:phone,:email,:balance,:pmtStatus,:pmtAdv)";
        
        try{
            $st=$conn->prepare($sql);
            $st->bindValue(":accountId", $this->data["Account_ID"],PDO::PARAM_STR);
            $st->bindValue(":rfid", "",PDO::PARAM_STR);
            $st->bindValue(":firstName", $this->data["First_Name"],PDO::PARAM_STR);
            $st->bindValue(":lastName", $this->data["Last_Name"],PDO::PARAM_STR);
            $st->bindValue(":phone", $this->data["Phone"],PDO::PARAM_STR);
            $st->bindValue(":email", $this->data["E_mail"],PDO::PARAM_STR);
            $st->bindValue(":balance", 0.0);
            $st->bindValue(":pmtStatus",$this->data["Payment_Status"]=false,PDO::PARAM_BOOL);
            $st->bindValue(":pmtAdv",$this->data["Pay_InAdvance"]=false,PDO::PARAM_BOOL);
            $st->execute();
            parent::disconnect($conn);
            return true;//returns true when sql query is successfully executed and EventAccount is added to database
        }catch(PDOException $e){
            parent::disconnect($conn);
            die("Query failed: ".$e->getMessage());
        }
    }


    
    //features below of this class will not be used anymore
    private $eventId;
    private $RFIDcode;
    private $FirstName;
    private $LastName;
    private $Email;
    private $Phone;
    private $Balance;
    private $PaymentStatus;
    private $PayInAdvance;
    
    //get methods for the private variables of the class
    public function getEventID(){return $this->eventId;}
    public function getRFID(){return $this->RFIDcode;}
    public function getFirstName(){return $this->FirstName;}
    public function getLastName(){return $this->LastName;}
    public function getEmail(){return $this->Email;}
    public function getPhone(){return $this->Phone;}
    public function getBalance(){return $this->Balance;}
    public function getPmtStat(){return $this->PaymentStatus;}
    public function getPmtAdvance(){return $this->PayInAdvance;}
            
    //set methods for the private variables for the class
    public function setEventId($id){$this->eventId=$id;}
    public function setRFID($rfid){$this->RFIDCode=$rfid;}
    public function setFirstName($first){$this->FirstName=$first;}
    public function setLastName($last){$this->LastName=$last;}
    public function setEmail($email){$this->Email=$email;}       
    public function setPhone($phone){$this->Phone=$phone;}       
    public function setBalance($bal){$this->Balance=$bal;}       
    public function setPmtStat($pmtStatus){$this->PaymentStatus=$pmtStatus;}
    public function setPmtAdv($pmtAdvance){$this->PayInAdvance=$pmtAdvance;}
}
