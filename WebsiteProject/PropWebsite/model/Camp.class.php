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
    
    protected $unregistered=array();//to see which emails are not registered user yet
    
    //method for checking if all co-campers have an event and/or user account?? don't really need it 
    //For checking the email of co-camper exists in database or not we can use the getUserAccount function 
    //of the User class. We can call that method for each of the co-camper emails entered by user to check
    //if his/her friends exist in the database or not.
    public function putInCampers()//must execute this method in camp controller to move the camper emails in campers array
    {
        $campers["Camper1"]=$data["co_camper1"];
        $campers["Camper2"]=$data["co_camper2"];
        $campers["Camper3"]=$data["co_camper3"];
        $campers["Camper4"]=$data["co_camper4"];
        $campers["Camper5"]=$data["co_camper5"];
    }
    
    //verifyEmails method checks whether the emails in the coCampers array all exist in the database and returns 
    //true if they do else returns false
    public function verifyEmails(&$unregistered)
    {
        
        foreach ($campers as $key=>$emails){
            if(user_exists($emails)==false)
                $unregistered[]=$emails;
        }
        if(empty($unregistered))
            return true;
    }
    //method for registering
    public function makeReservation(){
        if(empty($unregistered)){
            
            $conn=  parent::connect();
            $sql="INSERT INTO ".TBL_CAMP_RES." (CampRes_No,Start_Date,End_Date,Account_ID,CAMP_CampID)
            VALUES(:campresNo,:stDate,:eDate,:acctId,:campId)";
        
        }
        else
        {
            echo 'Not all co-campers are registered yet.';
        }
    }
}