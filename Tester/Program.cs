using _1ceGra4pe;
using System.Data;
using ViewModel;
namespace Tester
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //PersonTblDB db = new();
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




            //GenreTblDB db = new();
            //GenreTblList personTbls = db.SelectAll();
            //foreach (GenreTbl p in personTbls)
            //{
            //    Console.WriteLine(p.Genre);
            //}
            //GenreTbl personToUpdate = personTbls[0];
            //personToUpdate.Genre += "hard hard metal music";
            //db.Update(personToUpdate);
            //int x = db.SaveChanges();
            //Console.WriteLine($"{x} rows were updated");






            ChordEventTblDB db = new(); //PROBLEM
            ChordEventTblList personTbls = db.SelectAll();
            foreach (ChordEventTbl p in personTbls)
            {
                Console.WriteLine(p.Songid);
            }
            ChordEventTbl personToUpdate = personTbls[0];
            personToUpdate.Songid = 2;
            db.Update(personToUpdate);
            int x = db.SaveChanges();
            Console.WriteLine($"{x} rows were updated");




            //ArtistTblDB db = new ArtistTblDB();
            //ArtistTblList aTbl = db.SelectAll();
            //foreach (ArtistTbl a in aTbl)
            //{
            //    Console.WriteLine(a.Artistname);
            //}

            //SongTblDB sd = new();
            //SongTblList songTbls = sd.SelectAll();
            //foreach (SongTbl c in songTbls)
            //    Console.WriteLine(c.Capo);

            //SongLineTblDB db = new();
            //SongLineTblList df = db.SelectAll();
            //foreach (SongLineTbl d in df)
            //{ 
            //    Console.WriteLine(d.Starttime);
            //}

            //AdminTblDB d = new();
            //AdminTblList dns = d.SelectAll();
            //foreach (AdminTbl a in dns)
            //{
            //    Console.WriteLine(a.Name);
            //}




        }
    }
}
