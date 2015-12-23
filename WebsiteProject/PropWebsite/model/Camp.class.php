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
    
    public $unregistered=array();//to see which emails are not registered user yet
    
    //method for checking if all co-campers have an event and/or user account?? don't really need it 
    //For checking the email of co-camper exists in database or not we can use the getUserAccount function 
    //of the User class. We can call that method for each of the co-camper emails entered by user to check
    //if his/her friends exist in the database or not.
    public function putInCampers()//must execute this method in camp controller to move the camper emails in campers array
    {
        $this->campers["Camper1"]=$data["co_camper1"];
        $this->campers["Camper2"]=$data["co_camper2"];
        $this->campers["Camper3"]=$data["co_camper3"];
        $this->campers["Camper4"]=$data["co_camper4"];
        $this->campers["Camper5"]=$data["co_camper5"];
    }
    
    //verifyEmails method checks whether the emails in the coCampers array all exist in the database and returns 
    //true if they do else returns false
    public function verifyEmails()
    {
        foreach ($this->campers as $key=>$emails){
            if(isset($emails)===false && empty($emails)===false){
                if(user_exists($emails)==false)
                    $this->unregistered[]=$emails;
            }
        }
        if(empty($this->unregistered))
            return true;
        else 
            return false;
    }
    //method for registering
    public function makeReservation($UserEmail){
        if(isset($unregistered) && empty($unregistered)){
            $eventAct=  EventAccount::getByEmailAddress($UserEmail);//now eventAct variable is the Event Account object
            //of the person that is making the camping reservation for the group of people, when this method
            //is called the argument given to it will most likely be the username stored in the session variable
            $coCampers=array();//coCampers will store all the coCampers that are in the reservation so it will 
            //ignore the empty fields included in the campers array variable
            foreach ($campers as $key=>$val){
                if(isset($val)===false && empty($val))
                    $coCampers[]=$val;
            }
            
            $stDate=date('Y-m-d', strtotime($this->data["start_date"]));
            $eDate=date('Y-m-d', strtotime($this->data["end_date"]));
            
            $conn=  parent::connect();
            $sql="INSERT INTO ".TBL_CAMP_RES." (Start_Date,End_Date,Account_ID,CAMP_CampID)
            VALUES(:stDate,:eDate,:acctId,:campId)";
            
            try{
            $st=$conn->prepare($sql);
            $st->bindValue(":stDate", $stDate);
            $st->bindValue(":eDate", $eDate,PDO::PARAM_STR);
            $st->bindValue(":acctId", $eventAct->EventAccountGet(),PDO::PARAM_INT);
            $st->bindValue(":campId", $this->data["Last_Name"],PDO::PARAM_STR);
            $st->execute();
            parent::disconnect($conn);
            return true;//returns true when sql query is successfully executed and EventAccount is added to database
        }catch(PDOException $e){
            parent::disconnect($conn);
            die("Query failed: ".$e->getMessage());
        }
        }else{
            echo 'Not all co-campers are registered yet.';
        }
    }
}