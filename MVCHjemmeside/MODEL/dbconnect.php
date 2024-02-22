<?php
$servername = "localhost";
$database = "sneakersalg";
$username = "root";
$password = "";
 
// CREATE CONNECTION
 
$conn = mysqli_connect($servername, $username, $password, $database);
 
// CHECK CONNECTION
 
if (!$conn) {
 
    die("Connection failed: " . mysqli_connect_error());
 
}
?>