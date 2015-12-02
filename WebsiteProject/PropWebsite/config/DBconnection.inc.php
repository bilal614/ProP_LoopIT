<?php        
//database credentials to be used for the actual webserver       
/*$dbHost='athena01.fhict.local';
$dbUser='dbi333151';
$dbPass='rTnrm7Fajk';
$dbName='dbi333151';*/
/*
try{
    $db=new PDO("mysql:host=".$dbHost.";dbname=".$dbName,$dbuser,$dbpass);
    $db->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
    echo("Good work.");
}catch(PDOException $e){echo("Connection failed.");}*/
        /*Connection cannot be made with database while using xampp, because xampp is a local webhost
         * whereas athena is on a remote webserver.*/
//sets up the connection to the database on the webserver
/*$mysqli=  mysqli_connect("mysql:host=".$dbHost.";dbname=".$dbName, $dbUser, $dbPass, $dbName);
        if(mysqli_connect_errno($mysqli))
            echo("failed to connect.");*/
        
        
//for development purpose we will use database set up on localhost and eventually move everything to the
//the athena web server
        //NOTE: USE THE COMMAND require 'DBconnection.inc.php WHENEVER YOU WANT TO CONNECT TO DB FROM ANY 
        //OTHER PHP FILE OR PAGE
        $conn_error='Could not connect.';
        
        $connection=  mysql_connect('localhost', 'root', '') || die($conn_error);
        
        $dbSelect=mysql_select_db('prop') || die($conn_error);//selects the database we want from the mysql databases

echo'Connection successful.'."<br>";

//example code to see db connection
$exampleQuery="SELECT * FROM E_ACCOUNT;";
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
    
    $s="$id $Fname $Lname";
echo ($s)."<br>";}

?>