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
        <div id="Regwrapper">
            <header class="regHeader">Please fill the form below to contact us!<span></span></header>
            <form action="" method="post">
                <div id ="Cont">
                                <label>Name:</label><br/>
                                <input type="text", name="name" required="required"  placeholder="Full Name"/><br/>
                
                                <label>Email:</label><br/>
                                <input type="text", name="name" required="required"  placeholder="Email address"/ ><br/>
                            <label>Message:</label><br/>
                            <textarea cols="50" rows="10" required="required" > </textarea>
                            <br/>
                            <input type="Submit" name="submit" value="Send"/>
                    </div>
                        </form>  
                        </div>
                   </div>
                </form>
            </div>
        </div>
     <div class="footer">
         <div class= "container">
          <a href="https://www.facebook.com/" ><img src="fb.png" alt="facebook logo"></a>
         <a href="https://twitter.com/"><img src="twitter.png" alt="twitter logo"></a>
        <span id="footer">Follow us on:</span>
        <div class = "clear"></div>
         </div>
    </div>
            <script src="http://ajax.googleapis.com/ajax/libs/jquery/2.0.0/jquery.min.js"></script>
            <script src="jquery.countdown.min.js"></script>
            <script src="script.js"></script>
    </div>
</body>
</html>