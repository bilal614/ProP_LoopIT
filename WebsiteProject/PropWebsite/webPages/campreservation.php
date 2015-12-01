<!DOCTYPE html>
<html>
<head>
     <?php
        include('../includes/subPages/headTag.php');
    ?>
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
    <?php
        include('../includes/subPages/footer.php');
    ?> 
</body>
</html>