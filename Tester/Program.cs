using _1ceGra4pe;
using System.Data;
using ViewModel;
namespace Tester
{
    internal class Program
    {
        static void Main(string[] args)
        {




            //PersonTblDB db = new();        //// UPDATE AND SHOW AND INSERT
            //PersonTblList personTbls = db.SelectAll();
            //foreach (PersonTbl p in personTbls)
            //{
            //    Console.WriteLine(p.Name);
            //}
            //PersonTbl personToUpdate = personTbls[0];
            //personToUpdate.Name += "MUSTAAAAAARD";
            //db.Update(personToUpdate);
            //int x=db.SaveChanges();
            //Console.WriteLine($"{x} rows were updated");
            //PersonTblDB pdb=new ();
            //PersonTbl myPerson = new PersonTbl() { Name = "JugHead", Email = "jughead@gmail.com", Passw = "2121212" };
            //pdb.Insert(myPerson);
            //int x=pdb.SaveChanges();
            //Console.WriteLine($"{x} rows inserted");




            //GenreTblDB db1 = new();  //// UPDATE AND SHOW AND INSERT
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
            //GenreTbl myGenre=new GenreTbl() { Genre = "mizrachit"};
            //gdb.Insert(myGenre);
            //int x= gdb.SaveChanges();
            //Console.WriteLine($"{x} rows inserted");






            //ChordEventTblDB db = new(); //// UPDATE AND SHOW AND INSERT
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



            //ArtistTblDB db = new ArtistTblDB(); ////UPDATE AND SHOW AND INSERT
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



            //SongTblDB sd = new SongTblDB();  ////SHOW AND UPDATE! // problem with the insert.
            //SongTblList songTbls = sd.SelectAll();
            //foreach (SongTbl p in songTbls)
            //    Console.WriteLine(p.Capo);
            //SongTbl song = songTbls[0];
            //song.Genre = genereTbls[2];
            //sd.Update(song);
            //int z = sd.SaveChanges();
            //Console.WriteLine($"{z} rows were updated");

            SongTblDB sedb = new(); //PROBLEM.
            SongTbl mysong = new SongTbl()
            {
                Title = "Blinding Lights",
                Artist = new ArtistTbl() { Id = 2 },
                Likes = 100,
                Songkey = "F",
                Capo = 1,
                Addedby = new AdminTbl() { Id = 1 },
                Dateadded = new DateTime(2026, 10, 30),
                Genre = new GenreTbl() { Id = 1 }
            };

            sedb.Insert(mysong);
            int x = sedb.SaveChanges();
            Console.WriteLine(x);


            //SongLineTblDB db6 = new(); ////SHOW AND UPDATE AND INSERT!!!
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


            //AdminTblDB d = new(); ////SHOW, NO NEED FOR UPDATE,
            //AdminTblList dns = d.SelectAll();
            //foreach (AdminTbl a in dns)
            //{
            //    Console.WriteLine(a.Name);
            //}




        }
    }
}
