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
    public class PersonTblDB : BaseDB
    {
        public PersonTblList SelectAll()
        {
            command.CommandText = "SELECT * FROM PersonTbl";
            PersonTblList pList = new PersonTblList(base.Select());
            return pList;
        }
        static private PersonTblList list = new PersonTblList();
        public static PersonTbl SelectById(int id)
        {
            PersonTblDB personTbl = new PersonTblDB();
            list = personTbl.SelectAll();
            PersonTbl g = list.Find(item => item.Id == id);
            return g;

        }
        protected override BaseEntity NewEntity()
        {
            return new PersonTbl();
        }
        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            PersonTbl p = entity as PersonTbl;
            p.Name = reader["Name"].ToString();
            p.Email = reader["Email"].ToString();
            p.Passw = reader["Passw"].ToString();
            base.CreateModel(entity);
            return entity;
        }


    }
}
