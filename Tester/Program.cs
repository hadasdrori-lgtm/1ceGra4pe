using _1ceGra4pe;
using System.Data;
using ViewModel;
namespace Tester
{
    internal class Program
    {
        static void Main(string[] args)
        {




            //PersonTblDB db = new();        //// UPDATE AND SHOW
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




            GenreTblDB db1 = new();  //// UPDATE AND SHOW
            GenreTblList genereTbls = db1.SelectAll();
            //foreach (GenreTbl p in genereTbls)
            //{
            //    Console.WriteLine(p.Genre);
            //}
            GenreTbl personToUpdate = genereTbls[0];
            personToUpdate.Genre = "hard hard metal music";
            db1.Update(personToUpdate);
            int x = db1.SaveChanges();
            Console.WriteLine($"{x} rows were updated");






            //ChordEventTblDB db = new(); //// UPDATE AND SHOW
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




            //ArtistTblDB db = new ArtistTblDB(); ////UPDATE AND SHOW
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





            //SongTblDB sd = new SongTblDB();  ////SHOW PROBLEM!
            //SongTblList songTbls = sd.SelectAll();
            //foreach (SongTbl p in songTbls)
            //    Console.WriteLine(p.Capo);
            //SongTbl song = songTbls[0];
            //song.Genre = genereTbls[2];
            //sd.Update(song);
            //int z = sd.SaveChanges();
            //Console.WriteLine($"{z} rows were updated");


            SongLineTblDB db6 = new(); ////SHOW PROBLEM!
            SongLineTblList df = db6.SelectAll();
            foreach (SongLineTbl d in df)
            {
                Console.WriteLine(d.Starttime);
            }
            SongLineTbl songline = df[0];

            SongTblDB db = new();
            SongTblList list = db.SelectAll();

            songline.Songid = list[1];


            db6.Update(songline);
            int j = db6.SaveChanges();
            Console.WriteLine($"{j} rows were updated");



            //AdminTblDB d = new(); ////SHOW, NO NEED FOR UPDATE,
            //AdminTblList dns = d.SelectAll();
            //foreach (AdminTbl a in dns)
            //{
            //    Console.WriteLine(a.Name);
            //}




        }
    }
}
