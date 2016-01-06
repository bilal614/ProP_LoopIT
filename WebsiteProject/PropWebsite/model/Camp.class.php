<?php
require_once 'DataObject.class.php';
require_once 'EventAccount.class.php';
require_once 'User.class.php';
/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 * Description of Camp
 *
 * @author bilalbutt.614
 */
class Camp extends DataObject {
    //put your code here
    protected $data=array(
        "co_camper1"=>"",
        "co_camper2"=>"",
        "co_camper3"=>"",
        "co_camper4"=>"",
        "co_camper5"=>"",
        "start_date"=>"",
        "end_date"=>""
        );
    
    protected $campers=array(
        "Camper1"=>"",
        "Camper2"=>"",
        "Camper3"=>"",
        "Camper4"=>"",
        "Camper5"=>"",
       );
    
    public $unregistered=array();//to see which emails are not registered users yet
    
    //method for checking if all co-campers have an event and/or user account?? don't really need it 
    //For checking the email of co-camper exists in database or not we can use the getUserAccount function 
    //of the User class. We can call that method for each of the co-camper emails entered by user to check
    //if his/her friends exist in the database or not.
    public function putInCampers()//must execute this method in camp controller to move the camper emails in campers array
    {
        $this->campers["Camper1"]= parent::getValue('co_camper1');
        $this->campers["Camper2"]= parent::getValue('co_camper2');
        $this->campers["Camper3"]= parent::getValue('co_camper3');
        $this->campers["Camper4"]= parent::getValue('co_camper4');
        $this->campers["Camper5"]= parent::getValue('co_camper5');
    }
    
    //verifyEmails method checks whether the emails in the coCampers array all exist in the database and returns 
    //true if they do else returns false
    public function verifyEmails()
    {
        foreach ($this->campers as $key=>$emails){
            if(isset($emails) && !empty($emails)){
                if(User::user_exists($emails)==false)
                    $this->unregistered[]=$emails;
            }
        }
        if(empty($this->unregistered))
            return true;
        else 
            return false;
    }
    public function checkCampAvailability(){
        $conn=  parent::connect();
        $sql="SELECT CampID FROM ".TBL_CAMP." WHERE Available=:x";
        
        try{
            $st=$conn->prepare($sql);
            $st->bindValue(":x", 1,PDO::PARAM_BOOL);
            $st->execute();
            $row=$st->fetch(PDO::FETCH_ASSOC);
        }catch(PDOException $e){
            parent::disconnect($conn);
            die("Query failed: ".$e->getMessage());
        }
        
        parent::disconnect($conn);
        $CampID=$row["CampID"];
        if(isset($CampID) && !empty($CampID))
            return $CampID;//this method will return the campId of the first camp in a set of available Camps    
        else{return -1;}//otherwise it returns -1 meaning there are no camps available 
    }
    
    public function makeCampOccupied($campId){
        $conn=  parent::connect();
        $sql="UPDATE ".TBL_CAMP." SET Available=0 WHERE CampID=:campId";
        
        try{
            $st=$conn->prepare($sql);
            $st->bindValue(":campId", $campId,PDO::PARAM_INT);
            $st->execute();
        }catch(PDOException $e){
            parent::disconnect($conn);
            die ("Could not make camp occupied: ".$e);
        }   
    }
    
//this method generates a unique number for each camp-reservation
    public function generateUniqueCampResNo(){
        
        $ResNo=rand(1111, 9999);
        $conn=  parent::connect();
        $sql="SELECT CampRes_No FROM ".TBL_CAMP_RES." WHERE CampRes_No=:resNo";
        $row;
        do{
            try{
                $st=$conn->prepare($sql);
                $st->bindValue(":resNo", $ResNo,PDO::PARAM_INT);
                $st->execute();
                $row=$st->fetch();
                if($row) 
            {
                $ResNo=rand(1111,9999);
                $sql="SELECT CampRes_No FROM ".TBL_CAMP_RES." WHERE CampRes_No=:resNo";
            }
            else{$row=null;}
                
            }catch(PDOException $e){
                parent::disconnect($conn);
                die('Query failed'.$e);
            }
        }while(isset($row) && !empty($row));//$row!=null
        parent::disconnect($conn);
        return $ResNo;
    }
    
    //method for registering
    public function makeReservation($UserEmail){
        //global $errors;
        if(!isset($unregistered)){//&& empty($unregistered)
            
            
            /////////////////////////////////////////////////////////
            //This piece of code is a check to see if any of the people are already registered including the person 
            //making the camp reservation 
            foreach($coCampers as $coEmail){
            $already=  Camp::getCampResNo($coEmail);
                if(!isset($already)){
                    //$errors[]='Some of you co-campers are already registered.';
                    return false;}
            }
            $already=  Camp::getCampResNo($UserEmail);
            if(!isset($already)){
                return false;
            }
            //////////////////////////////////////////////////////////
            
            $eventAct=  EventAccount::getByEmailAddress($UserEmail);//now eventAct variable is the Event Account object
            //of the person that is making the camping reservation for the group of people, when this method
            //is called the argument given to it will most likely be the username stored in the session variable
            $coCampers=array();//coCampers will store all the coCampers that are in the reservation so it will 
            //ignore the empty fields included in the campers array variable
            foreach ($this->campers as $key=>$val){
                if(isset($val) && !empty($val))
                    $coCampers[]=$val;//this variable stores the emails of all the co-campers
            }
            
            $stDate=date('Y-m-d', strtotime($this->data["start_date"]));
            $eDate=date('Y-m-d', strtotime($this->data["end_date"]));
            
            //here we get a campId of a camp that is available 
            $campId=$this->checkCampAvailability();
            $campResNo=$this->generateUniqueCampResNo();
            
            if($campId>=0){//would only execute the SQL statement if there are camps available
                $conn=  parent::connect();
                $sql="INSERT INTO ".TBL_CAMP_RES." (CampRes_No, Start_Date, End_Date, Account_ID, CAMP_CampID)
                VALUES(:campRes, :stDate, :eDate, :acctId, :campId)";
                
                $sqlGroup="INSERT INTO ".TBL_GROUP." ( Co_email, CampRes_No,Check_in)
                VALUES(:coEmail,:campResNo,:checkIn)";//checkIn is always 0 upon registration 
                        
                try{
                    $st=$conn->prepare($sql);
                    $st->bindValue(":campRes", $campResNo,PDO::PARAM_INT);
                    $st->bindValue(":stDate", $stDate,PDO::PARAM_STR);
                    $st->bindValue(":eDate", $eDate,PDO::PARAM_STR);
                    $st->bindValue(":acctId", $eventAct->EventAccountGet(),PDO::PARAM_INT);
                    $st->bindValue(":campId", $campId,PDO::PARAM_INT);
                    $st->execute();
                    
    //we can assign the eventId of the person making the reservation as the groupId as well, we can do that because 
    //groupId is any unique number for a group so it can also be the number of the eventId
                    foreach($coCampers as $coEmail){
                        $stGroup=$conn->prepare($sqlGroup);
                        $stGroup->bindValue(":coEmail", $coEmail,PDO::PARAM_STR);
                        $stGroup->bindValue(":campResNo", $campResNo,PDO::PARAM_INT);
                        $stGroup->bindValue("checkIn", 0,PDO::PARAM_BOOL);
                        $stGroup->execute();
                    }
                    //we have added the rest of the group members of the user making reservation but now we must also 
                    //add that person to the group
                    $stUser=$conn->prepare($sqlGroup);
                    $stUser->bindValue(":coEmail", $UserEmail,PDO::PARAM_STR);
                    $stUser->bindValue(":campResNo", $campResNo,PDO::PARAM_INT);
                    $stUser->bindValue("checkIn", 0,PDO::PARAM_BOOL);
                    $stUser->execute();
                    
                    parent::disconnect($conn);
                    $this->makeCampOccupied($campId);//call this method to make camp occupied by making its Active
                    //field in database to a 0
                    
                    return true;//returns true when sql query is successfully executed and EventAccount is added to database
                }catch(PDOException $e){
                    parent::disconnect($conn);
                    die("Query failed: ".$e->getMessage());
                }
            }else{
                //echo 'No camps are available at this time.';
                return false;
            }
        }else{
            //echo 'Not all co-campers are registered yet.';
            //we must send an invite to the unregistered emails supplied by the user in this case!!!!!
            return false;
        }
        
        parent::disconnect($conn);
    }
    
    public static function getCampResNo($email){
        $conn= parent::connect();
        $sql="SELECT CampRes_No FROM ".TBL_GROUP." WHERE Co_email=:email;";
        $row;
        try{
            $st=$conn->prepare($sql);
            $st->bindValue(":email", $email,PDO::PARAM_STR);
            $st->execute();
            $row=$st->fetch(PDO::FETCH_ASSOC);
        }
        catch(PDOException $e){
            parent::disconnect($conn);
            die ("Could not retrieve data ".$e);
        }
        parent::disconnect($conn);
        return $row;
    }
}