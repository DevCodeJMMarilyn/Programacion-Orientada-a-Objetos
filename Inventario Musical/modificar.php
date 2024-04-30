<?php
include_once('datos.php');

// Obtener el ID del disco a modificar de la URL
$id = isset($_GET['id']) ? $_GET['id'] : "";
// Conectar a la base de datos
$conexion->conectar();
// Obtener los datos del disco a modificar
$disco = $gestion->selectupdate($id);
// Comprobar si se encontró el disco
if (!$disco) {
    // Redireccionar a la página principal si el disco no existe
    header("Location: index.php");
    exit;
}

// Mostrar el formulario de modificación con los datos del disco
foreach($disco as $fila) {
?>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="style.css">
    <title>Modificar Disco</title>
</head>
<body>
    <h1>Modificar Disco</h1>
    <form action="datos.php" method="post">
        <input type="text" name="bandera" value="2" hidden>
        <input type="text" name="id" value="<?php echo $fila['id']; ?>" hidden>
        <label for="artista">Artista:</label><br>
        <input type="text" name="artista" id="artista" value="<?php echo $fila['artista']; ?>"><br>
        <label for="album">Álbum:</label><br>
        <input type="text" name="nombre_album" id="nombre_album" value="<?php echo $fila['nombre_album']; ?>"><br>
        <label for="formato">Formato:</label><br>
        <input type="text" name="formato" id="formato" value="<?php echo $fila['formato']; ?>"><br>
        <label for="precio">Precio:</label><br>
        <input type="number" name="precio_normal" id="precio_normal" value="<?php echo $fila['precio_normal']; ?>"><br><br>
        <input type="submit" value="Guardar Cambios">
    </form>
</body>
</html>
<?php
}
?>