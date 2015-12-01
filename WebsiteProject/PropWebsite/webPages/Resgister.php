<!DOCTYPE html>
<html>
<head>
     <?php
        include('../includes/subPages/headTag.php');
    ?>
    <script src="../js/jquery.validate.min.js" type="text/javascript"></script>
    <script src="../js/additional-methods.min.js" type="text/javascript"></script>
    
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
               <header class="regHeader">Register to join our Jazz event right now! <span></span></header>
               <form action="" method="post" id="registerForm">
                    <div>
                        <div class="form-group">
                            <label for="first_name" class="uname" > First name </label>
                            <input type="text" name="first_name" id="first_name" placeholder="First Name" />
                        </div>
                        <div class="form-group">
                            <label for="last_name" class="uname"  > Last name </label>
                            <input type="text" name="last_name" id="last_name" placeholder="Last Name"/>
                        </div>
                        <div class="form-group">
                            <label for="phone" class="uname"  > Phone number </label>
                             <input type="text" name="phone" id="phone" placeholder="Phone number"/>
                        </div>
                        <div class="form-group">
                            <label for="email" class="uname"> Your email </label>
                            <input type="text" name="email" id="email" placeholder="Email"/>
                        </div>  
                        <div>
                             <input type="submit" value="SUBMIT" name="">
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