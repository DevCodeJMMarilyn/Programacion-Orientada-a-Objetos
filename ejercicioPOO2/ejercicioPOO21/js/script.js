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

// Función para iniciar sesión
function iniciarSesion() {
  const usuario = document.getElementById('usuario').value;
  const contraseña = document.getElementById('contraseña').value;

  const resultado = validarInicioSesion(usuario, contraseña);

  if (resultado === "credencialesCorrectas") {
      window.location.href = "perfil.html";
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

// Función para mostrar los datos del usuario
function mostrarDatosUsuario() {
  // Obtener valores de los campos del formulario
  let nombre = document.getElementById('nombre').value;
  let fecha = document.getElementById('fechaNacimiento').value;
  let genero = document.getElementById('genero').value;
  let departamento = document.getElementById('departamento').value;
  let ciudad = document.getElementById('ciudad').value;
  let telefono = document.getElementById('telefono').value;
  let descripcion = document.getElementById('descripcion').value;

  // Construir la URL con los datos del usuario
  var url = 'perfil.html?nombre=' + encodeURIComponent(nombre) +
      '&fecha=' + encodeURIComponent(fecha) +
      '&genero=' + encodeURIComponent(genero) +
      '&departamento=' + encodeURIComponent(departamento) +
      '&ciudad=' + encodeURIComponent(ciudad) +
      '&telefono=' + encodeURIComponent(telefono) +
      '&descripcion=' + encodeURIComponent(descripcion);

  // Redireccionar a perfil.html con los datos del usuario en la URL
  window.location.href = url;
}

// Función para redireccionar a editar.html
function redireccionarAEditar() {
  window.location.href = "editar.html";
}
