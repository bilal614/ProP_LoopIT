<!DOCTYPE html>
<html>
<head>
    <title>JAZZ Festival</title>
    <link href="site.css" rel="stylesheet">  
    <link rel="stylesheet" href="http://netdna.bootstrapcdn.com/bootstrap/3.1.1/css/bootstrap.min.css">
</head>
<body>
    <h1>
    <img src="logo.png" alt="logo" style="width:400px;height:70px" />
    </h1>
    <div class="container">
        <div class="navigation">
            <ul class="nav">
                <li>
                    <a href="../index.php">Home</a>
                </li>
                <li>
                    <a href="News_Page.php">News</a>
                </li>
                <li>
                    <a href="#">Program</a>
                    <ul>
                        <li><a href="#">Stage1</a></li>
                        <li><a href="#">Stage2</a></li>
                        <li><a href="#">Liquid BAR</a></li>
                        <li><a href="#">Workshops</a></li>
                        <li><a href="#">Rent\ Repair</a></li>
                    </ul>
                </li>
                <li>
                    <a href="#">Guide</a>
                    <ul>
                        <li><a href="Maps.php">Travel</a></li>
                        <li><a href="festivalmap.php">Festival Map</a></li>
                    </ul>
                </li>
                <li>
                    <a href="Resgister.php">Log in\ Register</a>
                </li>
                <li>
                    <a href="Contact_US.php">Contacts</a>
                </li>
            </ul>
        </div>
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
     <div class="footer">
         <div class= "container">
          <a href="https://www.facebook.com/" ><img src="fb.png" alt="facebook logo"></a>
         <a href="https://twitter.com/"><img src="twitter.png" alt="twitter logo"></a>
        <span id="footer">Follow us on:</span>
        <div class = "clear"></div>
         </div>
    </div>>
            <script src="http://ajax.googleapis.com/ajax/libs/jquery/2.0.0/jquery.min.js"></script>
            <script src="jquery.countdown.min.js"></script>
            <script src="script.js"></script>
            <!-- Bootrap JS -->
            <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.5/js/bootstrap.min.js"></script>
</body>
</html>