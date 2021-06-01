using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public interface ITable<T>
    {
        bool Add(T data);
        bool Delete(int data);
        T Read(int data);
        List<T> ReadAll();
    }
}
