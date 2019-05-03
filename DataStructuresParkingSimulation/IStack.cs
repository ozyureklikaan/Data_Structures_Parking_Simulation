using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresParkingSimulation
{
    public interface IStack
    {
        void Push(object item);
        object Pop();
        object Peek();
        object[] PeekArray();
        bool IsEmpty();
        int Top { get; set; }
    }
}
