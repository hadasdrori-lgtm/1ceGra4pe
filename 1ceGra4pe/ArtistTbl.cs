using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1ceGra4pe
{
    public class ArtistTbl:BaseEntity
    {
        private string artistname;
        private string genre;

        public string Artistname { get => artistname; set => artistname = value; }
        public string Genre { get => genre; set => genre = value; }

        public ArtistTblList SelectAll()
        {
            throw new NotImplementedException();
        }
    }
}
