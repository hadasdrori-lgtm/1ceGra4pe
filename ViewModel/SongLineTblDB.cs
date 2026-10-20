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
        protected override BaseEntity NewEntity()
        {
            return new SongLineTbl();
        }

        protected virtual BaseEntity CreateModel(BaseEntity entity)
        {
            SongLineTbl d = entity as SongLineTbl;
            d.Songid = SongTblDB.SelectById((int)reader["id"]);
            d.Linenumber = (int)reader["LineNumber"];
            d.Lyrics = reader["Lyrics"].ToString();
            d.Starttime = (double)reader["StartTime"];
            base.CreateModel(entity);
            return entity;
        }

    }
}
