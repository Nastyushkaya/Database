using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class ClassRoom
    {
        public int ID { get; set; }
        public string RoomClass { get; set; }
        public double Money { get; set; }
        public override string ToString()      //type string written in combobox
        {
            return RoomClass + "  $" + Money;
        }

    }
}
