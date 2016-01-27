using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2
{
    class Card
    {
        public int Number { get; set; }
        public string Land { get; set; }

        public override string ToString()
        {
            return "Card Land: " + Land + " Number: " + Number ;
        }

    }
}
