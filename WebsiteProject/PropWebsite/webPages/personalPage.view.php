<!DOCTYPE html>
<html>
<head>
     <?php
        require_once ('../includes/common.inc.php');
        displayHeadTag();
        global $campInfo;
    ?>
<body>
    <h1>
        <img src="../templates/images/logo.png" alt="logo" style="width:400px;height:70px" />
    </h1>
    <div class="container">
         <?php
            displayHeader();   
        ?>
        <div class="content"><!--all content for the content container goes in here!-->
            <div id="mainInfoColumn">
                <div id="welcomeContainer">
                    <h2 id="welcomeMsg">Welcome <?php echo ($infors['First_Name']);?> to your personal page.</h2>
                    <div id="userInfo">
                        <p class="personalPage">Welcome to your personal page. Here you can view important
                            personal information and reminders before the event.</p>
                        <div class="userInfo">
                            Email/User name: <?php echo($infors['E_mail']) ?><br>
                            
                            Name: <?php echo ($infors['First_Name'].' '.$infors['Last_Name']); ?><br>
                            
                            Event ID:<?php echo($infors['Account_ID']);?><br> 
                            IMPORTANT: Your personal event ID will be used as the key for the entrance to this event.
                        </div>
                        <div></div>
                        <div class="userInfo">
                            Camp Reservations:<br>
                            <?php 
                            if(!empty($campInfo)){ 
                                 echo 'Your Camp Reservation Number is ' . $campInfo['CampRes_No']; }?>
                           <?php 
                            if(empty($campInfo)) { echo ('You have no current camp reservations at the moment.'); }?>
                            
                        </div>
                        <a href="logout.php"> 
                            <input type="button" id="logout" name="logout" value="Log out">
                        </a>
                    </div>
                </div>
                <div id="toDoList">
                    <h3>To Do Reminders:<br></h3>
                    <h5 class="ticketReminder">Ticket Payment:</h5>
                    <p class="personalPage">The Jazz festival will take place this coming 
                    February. Before coming to the event you have the option to pay the entrance fee at the 
                    event venue on the day of the event. However you also have the option of paying before the 
                    event date's and availing our limited offer 10€. So click on the link below to take advantage 
                    of this limited time offer and pay now via PayPal!
                    </p>
                    <a href="https://www.paypal.com/nl/webapps/mpp/home"> 
                        <input type="button" id="payBtn" name="payNow" value="Pay Now!">
                    </a>
                    <h5 class="ticketReminder">Camp Reservation (optional):</h5>
                    <?php if(empty($campInfo)) { ?>
                    <p class="personalPage">  
                        For those of you planning to spend the week at the festival you and 
                        upto five friends have the option of renting a campsite on the festival grounds. In order
                        to sign up your friends for the camp-site they must have already registered for the festival 
                        through this web-site. 
                        NOTE: You will have to make the entire payment in full on behalf of all your co-campers 
                        if you choose this option!!!
                    </p>
                        <form action="../controller/personalPage.php" method="post">
                            <input type="submit" id="campReserve" name="CampReserve" value="Make Reservation Now!"/>
                        </form> 
                    <?php }else { ?>
                    <p class="personalPage">
                        You already have a camping reservation. Cannot make anymore camping reservations.
                    </p>
                    <?php } ?>
                </div>
            </div>
        </div>
    </div>
    <?php
        displayFooter();
    ?>             
</body>
</html>