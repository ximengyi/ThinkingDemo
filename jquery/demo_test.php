<?php
$name = isset($_POST['name'])? htmlspecialchars($_POST['name']):" ";
$age = isset($_POST['name'])? htmlspecialchars($_POST['age']) : " ";
echo "$name\n";
echo "$age\n";
 ?>
