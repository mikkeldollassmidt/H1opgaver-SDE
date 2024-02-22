<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="view/css/style.css">
    <link rel="stylesheet" href="view/css/font.css">
    <title>Sneakers</title>
</head>

<body>
    <h1 class="pageTitle">SneakerSalg</h1>
    <div class="productContainer">

    <!-- BUTTON TO ADD PRODUCT -->
        <a style="text-decoration: none;" href="VIEW/addProductView.php">
            <div class="productAddBox">
                <h1 class="productAddBoxSymbol">+</h1>
            </div>
        </a>

        <!-- SHOW PRODUCTS FROM DATABASE -->
        <?php include("CONTROLLER/getProductsController.php"); ?>

    </div>
</body>

</html>