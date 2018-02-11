<?php
$jsoncall = htmlspecialchars($_GET['jsoncallback']);
$json_data = '["customname1","customname3"]';
//echo  $jsoncall."(".$json_data.")";
echo $jsoncall."(".$json_data.")";
 ?>
