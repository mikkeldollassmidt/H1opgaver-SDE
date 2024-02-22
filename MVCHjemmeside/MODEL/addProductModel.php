<?php
// INCLUDE DATABASE CONNECTION
include 'dbconnect.php';

// GET USER INPUTTED ITEMS FROM URL WITH _GET AND PUT THEM IN A VARIABLE
$productName = isset($_GET['product_name']) ? $_GET['product_name'] : "";
$price = isset($_GET['price']) ? $_GET['price'] : "";
$imagePath = isset($_GET['image_path']) ? $_GET['image_path'] : "";

// QUERY TO INSERT A PRODUCT TO DATABASE
$sql = "INSERT INTO products (product_name, price, image_path) VALUES ('$productName', '$price', '$imagePath')";

if (mysqli_query($conn, $sql)) {
    // CONNECTION SUCCESS, QUERY SUCCESS GO TO REDIRECT.
    header("Location: ../CONTROLLER/redirectToHomePageController.php");
} else {
    echo "Error: " . $sql . "<br>" . mysqli_error($conn);
}


mysqli_close($conn);
?>
