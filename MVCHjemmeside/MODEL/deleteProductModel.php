<?php
// INCLUDE DATABASE CONNECTION
include 'dbconnect.php';

// GET PRODUCT ID AND USE IN QUERY TO DELETE PRODUCT
if(isset($_POST['delete']) && isset($_POST['product_id'])) {
    $product_id = $_POST['product_id'];
    $sql = "DELETE FROM products WHERE id = $product_id";
    
    // IF EVERYTHING SUCCESS GO REDIRECT.
    if (mysqli_query($conn, $sql)) {
        header("Location: ../CONTROLLER/redirectToHomePageController.php");
    } else {
        echo "Error deleting product: " . mysqli_error($conn);
    }
} else {
    echo "Invalid request.";
}
