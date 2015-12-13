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
