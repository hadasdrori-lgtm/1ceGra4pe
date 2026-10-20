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
    public class AdminTblDB : BaseDB
    {
        public AdminTblList SelectAll()
        {
            command.CommandText = @"
            SELECT PersonTbl.*, AdminTbl.ID AS AdminID
            FROM PersonTbl
            INNER JOIN AdminTbl
            ON PersonTbl.ID = AdminTbl.ID";

            return new AdminTblList(base.Select());
        }

        protected override BaseEntity NewEntity()
        {
            return new AdminTbl();
        }

        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            AdminTbl a = entity as AdminTbl;

            a.Name = reader["Name"].ToString();
            a.Email = reader["Email"].ToString();
            a.Passw = reader["Passw"].ToString();

            base.CreateModel(entity);
            return entity;
        }
    }
}
