// Estructura de datos del usuario
class Usuario {
  constructor(nombre, fechaNacimiento, genero, departamento, ciudad, telefono, descripcion) {
      this.nombre = nombre;
      this.fechaNacimiento = fechaNacimiento;
      this.genero = genero;
      this.departamento = departamento;
      this.ciudad = ciudad;
      this.telefono = telefono;
      this.descripcion = descripcion;
  }
}

// Función para validar el inicio de sesión
function validarInicioSesion(usuario, contraseña) {
  if (usuario === "Michelle Jimenez" && contraseña === "123456") {
      return "credencialesCorrectas";
  } else if (usuario !== "Michelle Jimenez" && contraseña === "123456") {
      return "usuarioIncorrecto";
  } else if (usuario === "Michelle Jimenez" && contraseña !== "123456") {
      return "contraseñaIncorrecta";
  } else {
      return "ambasIncorrectas";
  }
}

// Función para mostrar los datos del usuario
function mostrarDatosUsuario() {
  let nombre = document.getElementById('nombre').value
  let fecha = document.getElementById('fechaNacimiento').value
  let genero = document.getElementById('genero').value
  let departamento = document.getElementById('departamento').value
  let ciudad = document.getElementById('ciudad').value
  let descripcion =document.getElementById('descripcion').value

  var url= 'perfil.html?nombre=' +encodeURIComponent(nombre)+
  '&fecha=' +encodeURIComponent(fecha)+
  '&genero=' +encodeURIComponent(genero)+
  '&departamento=' +encodeURIComponent(departamento)+
  '&ciudad=' +encodeURIComponent(ciudad)+
  '&telefono=' +encodeURIComponent(telefono)+
  '&descripcion=' +encodeURIComponent(descripcion)
  window.location.href = url;
}

// Función para iniciar sesión
function iniciarSesion() {
  const usuario = document.getElementById('usuario').value;
  const contraseña = document.getElementById('contraseña').value;

  const resultado = validarInicioSesion(usuario, contraseña);

  if (resultado === "credencialesCorrectas") {
    //   const usuario = new Usuario(
    //       "Marilyn Michelle Jimenez Arias",
    //       "02/10/2005",
    //       "Femenino",
    //       "San Miguel",
    //       "San Miguel",
    //       "123456789",
    //       "Estudiante de Ingeniería En Desarrollo de Software"
    //   );
      
    //   // Mostrar los datos del usuario en el perfil
    //   mostrarDatosUsuario(usuario);

    //   // Ocultar el formulario de inicio de sesión y mostrar el perfil del usuario
    //   document.getElementById('formularioLogin').style.display = 'none';
    //   document.getElementById('perfilUsuario').style.display = 'block';
  } else {
      let mensaje = "";
      if (resultado === "usuarioIncorrecto") {
          mensaje = "Usuario incorrecto. ";
      }
      if (resultado === "contraseñaIncorrecta") {
          mensaje += "Contraseña incorrecta.";
      }
      if (resultado === "ambasIncorrectas") {
          mensaje = "Usuario y contraseña incorrectos.";
      }
      document.getElementById('mensajeError').textContent = mensaje;
  }
}
