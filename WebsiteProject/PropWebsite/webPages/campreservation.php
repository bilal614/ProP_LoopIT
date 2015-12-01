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
               <header class="regHeader">Camp Registration <span></span></header>
               <form id="campForm" action="" method="post">
                   <div id="innerContainer"> 
                    <div id="leftCol">
                            <div>
                                <label for="co_camper1" class="camper" > Co-camper 1 </label>
                                <input type="text" name="co_camper1" placeholder="e-mail of co-camper 1"/>
                            </div>
                            <div>
                                <label for="co_camper2" class="camper" > Co-camper 2 </label>
                                <input type="text" name="co_camper2" placeholder="e-mail of co-camper 2"/>
                            </div>
                            <div>
                                <label for="co_camper3" class="camper" > Co-camper 3 </label>
                                <input type="text" name="co_camper3" placeholder="e-mail of co-camper 3"/>
                            </div>
                            <div>
                                <label for="co_camper4" class="camper" > Co-camper 4 </label>
                                <input type="text" name="co_camper4" placeholder="e-mail of co-camper 4"/>
                            </div>
                        </div>
                        <div id="rightCol">
                            <div>
                                <label for="co_camper5" class="camper" > Co-camper 5 </label>
                                <input type="text" name="co_camper5" placeholder="e-mail of co-camper 5"/>
                            </div>
                            <div id="CampDate">
                                Enter a date after 2015-12-30:<br>
                                <input type="date" name="bday" min="2015-12-30"><br><br>
                                Enter a date before 2016-01-05:<br>
                                <input type="date" name="bday" max="2016-01-05"><br><br>
                            </div>
                        </div>
                        <div id="campButtons">
                            <input type="submit" name="submit" value="Register and Pay"/>
                            <input type="submit" name="skip" value="Skip camping reservation"/>
                        </div>
                   </div>
                </form>
            </div>
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
</body>
</html>