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

        public override BaseEntity NewEntity()
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

        protected override void CreateDeletedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            throw new NotImplementedException();
        }

        protected override void CreateInsertdSQL(BaseEntity entity, OleDbCommand cmd)
        {
            ChordEventTbl p= entity as ChordEventTbl;
            if (p != null)
            {
                string sqlStr = $"Insert INTO ChordEventTbl(SongId,Chord,TimeSeconds)" + "VALUES (@pSongId,@pChord,@pTimeSeconds)";
                cmd.CommandText = sqlStr;
                cmd.Parameters.Add(new OleDbParameter("@pSongId", p.Songid.Id));
                cmd.Parameters.Add(new OleDbParameter("@pChord", p.Chord));
                cmd.Parameters.Add(new OleDbParameter("@pTimeSeconds", p.Timeseconds));
            }
        }

        protected override void CreateUpdatedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            ChordEventTbl p = entity as ChordEventTbl;
            if (p != null)
            {
                string sqlStr = "UPDATE ChordEventTbl SET SongId=@pSongId, Chord=@pChord, TimeSeconds=@pTimeSeconds WHERE ID=@id";
                cmd.CommandText = sqlStr;
                cmd.Parameters.Add(new OleDbParameter("@pSongId", p.Songid.Id));
                cmd.Parameters.Add(new OleDbParameter("@pChord",p.Chord));
                cmd.Parameters.Add(new OleDbParameter("@pTimeSeconds", p.Timeseconds));
                cmd.Parameters.Add(new OleDbParameter("@id", p.Id));
            }
        }
    }
}
