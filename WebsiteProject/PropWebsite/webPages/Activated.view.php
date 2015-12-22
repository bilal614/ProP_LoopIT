<!DOCTYPE html>
<html>
<head>
     <?php
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
               <header class="regHeader">Thank you! Your account is registered successfully</header>
                <fieldset>
                    <legend  class="RsubHeader">Your information</legend>
                    <form id ="ShowInfor" action="" method="get">
                        <div>
                            <div>
                                <label for="idUser" class="uname" >Your event account is </label>
                                <span id="idUser"><?php echo($infors['Account_ID']);?></span>
                            </div>
                            <div>
                                <label for="full_name" class="uname"  > Full name </label>
                                <span id="full_name"><?php echo ($infors['First_Name'].' '.$infors['Last_Name']); ?></span>
                            </div>
                            <div>
                                <label for="phone" class="uname"  > Phone number </label>
                                <span id="phone"><?php echo($infors['Phone']) ?></span>
                            </div>
                            <div>
                                <label for="email" class="uname"> Your email </label>
                                <span id="email"><?php echo($infors['E_mail']) ?></span>
                            </div>  
                        </div>    
                    </form>
                </fieldset>
                <div class = "paymentRequest">
                    <div class="bg-warning">Please check your email for these information and keep this with you when you show up at our event.</div>
                    <div class="bg-warning"><a href="../controller/login.php">Login here</a></div>
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