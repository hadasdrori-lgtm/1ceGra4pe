using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1ceGra4pe;
using System.Data.OleDb;
using System.Data;
using System.Windows.Markup;


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
        public override BaseEntity NewEntity()
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

        protected override void CreateDeletedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            throw new NotImplementedException();
        }

        protected override void CreateInsertdSQL(BaseEntity entity, OleDbCommand cmd)
        {
            SongTbl p = entity as SongTbl;
            if (p != null)
            {
                string sqlStr = $"Insert INTO SongTbl (Title,Artist,Likes,SongKey,Capo,CreatedBy,DateAdded,Genre)"+ "VALUES (@pTitle,@pArtist,@pLikes,@pSongKey,@pCapo, @pCreatedBy,@pDateAdded, @pGenre)";
                cmd.CommandText = sqlStr;
                cmd.Parameters.Add(new OleDbParameter("@pTitle", p.Title));
                cmd.Parameters.Add(new OleDbParameter("@pArtist", p.Artist.Id));
                cmd.Parameters.Add(new OleDbParameter("@pLikes", p.Likes));
                cmd.Parameters.Add(new OleDbParameter("@pSongKey", p.Songkey));
                cmd.Parameters.Add(new OleDbParameter("@pCapo", p.Capo));
                cmd.Parameters.Add(new OleDbParameter("@pCreatedBy", p.Addedby.Id));
                cmd.Parameters.Add(new OleDbParameter("@pDateAdded", System.Data.OleDb.OleDbType.Date).Value = p.Dateadded.Date);
                cmd.Parameters.Add(new OleDbParameter("@pGenre", p.Genre.Id));
            }
        }

        protected override void CreateUpdatedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            SongTbl p = entity as SongTbl;
            if (p != null)
            {
                string sqlStr = $"UPDATE SongTbl SET Title=@pTitle, Artist=@pArtist, " +
                    $"Likes=@pLikes, SongKey=@pSongKey, Capo=@pCapo, CreatedBy=@pCreatedBy," +
                    $" DateAdded=#{p.Dateadded}#, Genre=@pGenre WHERE ID=@id";
                cmd.CommandText = sqlStr;
                cmd.Parameters.Add(new OleDbParameter("@pTitle", p.Title));
                cmd.Parameters.Add(new OleDbParameter("@pArtist",p.Artist.Id));
                cmd.Parameters.Add(new OleDbParameter("@pLikes", p.Likes));
                cmd.Parameters.Add(new OleDbParameter("@pSongKey",p.Songkey));
                cmd.Parameters.Add(new OleDbParameter("@pCapo", p.Capo));
                cmd.Parameters.Add(new OleDbParameter("@pCreatedBy", p.Addedby.Id));
                cmd.Parameters.Add(new OleDbParameter("@pDateAdded", System.Data.OleDb.OleDbType.Date).Value = p.Dateadded.Date);
                cmd.Parameters.Add(new OleDbParameter("@pGenre", p.Genre.Id));
                cmd.Parameters.Add(new OleDbParameter("@id", p.Id));
            }
        }
    }
}
