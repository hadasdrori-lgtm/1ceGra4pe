using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using _1ceGra4pe;   
using ViewModel;

namespace _1cegr4apeAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class SelectApiController : ControllerBase
    {
        [HttpGet]
        [ActionName("AdminSelector")]
        public AdminTblList SelectAllAdmins()
        { 
            AdminTblDB db = new AdminTblDB();
            AdminTblList admins = db.SelectAll();
            return admins;
        }
        [HttpGet]
        [ActionName("ArtistSelector")]
        public ArtistTblList SelectAllArtists()
        {
            ArtistTblDB db = new ArtistTblDB();
            ArtistTblList artists = db.SelectAll();
            return artists;
        }

        [HttpGet]
        [ActionName("ChordEventSelector")]
        public ChordEventTblList SelectAllChordEvents()
        {
            ChordEventTblDB db = new ChordEventTblDB();
            ChordEventTblList chordEvents = db.SelectAll();
            return chordEvents;
        }

        [HttpGet]
        [ActionName("GenreSelector")]
        public GenreTblList SelectAllGenres()
        {
            GenreTblDB db = new GenreTblDB();
            GenreTblList genres = db.SelectAll();
            return genres;
        }

        [HttpGet]
        [ActionName("PersonSelector")]
        public PersonTblList SelectAllPersons()
        {
            PersonTblDB db = new PersonTblDB();
            PersonTblList persons = db.SelectAll();
            return persons;
        }

        [HttpGet]
        [ActionName("SongLineSelector")]
        public SongLineTblList SelectAllSongLines()
        {
            SongLineTblDB db = new SongLineTblDB();
            SongLineTblList songLines = db.SelectAll();
            return songLines;
        }

        [HttpGet]
        [ActionName("SongSelector")]
        public SongTblList SelectAllSongs()
        {
            SongTblDB db = new SongTblDB();
            SongTblList songs = db.SelectAll();
            return songs;
        }
        //----------------------------------------------
       
        [HttpPost]
        public int InsertAnArtist(ArtistTbl artist)
        {
            ArtistTblDB db = new ArtistTblDB();
            db.Insert(artist);
            int x = db.SaveChanges();
            return x;
        }

        [HttpPost]
        public int InsertAChordEvent(ChordEventTbl chordEvent)
        {
            ChordEventTblDB db = new ChordEventTblDB();
            db.Insert(chordEvent);
            int x = db.SaveChanges();
            return x;
        }

        [HttpPost]
        public int InsertAGenre(GenreTbl genre)
        {
            GenreTblDB db = new GenreTblDB();
            db.Insert(genre);
            int x = db.SaveChanges();
            return x;
        }

        [HttpPost]
        public int InsertAPerson(PersonTbl person)
        {
            PersonTblDB db = new PersonTblDB();
            db.Insert(person);
            int x = db.SaveChanges();
            return x;
        }

        [HttpPost]
        public int InsertASongLine(SongLineTbl songLine)
        {
            SongLineTblDB db = new SongLineTblDB();
            db.Insert(songLine);
            int x = db.SaveChanges();
            return x;
        }

        [HttpPost]
        public int InsertASong(SongTbl song)
        {
            SongTblDB db = new SongTblDB();
            db.Insert(song);
            int x = db.SaveChanges();
            return x;
        }
        //-------------------------------------------
        [HttpDelete]
        public int DeleteAnArtist(ArtistTbl artist)
        {
            ArtistTblDB db = new ArtistTblDB();
            db.Delete(artist);
            int x = db.SaveChanges();
            return x;
        }

        [HttpDelete]
        public int DeleteAChordEvent(ChordEventTbl chordEvent)
        {
            ChordEventTblDB db = new ChordEventTblDB();
            db.Delete(chordEvent);
            int x = db.SaveChanges();
            return x;
        }

        [HttpDelete]
        public int DeleteAGenre(GenreTbl genre)
        {
            GenreTblDB db = new GenreTblDB();
            db.Delete(genre);
            int x = db.SaveChanges();
            return x;
        }

        [HttpDelete]
        public int DeleteAPerson(PersonTbl person)
        {
            PersonTblDB db = new PersonTblDB();
            db.Delete(person);
            int x = db.SaveChanges();
            return x;
        }

        [HttpDelete]
        public int DeleteASongLine(SongLineTbl songLine)
        {
            SongLineTblDB db = new SongLineTblDB();
            db.Delete(songLine);
            int x = db.SaveChanges();
            return x;
        }

        [HttpDelete]
        public int DeleteASong(SongTbl song)
        {
            SongTblDB db = new SongTblDB();
            db.Delete(song);
            int x = db.SaveChanges();
            return x;
        }
        //---------------------------------------------------------

        [HttpPut]
        public int UpdateAnArtist(ArtistTbl artist)
        {
            ArtistTblDB db = new ArtistTblDB();
            db.Update(artist);
            int x = db.SaveChanges();
            return x;
        }

        [HttpPut]
        public int UpdateAChordEvent(ChordEventTbl chordEvent)
        {
            ChordEventTblDB db = new ChordEventTblDB();
            db.Update(chordEvent);
            int x = db.SaveChanges();
            return x;
        }

        [HttpPut]
        public int UpdateAGenre(GenreTbl genre)
        {
            GenreTblDB db = new GenreTblDB();
            db.Update(genre);
            int x = db.SaveChanges();
            return x;
        }

        [HttpPut]
        public int UpdateAPerson(PersonTbl person)
        {
            PersonTblDB db = new PersonTblDB();
            db.Update(person);
            int x = db.SaveChanges();
            return x;
        }

        [HttpPut]
        public int UpdateASongLine(SongLineTbl songLine)
        {
            SongLineTblDB db = new SongLineTblDB();
            db.Update(songLine);
            int x = db.SaveChanges();
            return x;
        }

        [HttpPut]
        public int UpdateASong(SongTbl song)
        {
            SongTblDB db = new SongTblDB();
            db.Update(song);
            int x = db.SaveChanges();
            return x;
        }
    }
}
