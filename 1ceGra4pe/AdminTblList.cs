using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1ceGra4pe
{
    public class AdminTblList: List<AdminTbl>
    {
        public AdminTblList() { }
        public AdminTblList(IEnumerable<AdminTbl> list) : base(list) { }
        public AdminTblList(IEnumerable<BaseEntity> list) : base(list.Cast<AdminTbl>().ToList()) { }

    }
}
