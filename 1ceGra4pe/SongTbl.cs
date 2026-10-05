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
        private string artist;
        private string songkey;
        private int capo;
        private int likes;
        private DateTime dateadded;
        private string addedby;

        public string Title { get => title; set => title = value; }
        public string Artist { get => artist; set => artist = value; }
        public string Songkey { get => songkey; set => songkey = value; }
        public int Capo { get => capo; set => capo = value; }
        public int Likes { get => likes; set => likes = value; }
        public DateTime Dateadded { get => dateadded; set => dateadded = value; }
        public string Addedby { get => addedby; set => addedby = value; }
    }
}
