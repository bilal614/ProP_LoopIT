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
    <img src="logo.png" alt="logo" style="width:400px;height:70px" />
    </h1>
    <div class="container">
         <?php
            include('../includes/subPages/header.php');
        ?>
        <div class="content">
           <div id="RSwapper">
               <header class="regHeader">You have been registered sucessfully! </header>
                <fieldset>
                    <legend  class="RsubHeader">Your information</legend>
                    <form id ="ShowInfor" action="" method="get">
                        <div>
                            <div>
                                <label for="idUser" class="uname" >Your id is </label>
                                <span id="idUser">Thanh</span>
                            </div>
                            <div>
                                <label for="full_name" class="uname"  > Full name </label>
                                <span id="full_name">Huynh</span>
                            </div>
                            <div>
                                <label for="phone" class="uname"  > Phone number </label>
                                <span id="phone">0688093212</span>
                            </div>
                            <div>
                                <label for="email" class="uname"> Your email </label>
                                <span id="email">thanhhnk@gmail.com</span>
                            </div>  
                        </div>    
                    </form>
                </fieldset>
                <div class = "paymentRequest">
                    <div class="bg-warning">The entrance price is 55 euro</div>
                    <div class="bg-info">Would you like to pay right now?</div>
                    <div >
                        <a class="btn btn-default white-tooltip" href="campreservation.php" title="If you pay right now, you can make the camp reservation and get 10 euro for discount">Pay now</a>
                        <button type="button" class="btn btn-default white-tooltip" data-toggle="tooltip" data-placement="bottom" title="If you pay at the event, you cannot make the camp reservation">Pay letter                          </button>
                    </div>
                </div>
            </div><!--end div#RSwapper-->
         </div><!--End div.content-->
    </div>
   <?php
        include('../includes/subPages/footer.php');
    ?> 
            
</body>
</html>