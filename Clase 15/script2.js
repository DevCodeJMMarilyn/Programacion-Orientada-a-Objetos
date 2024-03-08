//Ejemplo de como se reproduce la música de spotify/youtube music en uno o varios dispositivos a la vez
class ProgramarMusica{
    constructor(artista, cancion, dispositivo){
        this.artista = artista
        this.cancion = cancion
        this.dispositivo = dispositivo
    }

    replay(){
        return console.log(`La canción ${this.cancion}, se esta reproduciendo`)
    }
}

class Soundtrack extends ProgramarMusica{
    replay(){
        return console.log(`Se esta reproduciendo ${this.cancion} del artista ${this.artista}, en el ${this.dispositivo}`)
    }
}

class Playlist extends ProgramarMusica{
    replay(){
        return console.log(`Se selecciono ${this.cancion} del artista ${this.artista}, de la playlist "El mejor Soundtrack de tu próxima telenovela LM" en el dispositivo ${this.dispositivo}`)
    }
}

let Sound = new  Soundtrack('Elton John', 'I`m still standing', ['TV TCL','Smartphone S10+'])
let play = new Soundtrack('Soda Stereo', 'Persiana Americana', 'Laptop Chrome Windows 10')
let List = new Playlist('Luis Miguel', 'Cómo', ['Earphones JBL', 'Speaker SKP pro audio'])

Sound.replay()
play.replay()
List.replay()