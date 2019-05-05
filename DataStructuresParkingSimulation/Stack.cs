using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresParkingSimulation
{
    public class Stack : IStack
    {
        private object[] stack;
        private int top = -1;

        public Stack(int stackCount)
        {
            this.stack = new object[stackCount];
        }

        public void Push(object item)
        {
            if (stack.Length == Top + 1)
            {
                throw new Exception("Stack Full (Overflow)");
            }
            stack[++Top] = item;
        }

        public object Pop()
        {
            if (IsEmpty())
            {
                throw new Exception("Stack Empty (Downflow)");
            }
            object deletedCar = stack[Top];
            stack[Top] = null;
            Top--;
            return deletedCar;
        }

        public object Peek()
        {
            return stack[Top];
        }

        public object[] PeekArray()
        {
            return stack;
        }

        public bool IsEmpty()
        {
            return Top == -1 ? true : false;
        }

        public int Top
        {
            get
            {
                return top;
            }
            set
            {
                top = value;
            }
        }
    }
}
