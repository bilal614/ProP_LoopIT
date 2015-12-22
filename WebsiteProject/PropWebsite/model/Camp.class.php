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
    
    protected $coCampers=array(
        "Camper1"=> "",
        "Camper2"=>"",
        "Camper3"=>"",
        "Camper4"=>"",
        "Camper5"=>"",
       );
    //method for checking if all co-campers have an event and/or user account?? don't really need it 
    //For checking the email of co-camper exists in database or not we can use the getUserAccount function 
    //of the User class. We can call that method for each of the co-camper emails entered by user to check
    //if his/her friends exist in the database or not.
    public function getEmails($formEmails)//this method will take an ARRAY of emails entered by the user making reservation
    {
        reset($formEmails);
        foreach ($coCampers as $key=>$emails){
            $emails=each($formEmails);
        }
    }
    
    //verifyEmails method checks whether the emails in the coCampers array all exist in the database and returns 
    //true if they do else returns false
    public function verifyEmails()
    {
        foreach ($coCampers as $key=>$emails){
            if(user_exists($emails)==false)
                return false;
            else
                return true;
        }
    }
    //method for registering
}