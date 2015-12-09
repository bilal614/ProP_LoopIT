<?php
//remove special characters of input string, input variable is an item of array
function array_sanitize(&$item){
    $item = mysql_real_escape_string($item);
}
function output_error($error){
    return '<ul "class = errorlist"><li>'.implode('</li><li>',$error) . '</li></ul>';
}