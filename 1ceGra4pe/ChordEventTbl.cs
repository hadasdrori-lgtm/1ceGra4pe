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
        private int timeseconds;
        private SongTbl song;

        public string Chord { get => chord; set => chord = value; }
        public int Timeseconds { get => timeseconds; set => timeseconds = value; }
        public SongTbl Song { get => song; set => song = value; }
    }
}
