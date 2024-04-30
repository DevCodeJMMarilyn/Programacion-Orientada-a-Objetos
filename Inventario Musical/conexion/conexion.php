<?php
class conexion_bd{
    private $server;
    private $usuario;
    private $contraseña;
    private $db;
    public $conexion;

    public function __construct($server, $usuario, $contraseña, $db){
        $this->server = $server;
        $this->usuario = $usuario;
        $this->contraseña = $contraseña;
        $this->db = $db;
        $this->conexion = null;
        
    }

    public function conectar(){
        $this->conexion = new mysqli($this->server, $this->usuario, $this->contraseña, $this->db); 
        if($this->conexion->connect_error){
            die ("conexion con la base de datos mala".$this->conexion->connect_error);
        }else{
            //echo "conexion con la base de datos buena";
        }
    }
    public function desconectar(){
        if($this->conexion === null){

        }else{
            $this->conexion->close();
            //echo "se cerro la conexion";
        }
    }
}

//objetos 

$conexion = new conexion_bd('localhost', 'root', '','registro');
?>
