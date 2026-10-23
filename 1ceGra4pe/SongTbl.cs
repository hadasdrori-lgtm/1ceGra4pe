using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1ceGra4pe
{
    public class SongTbl:BaseEntity
    {
        private string title;
        private ArtistTbl artist;
        private string songkey;
        private int capo;
        private int likes;
        private DateTime dateadded;
        private PersonTbl addedby;
        private GenreTbl genre;

        public string Title { get => title; set => title = value; }
        public ArtistTbl Artist { get => artist; set => artist = value; }
        public string Songkey { get => songkey; set => songkey = value; }
        public int Capo { get => capo; set => capo = value; }
        public int Likes { get => likes; set => likes = value; }
        public DateTime Dateadded { get => dateadded; set => dateadded = value; }
        public PersonTbl Addedby { get => addedby; set => addedby = value; }
        public GenreTbl Genre { get => genre; set => genre = value; }

       
    }
}
