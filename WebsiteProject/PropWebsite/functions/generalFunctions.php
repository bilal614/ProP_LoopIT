<?php
//remove special characters of input string, input variable is an item of array
function array_sanitize(&$item){
    $item = mysql_real_escape_string($item);
}
function output_error($error){
    return '<ul "class = errorlist"><li>'.implode('</li><li>',$error) . '</li></ul>';
}

//Using phpMailer to sent email
function sentEmail($email,$hash){
    //testing mail function of php/ didn't work on localhost
    //$msg = 'Pleasmail('thanhhnk@gmail.com','My subject',$msg,'From: customerService@festivaljazz.com')e click this link to activate your account';
    // mail('thanhhnk@gmail.com','My subject',$msg,'From: customerService@festivaljazz.com');
    // try to use phpMailer, it's work
    $mail = new PHPMailer;
    $mail->IsSMTP();                                      // Set mailer to use SMTP
    $mail->Host = 'smtp.gmail.com';                 // Specify main and backup server
    $mail->Port = 587;                                    // Set the SMTP port
    $mail->SMTPAuth = true;                               // Enable SMTP authentication
    $mail->Username = 'loopitjazzfestival@gmail.com';                // SMTP username
    $mail->Password = 'LoopIT2015';                  // SMTP password
    $mail->SMTPSecure = 'tls';                            // Enable encryption, 'ssl' also accepted

    $mail->From = 'jazzfestival@suport.com';
    $mail->FromName = 'Jazz festival team';
    $mail->AddAddress($email);               // Name is optional

    $mail->IsHTML(true);                                  // Set email format to HTML

    $mail->Subject = 'Here is the subject';
    $mail->Subject = 'Activate your account for jazz festival';
    $mail->Body    = 'Click on following link to activate your account'.$code;

    if(!$mail->Send()) {
       echo 'Message could not be sent.';
       echo 'Mailer Error: ' . $mail->ErrorInfo;
       exit;
    }

    echo 'Message has been sent';
}