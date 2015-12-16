<!DOCTYPE html>
<html>
<head>
     <?php
        //include('../includes/subPages/headTag.php');
        include ('../includes/common.inc.php');
        displayHeadTag();
    ?>
    <!-- Bootrap JS -->
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.5/js/bootstrap.min.js"></script>
</head>
<body>
    <h1>
    <img src="../templates/images/logo.png" alt="logo" style="width:400px;height:70px" />
    </h1>
    <div class="container">
         <?php
            //include('../includes/subPages/header.php');
            displayHeader();
        ?>
        <div class="content">
           <div id="RSwapper">
                <header class="regHeader">Welcome <?php echo($_SESSION['name']);?> to our festival!</header>
                <div class = "paymentRequest">
                    <div class="bg-warning">You have been registered successfully! Please check the following email for the activation of your account: <?php echo($_SESSION['email']);?></div>
                </div>
            </div><!--end div#RSwapper-->
         </div><!--End div.content-->
    </div>
   <?php
        //include('../includes/subPages/footer.php');
        displayFooter();
    ?> 
            
</body>
</html>