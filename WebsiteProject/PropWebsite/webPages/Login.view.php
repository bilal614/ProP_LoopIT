<!DOCTYPE html>
<html>
     <?php
        include ('../includes/common.inc.php');
        displayHeadTag();
     ?>
<body>
    <h1>
        <img src="../templates/images/logo.png" alt="logo" style="width:400px;height:70px" />
    </h1>
    <div class="container">
         <?php
            displayHeader()
        ?>
        <div class="content">
            <?php HandleErrors(); ?>
            <div class="loginMain">
                <div class="login-form">
                    <h1>Login</h1>
                    <form action = "Login.php" method="post">
                        <input name = 'email' type="text" value="Email" class="text" placeholder="Email">
                        <input name = 'password' type="password" value="Password" placeholder="Password">
                        <div class="submit">
                        <input type="submit" value="LOGIN" name="loginForm">
                    </div>	
                        <p><a href="#">Forgot Password ?</a></p>
                    </form>
            </div>
            </div>
        </div>
    </div>
    <?php
        displayFooter();
    ?>             
</body>
</html>
