using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1ceGra4pe;
using System.Data.OleDb;
using System.Data;


namespace ViewModel
{
    public class SongTblDB : BaseDB
    {

        public SongTblList SelectAll()
        {
            command.CommandText = $"SELECT * FROM SongTbl";
            SongTblList songLst = new SongTblList(base.Select());
            return songLst;

        }
        static private SongTblList list = new SongTblList();
        public static SongTbl SelectById(int id)
        {
            SongTblDB songTbl = new SongTblDB();
            list = songTbl.SelectAll();
            SongTbl g = list.Find(item => item.Id == id);
            return g;

        }
        protected override BaseEntity NewEntity()
        {
            return new SongTbl();
        }
        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            SongTbl c = entity as SongTbl;

            c.Title = reader["Title"].ToString();
            c.Artist = ArtistTblDB.SelectById((int)reader["Artist"]);
            c.Likes = (int)reader["Likes"];
            c.Songkey = reader["SongKey"].ToString();
            c.Addedby = PersonTblDB.SelectById((int)reader["CreatedBy"]);
            c.Capo = (int)reader["Capo"];
            c.Dateadded = (DateTime)(reader["DateAdded"]);
            c.Genre= GenreTblDB.SelectById((int)reader["Genre"]);

            base.CreateModel(entity);
            return entity;
        }

    }
}
