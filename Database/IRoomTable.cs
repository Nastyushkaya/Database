using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public interface IRoomTable : ITable<Room>
    {
        List<Room> GetAvailableRoomsByPeriodAndType(DateTime from, DateTime to, string type); 
    }
}
