using _1ceGra4pe;
using System.Data;
using ViewModel;
namespace Tester
{
    internal class Program
    {
        static void Main(string[] args)
        {




            //PersonTblDB db = new();        //// UPDATE AND SHOW AND INSERT AND DELETE
            //PersonTblList personTbls = db.SelectAll();
            //foreach (PersonTbl p in personTbls)
            //{
            //    Console.WriteLine(p.Name);
            //}
            //PersonTbl personToUpdate = personTbls[0];
            //personToUpdate.Name += "MUSTAAAAAARD";
            //db.Update(personToUpdate);
            //int x = db.SaveChanges();
            //Console.WriteLine($"{x} rows were updated");
            //PersonTblDB pdb = new();
            //PersonTbl myPerson = new PersonTbl() { Name = "JugHead", Email = "jughead@gmail.com", Passw = "2121212" };
            //pdb.Insert(myPerson);
            //int x = pdb.SaveChanges();
            //Console.WriteLine($"{x} rows inserted");
            //PersonTblDB pdb = new();
            //PersonTblList personTbls = pdb.SelectAll();

            //PersonTbl myPerson = personTbls
            //    .FirstOrDefault(p => p.Id == 11);

            //if (myPerson != null)
            //{
            //    pdb.Delete(myPerson);
            //    int x = pdb.SaveChanges();

            //    Console.WriteLine($"{x} rows were deleted");
            //}
            //else
            //{
            //    Console.WriteLine("Person not found");
            //}



            //GenreTblDB db1 = new();  //// UPDATE AND SHOW AND INSERT DELETE
            //GenreTblList genereTbls = db1.SelectAll();
            //foreach (GenreTbl p in genereTbls)
            //{
            //    Console.WriteLine(p.Genre);
            //}
            //GenreTbl personToUpdate = genereTbls[0];
            //personToUpdate.Genre = "hard hard metal music";
            //db1.Update(personToUpdate);
            //int x = db1.SaveChanges();
            //Console.WriteLine($"{x} rows were updated");
            //GenreTblDB gdb = new();
            //GenreTbl myGenre = new GenreTbl() { Genre = "mizrachit" };
            //gdb.Insert(myGenre);
            //int x = gdb.SaveChanges();
            //Console.WriteLine($"{x} rows inserted");

            //GenreTblDB gdb = new();
            //GenreTblList genreTbls = gdb.SelectAll();

            //GenreTbl myGenre = genreTbls
            //    .FirstOrDefault(p => p.Id == 2);

            //if (myGenre != null)
            //{
            //    gdb.Delete(myGenre);
            //    int x = gdb.SaveChanges();

            //    Console.WriteLine($"{x} rows were deleted");
            //}
            //else
            //{
            //    Console.WriteLine("Genre not found");
            //}




            //ChordEventTblDB db = new(); //// UPDATE AND SHOW AND INSERT DELETE
            //ChordEventTblList personTbls = db.SelectAll();
            //foreach (ChordEventTbl p in personTbls)
            //{
            //    Console.WriteLine(p.Songid);
            //}
            //ChordEventTbl personToUpdate = personTbls[0];
            //// Get the SongTbl object whose ID is 1
            //personToUpdate.Songid = SongTblDB.SelectById(2);
            //db.Update(personToUpdate);
            //int x = db.SaveChanges();
            //Console.WriteLine($"{x} rows were updated");

            //ChordEventTblDB cedb = new();
            //ChordEventTbl mychordevent = new ChordEventTbl() { Songid = new SongTbl() { Id = 1 }, Chord = "G", Timeseconds = 12 };
            //cedb.Insert(mychordevent);
            //int x = cedb.SaveChanges();
            //Console.WriteLine(x);
            //ChordEventTblDB cedb = new();
            //ChordEventTblList chordEventTbls = cedb.SelectAll();

            //ChordEventTbl myChordEvent = chordEventTbls
            //    .FirstOrDefault(p => p.Id == 2);

            //if (myChordEvent != null)
            //{
            //    cedb.Delete(myChordEvent);
            //    int x = cedb.SaveChanges();

            //    Console.WriteLine($"{x} rows were deleted");
            //}
            //else
            //{
            //    Console.WriteLine("Chord event not found");
            //}



            //ArtistTblDB db = new ArtistTblDB(); ////UPDATE AND SHOW AND INSERT DELETE
            //ArtistTblList aTbl = db.SelectAll();
            //foreach (ArtistTbl a in aTbl)
            //{
            //    Console.WriteLine(a.Genre.Genre);
            //}
            //ArtistTbl artist = aTbl[0];
            //artist.Genre = genereTbls[3];
            //db.Update(artist);
            //int y = db.SaveChanges();
            //Console.WriteLine($"{y} rows were updated");

            //ArtistTblDB aedb = new();
            //ArtistTbl myartist = new ArtistTbl()
            //{
            //    Artistname = "The Weeknd",
            //    Genre = new GenreTbl() { Id = 2 }
            //};
            //aedb.Insert(myartist);
            //int x = aedb.SaveChanges();
            //Console.WriteLine(x);
            //ArtistTblDB aedb = new();
            //ArtistTblList artistTbls = aedb.SelectAll();

            //ArtistTbl myArtist = artistTbls
            //    .FirstOrDefault(p => p.Id == 1);

            //if (myArtist != null)
            //{
            //    aedb.Delete(myArtist);
            //    int x = aedb.SaveChanges();

            //    Console.WriteLine($"{x} rows were deleted");
            //}
            //else
            //{
            //    Console.WriteLine("Artist not found");
            //}



            //SongTblDB sd = new SongTblDB();  ////SHOW AND UPDATE! INSERT!!!! DELETE
            //SongTblList songTbls = sd.SelectAll();
            //foreach (SongTbl p in songTbls)
            //    Console.WriteLine(p.Capo);
            //SongTbl song = songTbls[0];
            //song.Genre = genereTbls[2];
            //sd.Update(song);
            //int z = sd.SaveChanges();
            //Console.WriteLine($"{z} rows were updated");

            //SongTblDB sedb = new();
            //SongTbl mysong = new SongTbl()
            //{
            //    Title = "Blinding Lights",
            //    Artist = new ArtistTbl() { Id = 3 },
            //    Likes = 100,
            //    Songkey = "F",
            //    Capo = 1,
            //    Addedby = new AdminTbl() { Id = 8 },
            //    Dateadded = new DateTime(2026, 10, 30),
            //    Genre = new GenreTbl() { Id = 1 }
            //};

            //sedb.Insert(mysong);
            //int x = sedb.SaveChanges();
            //Console.WriteLine(x);
            //SongTblDB sedb = new();
            //SongTblList songTbls = sedb.SelectAll();

            //SongTbl mySong = songTbls
            //    .FirstOrDefault(p => p.Id == 2);

            //if (mySong != null)
            //{
            //    sedb.Delete(mySong);
            //    int x = sedb.SaveChanges();

            //    Console.WriteLine($"{x} rows were deleted");
            //}
            //else
            //{
            //    Console.WriteLine("Song not found");
            //}

            //SongLineTblDB db6 = new(); ////SHOW AND UPDATE AND INSERT!!! DELETE
            //SongLineTblList df = db6.SelectAll();
            //foreach (SongLineTbl d in df)
            //{
            //    Console.WriteLine(d.Starttime);
            //}
            //SongLineTbl songline = df[0];

            //SongTblDB db = new();
            //SongTblList list = db.SelectAll();

            //songline.Songid = list[1];


            //db6.Update(songline);
            //int j = db6.SaveChanges();
            //Console.WriteLine($"{j} rows were updated");
            //SongLineTblDB sldb = new();

            //SongLineTbl mysongline = new SongLineTbl()
            //{
            //    Songid = new SongTbl() { Id = 1 },
            //    Linenumber = 1,
            //    Lyrics = "I'm blinded by the lights",
            //    Starttime = 12
            //};

            //sldb.Insert(mysongline);

            //int x = sldb.SaveChanges();

            //Console.WriteLine(x);
            //SongLineTblDB sldb = new();
            //SongLineTblList songLineTbls = sldb.SelectAll();

            //SongLineTbl mySongLine = songLineTbls
            //    .FirstOrDefault(p => p.Id == 1);

            //if (mySongLine != null)
            //{
            //    sldb.Delete(mySongLine);
            //    int x = sldb.SaveChanges();

            //    Console.WriteLine($"{x} rows were deleted");
            //}
            //else
            //{
            //    Console.WriteLine("Song line not found");
            //}


            //AdminTblDB d = new(); ////SHOW, NO NEED FOR UPDATE, OR DELETE 
            //AdminTblList dns = d.SelectAll();
            //foreach (AdminTbl a in dns)
            //{
            //    Console.WriteLine(a.Name);

            //}

            //-----------------------------------------------------------------------

            // Create all DB objects and lists

            PersonTblDB personDB = new();
            PersonTblList persons = personDB.SelectAll();

            GenreTblDB genreDB = new();
            GenreTblList genres = genreDB.SelectAll();

            ChordEventTblDB chordDB = new();
            ChordEventTblList chords = chordDB.SelectAll();

            ArtistTblDB artistDB = new();
            ArtistTblList artists = artistDB.SelectAll();

            SongTblDB songDB = new();
            SongTblList songs = songDB.SelectAll();

            SongLineTblDB songLineDB = new();
            SongLineTblList songLines = songLineDB.SelectAll();

            AdminTblDB adminDB = new();
            AdminTblList admins = adminDB.SelectAll();


            // ==========================================
            // PERSON
            // ==========================================

            ////INSERT
            //PersonTbl personInsert = new PersonTbl()
            //{
            //   Name = "JugHead",
            //   Email = "jughead@gmail.com",
            //   Passw = "2121212"
            //};
            //personDB.Insert(personInsert);
            //Console.WriteLine($"{personDB.SaveChanges()} rows were inserted");

            ////UPDATE
            //PersonTblList personsAfterInsert = personDB.SelectAll();
            //PersonTbl personUpdate = personsAfterInsert.First(p => p.Id == 2);
            //personUpdate.Name = "JugHead_UPDATED";
            //personDB.Update(personUpdate);
            //Console.WriteLine($"{personDB.SaveChanges()} rows were updated");

            ////DELETE
            //PersonTblList personsBeforeDelete = personDB.SelectAll();
            //PersonTbl personDelete = personsBeforeDelete.First(p => p.Id == 2);
            //personDB.Delete(personDelete);
            //Console.WriteLine($"{personDB.SaveChanges()} rows were deleted");


            // ==========================================
            // GENRE
            // ==========================================

            // //INSERT
            //GenreTbl genreInsert = new GenreTbl()
            //{
            //    Genre = "mizrachit"
            //};
            // genreDB.Insert(genreInsert);
            // Console.WriteLine($"{genreDB.SaveChanges()} rows were inserted");

            // //UPDATE
            //GenreTblList genresAfterInsert = genreDB.SelectAll();
            // GenreTbl genreUpdate = genresAfterInsert.First(g => g.Id == 1);
            // genreUpdate.Genre = "mizrachit_UPDATED";
            // genreDB.Update(genreUpdate);
            // Console.WriteLine($"{genreDB.SaveChanges()} rows were updated");

            //// DELETE
            //GenreTblList genresBeforeDelete = genreDB.SelectAll();
            // GenreTbl genreDelete = genresBeforeDelete.First(g => g.Id == 1);
            // genreDB.Delete(genreDelete);
            // Console.WriteLine($"{genreDB.SaveChanges()} rows were deleted");


            // ==========================================
            // CHORD EVENT
            // ==========================================

            //INSERT
            //ChordEventTbl chordInsert = new ChordEventTbl()
            //{
            //    Songid = songs[0],
            //    Chord = "G",
            //    Timeseconds = 12
            //};
            // chordDB.Insert(chordInsert);
            // Console.WriteLine($"{chordDB.SaveChanges()} rows were inserted");

            // //UPDATE
            //ChordEventTblList chordsAfterInsert = chordDB.SelectAll();
            // ChordEventTbl chordUpdate = chordsAfterInsert.First(c => c.Id == 2);
            // chordUpdate.Chord = "G7";
            // chordDB.Update(chordUpdate);
            // Console.WriteLine($"{chordDB.SaveChanges()} rows were updated");

            // //DELETE
            //ChordEventTblList chordsBeforeDelete = chordDB.SelectAll();
            // ChordEventTbl chordDelete = chordsBeforeDelete.First(c => c.Id == 2);
            // chordDB.Delete(chordDelete);
            // Console.WriteLine($"{chordDB.SaveChanges()} rows were deleted");


            // ==========================================
            // ARTIST
            // ==========================================

            // // INSERT
            // ArtistTbl artistInsert = new ArtistTbl()
            // {
            //     Artistname = "The Weeknd",
            //     Genre = genres[0]
            // };
            // artistDB.Insert(artistInsert);
            // Console.WriteLine($"{artistDB.SaveChanges()} rows were inserted");

            // //UPDATE
            //ArtistTblList artistsAfterInsert = artistDB.SelectAll();
            // ArtistTbl artistUpdate = artistsAfterInsert.First(a => a.Id == 1);
            // artistUpdate.Artistname = "The Weeknd UPDATED";
            // artistDB.Update(artistUpdate);
            // Console.WriteLine($"{artistDB.SaveChanges()} rows were updated");

            //// DELETE
            //ArtistTblList artistsBeforeDelete = artistDB.SelectAll();
            // ArtistTbl artistDelete = artistsBeforeDelete.First(a => a.Id == 1);
            // artistDB.Delete(artistDelete);
            // Console.WriteLine($"{artistDB.SaveChanges()} rows were deleted");


            // ==========================================
            // SONG
            // ==========================================

            // INSERT
            //SongTbl songInsert = new SongTbl()
            //{
            //    Title = "Blinding Lights",
            //    Artist = artists[0],
            //    Likes = 100,
            //    Songkey = "F",
            //    Capo = 1,
            //    Addedby = admins[0],
            //    Dateadded = new DateTime(2026, 10, 30),
            //    Genre = genres[0]
            //};
            // songDB.Insert(songInsert);
            // Console.WriteLine($"{songDB.SaveChanges()} rows were inserted");

            // //UPDATE
            //SongTblList songsAfterInsert = songDB.SelectAll();
            // SongTbl songUpdate = songsAfterInsert.First(s => s.Id == 2);
            // songUpdate.Title = "Blinding Lights UPDATED";
            // songDB.Update(songUpdate);
            // Console.WriteLine($"{songDB.SaveChanges()} rows were updated");

            //// DELETE
            //SongTblList songsBeforeDelete = songDB.SelectAll();
            // SongTbl songDelete = songsBeforeDelete.First(s => s.Id == 2);
            // songDB.Delete(songDelete);
            // Console.WriteLine($"{songDB.SaveChanges()} rows were deleted");


            // ==========================================
            // SONG LINE
            // ==========================================

            //INSERT
            //SongLineTbl songLineInsert = new SongLineTbl()
            //{
            //    Songid = songs[0],
            //    Linenumber = 1,
            //    Lyrics = "I'm blinded by the lights",
            //    Starttime = 12
            //};
            // songLineDB.Insert(songLineInsert);
            // Console.WriteLine($"{songLineDB.SaveChanges()} rows were inserted");

            //// UPDATE
            //SongLineTblList songLinesAfterInsert = songLineDB.SelectAll();
            // SongLineTbl songLineUpdate = songLinesAfterInsert.First(s => s.Id == 1);
            // songLineUpdate.Lyrics = "I'm blinded by the lights UPDATED";
            // songLineDB.Update(songLineUpdate);
            // Console.WriteLine($"{songLineDB.SaveChanges()} rows were updated");

            // //DELETE
            //SongLineTblList songLinesBeforeDelete = songLineDB.SelectAll();
            // SongLineTbl songLineDelete = songLinesBeforeDelete.First(s => s.Id == 1);
            // songLineDB.Delete(songLineDelete);
            // Console.WriteLine($"{songLineDB.SaveChanges()} rows were deleted");


            // ==========================================
            // ADMIN - SHOW ONLY
            // ==========================================

            foreach (AdminTbl admin in admins)
            {
                Console.WriteLine(admin.Name);
            }


        }
    }
}
