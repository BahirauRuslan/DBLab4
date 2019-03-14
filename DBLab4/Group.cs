using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBLab4
{
    class Group
    {
        public int Id { get; set; }
        public int Number { get; set; }

        public override string ToString()
        {
            return Number.ToString();
        }
    }
}
