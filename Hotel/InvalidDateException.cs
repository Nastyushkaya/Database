using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    [Serializable]
    public class InvalidDateException : Exception
    {
        public InvalidDateException()
            : base(String.Format("CHOOSE REAL DATE"))
        {
        }
    }
}
