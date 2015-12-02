
<!DOCTYPE html>
<html>
<head>
     <?php
        include('../includes/subPages/headTag.php');
    ?>
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
                <div class="loginMain">
                    <div class="login-form">
                        <h1>Login</h>
                        <form action = "" method="post">
                            <input name = 'email' type="text" onblur="if (this.value == '') {this.value = 'Email';}" onfocus="this.value = '';" value="Email" class="text">
                            <input name = 'password' type="password" onblur="if (this.value == '') {this.value = 'Password';}" onfocus="this.value = '';" value="Password">
                            <div class="submit">
                            <input type="submit" value="LOGIN" name="loginForm">
                        </div>	
                            <p><a href="#">Forgot Password ?</a></p>
                        </form>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <?php
        include('../includes/subPages/footer.php');
    ?>             
</body>
</html>
