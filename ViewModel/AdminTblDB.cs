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

        public override BaseEntity NewEntity()
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
            //AdminTbl a= entity as AdminTbl;
            //if (a != null)
            //{ 
            //    string sqlStr= $"Update AdminTbl SET "
            //}
        }
    }
}
