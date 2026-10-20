using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1ceGra4pe;
using ViewModel;
using System.Data.OleDb;
using System.Data;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ChordEventTblDB cdb = new();
            CityList cList = cdb.SelectAll();
            foreach (City c in cList)
                Console.WriteLine(c.CityName);

        }
    }
}
