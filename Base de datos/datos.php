<?php
$bandera = isset($_POST['bandera']) ? $_POST['bandera']: "";
$nombre = isset($_POST['nombre']) ? $_POST['nombre']:"";
$telefono = isset($_POST['telefono']) ? $_POST['telefono']:"";
$genero = isset($_POST['genero'])? $_POST['genero']:"";
$banderaE = isset($_GET['banderaE']) ? $_GET['banderaE']: "";
$ids = isset($_POST['id']) ? $_POST['id']: "";
$idd= isset($_GET['iddelete']) ? $_GET['iddelete']: "";
include_once('conexion/conexion.php');

class registro{
    public $conexion ;
    public function __construct($conexion){
    $this->conexion = $conexion;
}
//metodo seleccion
public function select(){
    $consultaSelect= "SELECT * FROM registro";
    $ejecutar_consulta = $this->conexion->conexion->query($consultaSelect);
    return $ejecutar_consulta->fetch_all(MYSQLI_ASSOC);

}

public function insert($datos){
    $campos = implode(',', array_keys($datos));
    var_dump($campos);
    $valores = "'".implode("','", array_values($datos))."'";
    var_dump($valores);
    $consulta_insertar =" INSERT INTO registro ($campos) VALUES ($valores)";
    var_dump($consulta_insertar);
    $resultado = $this->conexion->conexion->query($consulta_insertar);

        if ($resultado){
            return true;
        }else{
            $this->conexion->conexion->error;
        }
    }
//selectupdate
    public function selectupdate($id){
        $consultaSelect= "SELECT * FROM registro WHERE id=$id";
        $ejecutar_consulta = $this->conexion->conexion->query($consultaSelect);
        return $ejecutar_consulta->fetch_all(MYSQLI_ASSOC);
    }
//update fuction
    public function update($id, $datos){
        $set = [];
        foreach ($datos as $campo => $valor){
            $set[] = "$campo = '$valor'";
        }
        $set = implode (',', $set);
      
        $consulta_actualizar = "UPDATE registro SET $set WHERE id = $id";
        $resultado = $this->conexion->conexion->query($consulta_actualizar);
        if($resultado){
            return true;
        }else{
            return $this->conexion->conexion->error;
        }
    }

    //metodod de eliminacion
    public function delete($id){
        $consultadelete = "DELETE FROM registro WHERE id = $id";
        $ejecutar_delete = $this->conexion->conexion->query($consultadelete);
        return $ejecutar_delete;
    }
}

$gestion = new registro($conexion);
//identificacion de banderas para el proceso
//bandera 1
if ($bandera == 1){
$datosInsert = array('nombre' => $nombre, 'telefono' => $telefono, 'genero' => $genero);
$conexion -> conectar();
$prueba = $gestion->insert($datosInsert);

if ($prueba){
    header("Location: index.php");
    }
//bandera 2
}
else if($bandera == 2){
    $id = $ids;
    $datosUpdate = array('nombre' => $nombre, 'telefono' => $telefono, 'genero' => $genero);
    var_dump($datosUpdate);
    $conexion -> conectar();
    $prueba = $gestion->update($id, $datosUpdate);

    if ($prueba){
        header("Location: index.php");
    }
}
else if($banderaE == 3){
    $conexion -> conectar();
    $prueba = $gestion->delete($idd);
    if ($prueba){
        header("Location: index.php");
    }
}
?>