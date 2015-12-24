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
    
    public function EventAccountGet(){
        return $this->data["Account_ID"];
    }
    
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
            }while(isset($row) && !empty($row));//$row!=null
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
}
