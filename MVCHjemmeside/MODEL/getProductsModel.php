<?php
// INCLUDE DATABASE CONNECTION
include 'dbconnect.php';

// SELECT ALL PRODUCTS FROM TABLE QUERY
$sql = "SELECT * FROM products";
$result = mysqli_query($conn, $sql);

// IF TABLE IS NOT EMPTY (CHECK FOR ROWS), THEN PRINT THE PRODUCTS IN THESE ELEMENTS.
if (mysqli_num_rows($result) > 0) {
    while ($row = mysqli_fetch_assoc($result)) {
        echo "<div class='productBox'>";
        echo "<div class='productImageContainer'><img class='productImage' src='" . $row["image_path"] . "'></div><br>";
        echo "<h1 class='productName'>" . $row["product_name"] . "</h1><br>";
        echo "<h1 class='productPrice'>" . $row["price"] . "</h1><br>";
        echo "<form action='MODEL/deleteProductModel.php' method='POST'>";
        echo "<input type='hidden' name='product_id' value='" . $row["id"] . "'>"; 
        echo "<button class='deleteButton'type='submit' name='delete'>Delete</button>";
        echo "</form>";
        echo "</div>";
    }
} else {

    // NO ROWS FOUND IN TABLE
    echo "No products found.";
}
?>
