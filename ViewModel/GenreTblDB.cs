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
    public class GenreTblDB : BaseDB
    {
        public GenreTblList SelectAll()
        {
            command.CommandText = "SELECT * FROM GenreTbl";
            GenreTblList lst = new GenreTblList(base.Select());
            return lst;
        }
        static private GenreTblList list = new GenreTblList();
        public static GenreTbl SelectById(int id)
        {
            GenreTblDB genreTbl = new GenreTblDB();
            list = genreTbl.SelectAll();
            GenreTbl g = list.Find(item => item.Id == id);
            return g;

        }
        public override BaseEntity NewEntity()
        {
            return new GenreTbl();
        }

        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            GenreTbl c = entity as GenreTbl;
            c.Genre = reader["Genre"].ToString();
            base.CreateModel(entity);
            return entity;
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
         
            GenreTbl p = entity as GenreTbl;
            if (p != null)
            {
                string sqlStr = "UPDATE GenreTbl SET Genre=@pGenre WHERE ID=@id";
                cmd.CommandText = sqlStr;
                cmd.Parameters.Add(new OleDbParameter("@pGenre", p.Genre));
                cmd.Parameters.Add(new OleDbParameter("@id", p.Id));
            }
        }
    }
}

