alert('Ejercicio 1');
class MaquinaDispensadora {
    constructor(bebida, precio) {
      this._precio = precio;
      this._bebida = bebida;
    };
    darProducto(){
      return`El cliente pidió una bebida ${this._bebida} y el precio es: $${this._precio}`;
    };
}
var bebida1 = new MaquinaDispensadora('Uva', 0.75);
var bebida2 = new MaquinaDispensadora('Fanta', 0.75);
var bebida3 = new MaquinaDispensadora('7UP', 0.75);
var bebida4 = new MaquinaDispensadora('Coca-Cola', 1.00);
var bebida5 = new MaquinaDispensadora('Pepsi', 1.00);
  
console.log(bebida1.darProducto());  
console.log(bebida2.darProducto()); 
console.log(bebida3.darProducto()); 
console.log(bebida4.darProducto());
console.log(bebida5.darProducto()); 