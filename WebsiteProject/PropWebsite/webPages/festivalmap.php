<!DOCTYPE html>
<html>
<head>
     <?php
        include('../includes/subPages/headTag.php');
    ?>
</head>
<body onload="initialize()">
    <h1>
        <img src="../templates/images/logo.png" alt="logo" style="width:400px;height:70px" />
    </h1>
    <div class="container">
        <?php
            include('../includes/subPages/header.php');
        ?>
        <div class="content">
            <p id="route">Festival Map</p>
            <img id="map" src="../templates/images/map.jpeg" alt="festMap" style="width:650px;height:450px">
        </div>
    </div>
    <?php
        include('../includes/subPages/footer.php');
    ?> 
</body>
</html>