using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1ceGra4pe
{
    public class PersonTbl:BaseEntity
    {
        private string name;
        private string email;
        private string passw;

        public string Name { get => name; set => name = value; }
        public string Email { get => email; set => email = value; }
        public string Passw { get => passw; set => passw = value; }

    }
}
