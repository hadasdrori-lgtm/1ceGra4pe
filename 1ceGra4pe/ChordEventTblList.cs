using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1ceGra4pe
{
    public class ChordEventTblList: List<ChordEventTbl>
    {
        public ChordEventTblList() { }
        public ChordEventTblList(IEnumerable<ChordEventTbl> list) : base(list) { }
        public ChordEventTblList(IEnumerable<BaseEntity> list) : base(list.Cast<ChordEventTbl>().ToList()) { }

    }
}
