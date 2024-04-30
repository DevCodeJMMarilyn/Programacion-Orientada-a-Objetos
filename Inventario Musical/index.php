<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="style.css">
    <title>Music Inventory</title>
</head>
<body>
    <h1>Music Inventory</h1>
    <table border="1" class="album-table">
        <tr>
            <th>ID</th>
            <th>Artista</th>
            <th>Álbum</th>
            <th>Formato</th>
            <th>Precio</th>
            <th>Descuento</th>
        </tr>
        
    <?php 
    
    include_once('datos.php');
    $conexion->conectar();
    $discos = $gestion->select();
    foreach($discos as $disco) {
        echo "<tr>";
        echo "<td>".$disco['id']."</td>";
        echo "<td>".$disco['artista']."</td>";
        echo "<td>".$disco['nombre_album']."</td>";
        echo "<td>".$disco['formato']."</td>";
        echo "<td>$".$disco['precio_normal']."</td>";
        // Calcular precio con descuento (por ejemplo, 10%)
        $precio_descuento = $disco['precio_normal'] * 0.9; // 10% de descuento
        echo "<td>$".$precio_descuento."</td>";
        //aquí puedes agregar enlaces para editar y eliminar
        echo "<td><a href='modificar.php?id=".$disco['id']."'>Editar</a> | <a href='datos.php?iddelete=".$disco['id']."&banderaE=3'>Eliminar</a></td>";
        echo "</tr>";
    }
    
    ?>
    </table>
    <a href="registro.php">Agregar Disco</a>
</body>
</html>