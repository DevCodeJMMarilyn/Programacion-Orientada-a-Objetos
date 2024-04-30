<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
<table border = "1">
            <tr>
                <th>id</th>
                <th>nombre</th>
                <th>telefono</th>
                <th>genero</th>
            </tr>
        
    <?php 
    
    include_once('datos.php');
    $conexion->conectar();
    $registro = $gestion->select();
    foreach($registro as $filas) {
        echo "<tr>";
        echo "<td>".$filas['id']."</td>";
        echo "<td>".$filas['nombre']."</td>";
        echo "<td>".$filas['telefono']."</td>";
        echo "<td>".$filas['genero']."</td>";
        //agregar columnas de modificar y eliminar
        echo "<td><a href='modificar.php?id=".$filas['id']."'>Modificar</a><a href='datos.php?iddelete=".$filas['id']."&banderaE=3'>Eliminar</a></td>";
        echo "</tr>";
    }
    
    ?>
    </table>
    <a href="registro.php">Registrar</a>
</body>
</html>