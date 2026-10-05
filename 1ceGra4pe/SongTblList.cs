using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1ceGra4pe
{
    public class SongTblList : List<SongTbl>
    {
        public SongTblList() { }
        public SongTblList(IEnumerable<SongTbl> list): base(list) { }
        public SongTblList(IEnumerable<BaseEntity> list) : base(list.Cast<SongTbl>().ToList()) { }


    }
}
