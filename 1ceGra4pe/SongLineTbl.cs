using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1ceGra4pe
{
    public class SongLineTbl:BaseEntity
    {
        private int linenumber;
        private string lyrics;
        private int starttime;
        private SongTbl songid; 
        public int Linenumber { get => linenumber; set => linenumber = value; }
        public string Lyrics { get => lyrics; set => lyrics = value; }
        public int Starttime { get => starttime; set => starttime = value; }
        public SongTbl Songid { get => songid; set => songid = value; }
    }
}
