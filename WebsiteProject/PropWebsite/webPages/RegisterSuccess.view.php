<!DOCTYPE html>
<html>
<head>
     <?php
        include('../includes/subPages/headTag.php');
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
            include('../includes/subPages/header.php');
        ?>
        <div class="content">
           <div id="RSwapper">
               <header class="regHeader">You have been registered successfully! </header>
                <fieldset>
                    <legend  class="RsubHeader">Your information</legend>
                    <form id ="ShowInfor" action="" method="get">
                        <div>
                            <div>
                                <label for="idUser" class="uname" >Your id is </label>
                                <span id="idUser"><?php echo($eventAccount->getEventID())?></span>
                            </div>
                            <div>
                                <label for="full_name" class="uname"  > Full name </label>
                                <span id="full_name"><?php echo ($eventAccount->getFirstName()); echo($eventAccount->getLastName()); ?></span>
                            </div>
                            <div>
                                <label for="phone" class="uname"  > Phone number </label>
                                <span id="phone"><?php echo($eventAccount->getPhone()) ?></span>
                            </div>
                            <div>
                                <label for="email" class="uname"> Your email </label>
                                <span id="email"><?php echo($eventAccount->getEmail()) ?></span>
                            </div>  
                        </div>    
                    </form>
                </fieldset>
                <div class = "paymentRequest">
                    <div class="bg-warning">Please check your email for the activation of your account.</div>
                </div>
            </div><!--end div#RSwapper-->
         </div><!--End div.content-->
    </div>
   <?php
        include('../includes/subPages/footer.php');
    ?> 
            
</body>
</html>