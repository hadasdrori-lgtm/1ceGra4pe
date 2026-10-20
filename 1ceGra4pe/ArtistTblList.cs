using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1ceGra4pe
{
    public class ArtistTblList: List<ArtistTbl>
    {
        public ArtistTblList() { }
        public ArtistTblList(IEnumerable<ArtistTbl> list) : base(list) { }
        public ArtistTblList(IEnumerable<BaseEntity> list) : base(list.Cast<ArtistTbl>().ToList()) { }
    }
}
