<?php
function output_error($error){
    return '<ul "class = errorlist"><li>'.implode('</li><li>',$error) . '</li></ul>';
}