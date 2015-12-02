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
class EventAccount {
    
    //instance variables for the class EventAccount
    //these variables will be read and updated from the database for an EventAccount object
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
    public function setPmtStart($pmtStatus){$this->PaymentStatus=$pmtStatus;}
    public function setPmtAdv($pmtAdvance){$this->PayInAdvance=$pmtAdvance;}
}
