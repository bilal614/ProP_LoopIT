<!DOCTYPE html>
<html>
<head>
    <?php
        include('../includes/subPages/headTag.php');
    ?>
   
</head>
<body>
    <h1>
    <img src="../templates/images/logo.png" alt="logo" style="width:400px;height:70px" />
    </h1>
    <div class="container">
        <?php
            include('../includes/subPages/header.php');
        ?>
        
        <div class="content">
        <div id="Regwrapper">
            <header class="regHeader">Please fill the form below to contact us!<span></span></header>
            <form action="<?php echo htmlspecialchars($_SERVER["PHP_SELF"]);?>" method="post">
                <div id ="Cont">
                    <?php
                    // define variables and set to empty values
                    $nameErr = $emailErr = $messageErr = "";
                    $name = $email = $message = "";

                    if ($_SERVER["REQUEST_METHOD"] == "POST") {
                        
                                            
                    if (empty($_POST["email"])) {
                      $emailErr = " Please enter your Email.";
                    } else {
                      $email = test_input($_POST["email"]);
                      // check if e-mail address is well-formed
                      if (!filter_var($email, FILTER_VALIDATE_EMAIL)) {
                        $emailErr = "Invalid email format";
                      }
                    }
    
                    }

                        function test_input($data) {
                           $data = trim($data);
                           $data = stripslashes($data);
                           $data = htmlspecialchars($data);
                           return $data;
                        }
                        ?>
                                <label>Name:</label><br/>
                                <input type="text" name="name" required="required" placeholder=" Name"/> *
                                   <br><br>
                
                                <label>Email:</label><br/>
                                <input type="text" name="email" required="required" placeholder="Email address"/> 
                                <span class="error"> * <?php echo $emailErr;?></span><br><br>                        
                            <label>Message:</label><br/>
                            <textarea cols="50" rows="10" name="message" required></textarea>
                              <br>                        
                            <input type="Submit" name="submit" value="Send"/>
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