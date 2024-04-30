<?php
    include_once('datos.php');
    //aceptar pot el get el id para el select que ocupa
    $id = isset($_GET['id']) ? $_GET['id']:"";

    
    $conexion->conectar();
    //desarrolla el select parametizado
    $registro = $gestion->selectupdate($id);
    foreach($registro as $filas){
        
?>
<!DOCTYPE html>
<html lang="en">
<head>
<meta charset="UTF-8">
<meta name="viewport" content="width=device-width, initial-scale=1.0">
<title>Modificar</title>
</head>
<body>
<form action="datos.php" method="post">
<label for="">Nombre</label>
<input type="text" name="bandera" id="" value ="2" hidden>
<input type="text" name="id" id="" value = "<?php echo $filas['id'];?>" hidden><br>
<input type="text" name="nombre" id="" value = "<?php echo $filas['nombre'];?>"><br>
<label for="">Telefono</label><br>
<input type="text" name="telefono" id="" value = "<?php echo $filas['telefono'];?>"><br>
<label for="">Genero</label><br>
<input type="text" name="genero" id="" value = "<?php echo $filas['genero'];?>"><br><br>
<input type="submit" value="enviar">
</form>
<?php
    }
?>

</body>
</html>