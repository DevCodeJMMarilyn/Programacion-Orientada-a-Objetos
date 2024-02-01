alert('Ejercicio 4');
class Estudiante {
  constructor(nombre, promedioCiclo) {
    this.nombre = nombre;
    this.promedioCiclo = promedioCiclo;
    }
    mostrarMensaje() {
        return `El estudiante ${this.nombre} tiene un promedio del ciclo de ${this.promedioCiclo}`;
    }
}
const estudiante1 = new Estudiante("Marilyn Michelle Jiménez Arias", 8.9);
const estudiante2 = new Estudiante("Anibal Andrade", 9.2);

console.log(estudiante1.mostrarMensaje());
console.log(estudiante2.mostrarMensaje());
