using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class Room
    {
        public int ID { get; set; }
        public string NumberRoom { get; set; }
        public int RoomClassID { get; set; }
        public override string ToString()
        {
            return NumberRoom;     //type string in listbox
        }
    }
}
