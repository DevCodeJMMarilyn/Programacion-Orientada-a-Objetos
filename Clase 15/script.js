//Polimorfismo
//Ejercicio: Acciones básicas cuando voy al cine
class Cine{
    constructor(boleto, pelicula, nombre){
        this.boleto = boleto;
        this.pelicula= pelicula;
        this.nombre= nombre
    }

    consumo(){
        return console.log(`${this.nombre} pidio ${this.boleto} para la pelicula ${this.pelicula} en Cinemark`)
    }   
}

class Persona1 extends Cine{
    consumo(){
        return console.log(`${this.nombre} pidio ${this.boleto} para la pelicula ${this.pelicula}`)
    }
}

class Persona2 extends Cine{
    consumo(){
        return console.log(`${this.nombre} pidio ${this.boleto} para la pelicula ${this.pelicula}`)
    }
}

let Michelle = new Persona1('2 boletos', 'Volver al Futuro', 'Michelle')
let Marilyn = new Persona2('4 boletos', 'Concierto 2024-Luis Miguel', 'Marilyn')
Michelle.consumo()
Marilyn.consumo()