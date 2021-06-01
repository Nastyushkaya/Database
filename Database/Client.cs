using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class Client
    {
        public int ID { get; set; }
        public int RoomID { get; set; }
        public DateTime DataFrom { get; set; }  //day, month, year
        public DateTime DataTo { get; set; }    //day, month, year
    }
}
