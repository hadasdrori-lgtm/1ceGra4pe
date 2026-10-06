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
        protected override BaseEntity NewEntity()
        {
            return new SongTbl();
        }
        protected override Base CreateModel(Base entity)

        {
            //SongTbl c = entity as SongTbl;
            //c.Songkey = reader[""].ToString();
            //base.CreateModel(entity);
            //return entity;
        }

    }
}
