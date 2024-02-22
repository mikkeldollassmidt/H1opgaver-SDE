<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="css/style.css">
    <link rel="stylesheet" href="css/font.css">
    <title>Add Product</title>
</head>
<body>
    <h1 class="pageTitle">SneakerSalg</h1>
    <div class="addProductBox">

        <!-- FORM FOR ADDING PRODUCT TO DATABASE -->
        <form action="../CONTROLLER/addProductController.php" method="POST" enctype="multipart/form-data">
            <label for="productName">Product Name:</label><br>
            <input type="text" id="productName" name="productName" required><br>

            <label for="price">Price:</label><br>
            <input type="text" id="price" name="price" required><br>

            <label for="image">Image Path:</label><br>
            <input type="text" id="image" name="image" required><br>

            <button type="submit">Submit</button>
        </form>
    </div>
</body>
</html>
