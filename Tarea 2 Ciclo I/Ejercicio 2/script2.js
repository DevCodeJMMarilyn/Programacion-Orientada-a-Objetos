alert('Ejercicio 2');
class Pokemon {
  constructor(nombre) {
    this.nombre = nombre;
  }
}

class EntrenadorPokemon {
  constructor() {
    this.pokebolas = [];
  }
  atraparPokemon(nombrePokemon) {
    const nuevoPokemon = new Pokemon(nombrePokemon);
    this.pokebolas.push(nuevoPokemon);
  }
  seleccionarPokemon(poke) {
    if (this.pokebolas[poke]) {
      const pokemonSeleccionado = this.pokebolas[poke];
      console.log(`${pokemonSeleccionado.nombre}, yo te elijo para la batalla!`);
    } else {
      console.log('La pokebola está vacía, elige una con un Pokémon.');
    }
  }
}

const entrenador = new EntrenadorPokemon();
entrenador.atraparPokemon("Pikachu");
entrenador.atraparPokemon("Charmander");
entrenador.atraparPokemon("Bulbasaur");

entrenador.seleccionarPokemon(0);
entrenador.seleccionarPokemon(1); 
entrenador.seleccionarPokemon(2);
entrenador.seleccionarPokemon(3);