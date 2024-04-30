<link rel="stylesheet" href="style.css">
<form action="datos.php" method="post">
    <input type="text" name="bandera" value="1" hidden>
    <label for="artista">Artista:</label><br>
    <input type="text" name="artista" id="artista" required><br>
    <label for="album">Álbum:</label><br>
    <input type="text" name="nombre_album" id="nombre_album" required><br>
    <label for="formato">Formato:</label><br>
    <input type="text" name="formato" id="formato" required><br>
    <label for="precio">Precio:</label><br>
    <input type="number" name="precio_normal" id="precio_normal" step="0.01" required><br><br>
    <input type="submit" value="Agregar Disco">
</form>