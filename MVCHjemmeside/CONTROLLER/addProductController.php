<?php
// GET USER INPUTS FROM FORM AND PUT IN A VARIABLE
$productName = $_POST['productName'];
$price = "$" . $_POST['price'];
$imagePath = $_POST['image'];

// GO TO MODEL ADD PRODUCT WITH VARIABLES, SO WE CAN USE _GET TO GET USER INPUTS
header("Location: ../MODEL/addProductModel.php?product_name=$productName&price=$price&image_path=$imagePath");

