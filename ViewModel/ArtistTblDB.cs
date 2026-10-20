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
    public class ArtistTblDB : BaseDB
    {
        public ArtistTblList SelectAll()
        {
            command.CommandText = "SELECT * FROM ArtistTbl";
            ArtistTblList lst = new ArtistTblList(base.Select());
            return lst;
        }
        static private ArtistTblList list = new ArtistTblList();
        public static ArtistTbl SelectById(int id)
        {
            ArtistTblDB artistTbl = new ArtistTblDB();
            list = artistTbl.SelectAll();
            ArtistTbl g = list.Find(item => item.Id == id);
            return g;

        }
        public override BaseEntity NewEntity()
        {
            return new ArtistTbl();
        }
        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            ArtistTbl a= entity as ArtistTbl;
            a.Artistname = reader["Artistname"].ToString();
            a.Genre = reader["Genre"].ToString();
            base.CreateModel(entity);
            return a;
        }

        protected override void CreateDeletedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            throw new NotImplementedException();
        }

        protected override void CreateInsertdSQL(BaseEntity entity, OleDbCommand cmd)
        {
            throw new NotImplementedException();
        }

        protected override void CreateUpdatedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            throw new NotImplementedException();
        }
    }
}
