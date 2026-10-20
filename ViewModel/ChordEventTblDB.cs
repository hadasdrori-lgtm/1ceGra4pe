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
    public class ChordEventTblDB : BaseDB
    {
        public ChordEventTblList SelectAll()
        {
            command.CommandText = "SELECT * FROM ChordEventTbl";
            ChordEventTblList lst = new ChordEventTblList(base.Select());
            return lst;
        }

        protected override BaseEntity NewEntity()
        {
            return new ChordEventTbl();
        }

        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            ChordEventTbl c = entity as ChordEventTbl;

            c.Songid = SongTblDB.SelectById((int)reader["SongId"]);
            c.Chord = reader["Chord"].ToString();
            c.Timeseconds = (double)reader["TimeSeconds"];

            base.CreateModel(entity);
            return entity;
        }
    }
}
