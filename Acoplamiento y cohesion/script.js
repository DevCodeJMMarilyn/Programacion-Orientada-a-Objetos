class Song {
  constructor(title, artist, album) {
    this.title = title;
    this.artist = artist;
    this.album = album;
  }

  getInfo() {
    return `${this.title} - ${this.artist} (${this.album})`;
  }
}

class Playlist {
  constructor() {
    this.songs = [];
  }

  addSong(song) {
    this.songs.push(song);
  }

  getTotalSongs() {
    return this.songs.length;
  }

  play() {
    console.log("Reproduciendo lista de reproducción:");
    this.songs.forEach(song => console.log(song.getInfo()));
  }

  renderPlaylist() {
    const playlistElement = document.getElementById('playlist-songs');
    playlistElement.innerHTML = '';
    this.songs.forEach(song => {
      const li = document.createElement('li');
      li.classList.add('song-info');
      li.textContent = song.getInfo();
      playlistElement.appendChild(li);
    });

    const totalSongsElement = document.getElementById('total-songs');
    totalSongsElement.textContent = `Canciones en la playlist: ${this.getTotalSongs()}`;
  }
}

const song1 = new Song("El Reloj", "Luis Miguel", "Romances");
const song2 = new Song("Don't You Worry Child", "Swedish House Mafia", "Don't You Worry Child");

const playlist = new Playlist();
playlist.addSong(song1);
playlist.addSong(song2);

console.log("Playlist para sobrevivir los próximos 4 años de la carrera:");
playlist.play();

playlist.renderPlaylist();