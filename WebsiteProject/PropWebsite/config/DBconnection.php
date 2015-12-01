        <?php
        
//database credentials
        
        
$dbHost='athena01.fhict.local';
$dbUser='dbi333151';
$dbPass='rTnrm7Fajk';
$dbName='dbi333151';

try{
    $db=new PDO("mysql:host=".$dbHost.";dbname=".$dbName,$dbuser,$dbpass);
    $db->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
    echo("Good work.");
}catch(PDOException $e){echo("Connection failed.");}
        /*Connection cannot be made with database while using xampp, because xampp is a local webhost
         * whereas athena is on a remote webserver.*/
?>