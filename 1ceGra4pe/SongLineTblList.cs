using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1ceGra4pe
{
    public class SongLineTblList: List<SongLineTbl>
    {
        public SongLineTblList() { }
        public SongLineTblList(IEnumerable<SongLineTbl> list) : base(list) { }
        public SongLineTblList(IEnumerable<BaseEntity> list) : base(list.Cast < SongLineTbl>().ToList()) { }

    }
}
