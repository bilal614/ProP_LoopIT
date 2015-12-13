<!DOCTYPE html>
<html>
<head>
    <?php
        include('../includes/subPages/headTag.php');
    ?>
    <link rel="stylesheet" href="../templates/css/timetablejs.css">
</head>
<body onload="initialize()">
    <h1>
    <img src="../templates/images/logo.png" alt="logo" style="width:400px;height:70px" />
    </h1>
        <div class="container">
        <?php
            //include('../includes/subPages/header.php');
            displayHeader();
        ?>
        <div class="content">
            <h3 id="header" align="left">Festival program for the 10th of June </h3>
            <p id="pargh">
            The FIRST ANNUAL Jazz Festival in Wezuperbrug, Netherlands features world famous jazz musicians and clinicians: D.Angelo and the Vanguard, Jchastity Brown and Alabama Shakes. The phenomenal clinicians will work with organizators of the event throughout the day and perform with the RYAN TRUESDELL AND THE BRUSSELS JAZZ ORCHESTRA for the opening concert beginning at 10am.  Each artist will play three songs and all three will play on the grand finale piece commissioned from saxophonist and composer Tom Kubis. </br> Below you can see precise timetable of the event.
            </p>
            <div class="timetable">      
            </div>
            <p></br>For more information about artists please click <a href="http://www.northseajazz.com/en/program/2015/friday-10-july/timetable/">here</a></p></p>
        </div>
        </div>
     <?php
        //include('../includes/subPages/footer.php');
        displayFooter();
    ?>
            <script src="../js/script.js"></script>
            <script src="../js/timetable.min.js"></script>
</body>
</html>