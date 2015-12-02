
<!DOCTYPE html>
<html>
<head>
     <?php
        include('../includes/subPages/headTag.php');
    ?>
<body>
    <h1>
        <img src="../templates/images/logo.png" alt="logo" style="width:400px;height:70px" />
    </h1>
    <div class="container">
         <?php
            include('../includes/subPages/header.php');
        ?>
        <div class="content">
            <div class="loginMain">
                <div class="login-form">
                    <h1>Login</h1>
                    <form action = "" method="post">
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
        include('../includes/subPages/footer.php');
    ?>             
</body>
</html>
