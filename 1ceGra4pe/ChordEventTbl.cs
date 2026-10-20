using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _1ceGra4pe
{
    public class ChordEventTbl:BaseEntity
    {
        private string chord;
        private double timeseconds;
        private SongTbl songid;

        public string Chord { get => chord; set => chord = value; }
        public double Timeseconds { get => timeseconds; set => timeseconds = value; }
        public SongTbl Songid { get => songid; set => songid = value; }
    }
}
