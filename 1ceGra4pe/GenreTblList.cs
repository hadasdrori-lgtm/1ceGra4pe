using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1ceGra4pe
{
    public class GenreTblList: List<GenreTbl>
    {
        public GenreTblList() { }
        public GenreTblList(IEnumerable<GenreTbl> list) : base(list) { }
        public GenreTblList(IEnumerable<BaseEntity> list) : base(list.Cast<GenreTbl>().ToList()) { }
    }
}
