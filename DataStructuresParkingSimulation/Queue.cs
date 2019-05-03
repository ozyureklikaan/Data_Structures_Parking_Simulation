using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresParkingSimulation
{
    public class Queue : IQueue
    {
        private object[] Kuyruk;
        private int front = -1;
        private int rear = -1;
        private int size = 0;
        private int count = 0;

        public Queue(int arabaSayisi)
        {
            this.size = arabaSayisi;
            Kuyruk = new object[size];
        }

        public void Insert(object araba)
        {
            if ((count == size) || (rear == (size - 1)))
            {
                throw new Exception("Otopark Dolu");
            }
            if (front == -1)
            {
                front = 0;
            }
            Kuyruk[++rear] = araba;
            count++;
        }

        public object Remove()
        {
            if (this.IsEmpty())
            {
                throw new Exception("Queue is empty...");
            }
            object silinenAraba = Kuyruk[front];
            Kuyruk[front] = null;
            front++;
            count--;
            return silinenAraba;
        }

        public object[] Peek()
        {
            return Kuyruk;
        }

        public bool IsEmpty()
        {
            return (count == 0);
        }
    }
}
