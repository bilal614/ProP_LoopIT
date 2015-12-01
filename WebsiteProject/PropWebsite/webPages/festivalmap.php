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
            <p id="route">Festival Map</p>
            <img id="map" src="map.jpeg" alt="festMap" style="width:650px;height:450px">
        </div>
    </div>
    <?php
       include('../includes/footer.php');
    ?>  
</body>
</html>