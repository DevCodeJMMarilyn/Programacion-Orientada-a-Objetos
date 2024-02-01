alert(`Ejercicio 5`);
class Me{
    constructor(name, edad){
        this.name = name;
        this.edad = edad;
    }
    Jugar(){
        return `Mi nombre es ${this.name}. Tengo ${this.edad} de edad y me gusta jugar Among Us`;
    }
    Leer(){
        return `Mi nombre es ${this.name}. Tengo ${this.edad} de edad y estoy leyendo un libro de Alfredo Espino - Jicaras Tristes`;
    }
    escucharMusica(){
        return `Mi nombre es ${this.name}. Tengo ${this.edad} de edad y estoy escuchando mi playlist variada (Luis Miguel, Coldplay, The Score, Soda stereo, etc)`;
    }
}

const Michelle = new Me('Michelle', 18);
console.log(Michelle.Jugar()); 
console.log(Michelle.Leer());
console.log(Michelle.escucharMusica());