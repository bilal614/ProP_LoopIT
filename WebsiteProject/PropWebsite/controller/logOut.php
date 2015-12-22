<?php
session_start();
session_destroy();
$_SESSION = Array();//Reinitalize the global section variable
header("Location: login.php");
