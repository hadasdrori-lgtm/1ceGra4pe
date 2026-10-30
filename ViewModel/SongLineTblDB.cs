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
    public class SongLineTblDB : BaseDB
    {
        public SongLineTblList SelectAll()
        {
            command.CommandText = $"SELECT * FROM SongLineTbl";
            SongLineTblList songLineLst = new SongLineTblList(base.Select());
            return songLineLst;

        }
        public override BaseEntity NewEntity()
        {
            return new SongLineTbl();
        }

        protected override  BaseEntity CreateModel(BaseEntity entity)
        {
            SongLineTbl d = entity as SongLineTbl;
            d.Songid = SongTblDB.SelectById((int)reader["id"]);
            d.Linenumber = (int)reader["LineNumber"];
            d.Lyrics = reader["Lyrics"].ToString();
            d.Starttime = (double)reader["StartTime"];
            base.CreateModel(entity);
            return entity;
        }

        protected override void CreateDeletedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            throw new NotImplementedException();
        }

        protected override void CreateInsertdSQL(BaseEntity entity, OleDbCommand cmd)
        {
            SongLineTbl p = entity as SongLineTbl;
            if (p != null)
            {
                string sqlStr = $"Insert INTO SongLineTbl(SongId,LineNumber,Lyrics,StartTime)" + "VALUES (@pSongId,@pLineNumber,@pLyrics,@pStartTime)";
                cmd.CommandText = sqlStr;
                cmd.Parameters.Add(new OleDbParameter("@pSongId", p.Songid.Id));
                cmd.Parameters.Add(new OleDbParameter("@pLineNumber", p.Linenumber));
                cmd.Parameters.Add(new OleDbParameter("@pLyrics", p.Lyrics));
                cmd.Parameters.Add(new OleDbParameter("@pStartTime", p.Starttime));
            }
        }

        protected override void CreateUpdatedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            SongLineTbl p = entity as SongLineTbl;
            if (p != null)
            {
                string sqlStr = $"UPDATE SongLineTbl SET SongId=@pSongId, LineNumber=@pLineNumber, Lyrics=@pLyrics, StartTime=@pStartTime  WHERE ID=@id";
                cmd.CommandText = sqlStr;
                cmd.Parameters.Add(new OleDbParameter("@pSongId", p.Songid.Id));
                cmd.Parameters.Add(new OleDbParameter("@pLineNumber", p.Linenumber));
                cmd.Parameters.Add(new OleDbParameter("@pLyrics", p.Lyrics));
                cmd.Parameters.Add(new OleDbParameter("@pStartTime", p.Starttime));
                cmd.Parameters.Add(new OleDbParameter("@id", p.Id));
            }
        }
    }
}
