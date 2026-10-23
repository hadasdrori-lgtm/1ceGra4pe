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
        private GenreTbl genre;

        public string Artistname { get => artistname; set => artistname = value; }
        public GenreTbl Genre { get => genre; set => genre = value; }
    }
}
