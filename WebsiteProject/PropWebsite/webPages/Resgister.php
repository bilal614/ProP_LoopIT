<!DOCTYPE html>
<html>
<head>
    <?php
        include('../includes/headTag.php');
    ?>
</head>
<body>
    <h1>
    <img src="logo.png" alt="logo" style="width:400px;height:70px" />
    </h1>
    <div class="container">
        <?php
            include('../includes/header.php');
        ?>
        <div class="content">
           <div id="Regwrapper">
               <header class="regHeader">Register to join our Jazz event right now! <span></span></header>
               <form action="" method="post">
                    <div>
                        <div>
                            <label for="first_name" class="uname" > First name </label>
                            <input type="text" name="first_name" placeholder="First Name"/>
                        </div>
                        <div>
                            <label for="last_name" class="uname"  > Last name </label>
                            <input type="text" name="last_name" placeholder="Last Name"/>
                        </div>
                        <div>
                            <label for="phone" class="uname"  > Phone number </label>
                             <input type="text" name="phone" placeholder="Phone number"/>
                        </div>
                        <div>
                            <label for="email" class="uname"> Your email </label>
                            <input type="text" name="email" placeholder="Email"/>
                        </div>  
                        <a href="RegisterSuccess.php" class="register">Register</a>
                    </div>    
                </form>
            </div>
        </div>
    </div>
    <?php
       include('../includes/footer.php');
    ?>  
</body>
</html>