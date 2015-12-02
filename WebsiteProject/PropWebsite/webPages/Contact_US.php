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
            <form action="" method="post">
                <div id ="Cont">
                                <label>Name:</label><br/>
                                <input type="text" name="name" required="required"  placeholder="Full Name"/><br/>
                
                                <label>Email:</label><br/>
                                <input type="text" name="name" required="required"  placeholder="Email address"/><br/>
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
    <?php
        include('../includes/subPages/footer.php');
    ?>
    
</body>
</html>