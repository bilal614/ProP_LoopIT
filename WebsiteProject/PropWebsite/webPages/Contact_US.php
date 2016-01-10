<!DOCTYPE html>
<html>
<head>
    <?php include ('../includes/common.inc.php');
        displayHeadTag();
    ?>
    <script src="../js/jquery.validate.min.js" type="text/javascript"></script>
    <script src="../js/additional-methods.min.js" type="text/javascript"></script>
</head>
<body>
    <h1>
    <img src="../templates/images/logo.png" alt="logo" style="width:400px;height:70px" />
    </h1>
    <div class="container">
        <?php
            displayHeader()
        ?>
        
        <div class="content">
        <div id="Regwrapper">
            <header class="regHeader">Please fill the form below to contact us!<span></span></header>
            <?php if(isset($errors) && empty($errors) === false) { echo output_error($errors);  } ?>
               <form action="mailto:michaberard@yahoo.fr" method="post" id="contactForm">
                <div id ="Cont">
                    <label for="name">Name:</label><br/>
                                <input type="text" name="name" placeholder="Name"/> *
                                   <br><br>
                
                                   <label for="email">Email:</label><br/>
                                <input type="text" name="email" placeholder="Email address"/> 
                                <span> * </span><br><br>                        
                                <label for="message">Message:</label><br/>
                            <textarea cols="50" rows="10" name="message"></textarea>
                              <br>                        
                            <input type="Submit" name="submit" value="Send"/>
                    </div>
               </form>  
                        </div>
                   </div>
               </div>
    <?php
        displayFooter()
    ?>
    
</body>
</html>