alert('Ejercicio 3')
class PerroGalgo{
  constructor(nombre, edad, velocidad) {
    this.nombre = nombre;
    this.edad = edad;
    this.velocidad = velocidad;
  }
  imprimirDatos() {
    console.log(`El canino llamado ${this.nombre} tiene una edad de ${this.edad} años y una velocidad en competencia de ${this.velocidad} km/s`);
  }
}
const perro1 = new PerroGalgo("Chispita", 5, 11.5);
const perro2 = new PerroGalgo("Manchita", 2, 9.4);

perro1.imprimirDatos();
perro2.imprimirDatos();