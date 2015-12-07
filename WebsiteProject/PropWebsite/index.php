<!DOCTYPE html>
<html>
<head>
    <title>JAZZ Festival</title>
    <link href="templates/css/site.css" rel="stylesheet">  
    <link rel="stylesheet" href="http://netdna.bootstrapcdn.com/bootstrap/3.1.1/css/bootstrap.min.css">
</head>
<body><h1>
        <img src="templates/images/logo.png" alt="logo" style="width:400px;height:70px" />
    </h1>
    <div class="container">
        <div class="navigation">
            <ul class="nav">
                <li>
                    <a href="index.php">Home</a>
                </li>
                <li>
                    <a href="webPages/News_Page.php">News</a>
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
                        <li><a href="webPages/Maps.php">Travel</a></li>
                        <li><a href="webPages/festivalmap.php">Festival Map</a></li>
                    </ul>
                </li>
                <li>
                    <a href="#">Log in\ Register</a>
                    <ul>
                        <li><a href="webPages/Login.php">Login</a></li>
                        <li><a href="webPages/Register.php">Register</a></li>
                    </ul>
                </li>
                <li>
                    <a href="webPages/Contact_US.php">Contacts</a>
                </li>
            </ul>
        </div>
        <div class="content BG">
            <p>
                <img src="templates/images/jazz.png" alt="logo1" style="width:500px;height:300px; padding-top: 40px;">
            </p>
        
            <div class="countdown countdown-container">
                <div class="clock">
                    <div class="clock-item clock-days countdown-time-value">
                        <div class="wrap">
                            <div class="inner">
                                <div id="canvas-days" class="clock-canvas"></div>

                                <div class="text">
                                    <p class="val">0</p>
                                    <p class="type-days type-time">DAYS</p>
                                </div><!-- /.text -->
                            </div><!-- /.inner -->
                        </div><!-- /.wrap -->
                    </div><!-- /.clock-item -->

                    <div class="clock-item clock-hours countdown-time-value">
                        <div class="wrap">
                            <div class="inner">
                                <div id="canvas-hours" class="clock-canvas"></div>

                                <div class="text">
                                    <p class="val">0</p>
                                    <p class="type-hours type-time">HOURS</p>
                                </div><!-- /.text -->
                            </div><!-- /.inner -->
                        </div><!-- /.wrap -->
                    </div><!-- /.clock-item -->

                    <div class="clock-item clock-minutes countdown-time-value">
                        <div class="wrap">
                            <div class="inner">
                                <div id="canvas-minutes" class="clock-canvas"></div>

                                <div class="text">
                                    <p class="val">0</p>
                                    <p class="type-minutes type-time">MINUTES</p>
                                </div><!-- /.text -->
                            </div><!-- /.inner -->
                        </div><!-- /.wrap -->
                    </div><!-- /.clock-item -->

                    <div class="clock-item clock-seconds countdown-time-value">
                        <div class="wrap">
                            <div class="inner">
                                <div id="canvas-seconds" class="clock-canvas"></div>

                                <div class="text">
                                    <p class="val">0</p>
                                    <p class="type-seconds type-time">SECONDS</p>
                                </div><!-- /.text -->
                            </div><!-- /.inner -->
                        </div><!-- /.wrap -->
                    </div><!-- /.clock-item -->
                </div><!-- /.clock -->
            </div><!-- /.countdown-wrapper -->
            <div style="clear: both;"></div>
        </div> 
    </div>        
    <div class="footer">
         <div class= "container">
             <a href="https://www.facebook.com/" ><img src="templates/images/fb.png" alt="facebook logo"></a>
             <a href="https://twitter.com/"><img src="templates/images/twitter.png" alt="twitter logo"></a>
        <span id="footer">Follow us on:</span>
        <div class = "clear"></div>
         </div>
    </div>
    <script src="http://ajax.googleapis.com/ajax/libs/jquery/2.0.0/jquery.min.js"></script>
    <script src="js/query.countdown.min.js"></script>
    <script src="js/script.js"></script>
    <script type="text/javascript" src="js/kinetic.js"></script>
    <script type="text/javascript" src="js/jquery.final-countdown.js"></script>
    <script type="text/javascript">
    $('.countdown').final_countdown({
        start: '1441104300',
        end: '1452941100',
        now: ((new Date).getTime()/1000).toString()
    });
    </script>
</body>
</html>
