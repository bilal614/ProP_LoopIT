<!DOCTYPE html>
<html>
<head>
    <?php
        include('../includes/headTag.php');
    ?>
</head>
<body onload="initialize()">
    <h1>
    <img src="logo.png" alt="logo" style="width:400px;height:70px" />
    </h1>
    <div class="container">
         <?php
            include('../includes/header.php');
        ?>
        <div class="content">
            <p id="route">How to get there?</p>
            <p id="location">Festival location<br></p>
            <p id="location2">This year's JAZZ FESTIVAL will be held Molecaten Park Kuierpad, 7853 TA Wezuperbrug, Netherlands. Gate coordinates: 52.840494, 6.723770</p>
            <p><iframe src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d2409.9595548428388!2d6.721851615722525!3d52.841113820134304!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x47b7e010cfe19b33%3A0xe1bd06427483d7af!2sMolecaten+Park+Kuierpad!5e0!3m2!1slt!2snl!4v1444651184759" width="800" height="450" frameborder="0" style="border:0" allowfullscreen></iframe></p>
            <p id="h2travel">TRAVEL BY BUS / TRAIN</p>
            <p id="travelby">&#8594;Train: Eindhoven &#8594; Emmen<br>&#8594;Train: Amsterdam &#8594; Emmen<br>&#8594;Bus: Eindhoven &#8594; Emmen<br>&#8594;Bus: Amsterdam &#8594; Emmen<br>&#8594;Bus: Maastricht &#8594; Emmen<br> </p>
            <p id="h2travel">TAXI NUMBERS IN EMMEN</p>
            <p id="travelby"><b>+31402871111</b><br><b>+31402871001</b></p>
        </div>
    </div>
    <?php
       include('../includes/footer.php');
    ?>
   <script src="https://maps.googleapis.com/maps/api/js"></script>        
</body>
</html>