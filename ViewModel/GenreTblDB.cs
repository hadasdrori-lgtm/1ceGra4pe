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
        protected override BaseEntity NewEntity()
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
    }
}

