using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresParkingSimulation
{
    public class Queue : IQueue
    {
        private object[] queue;
        private int front = -1;
        private int rear = -1;
        private int size = 0;
        private int count = 0;

        public Queue(int theNumberOfCars)
        {
            this.size = theNumberOfCars;
            queue = new object[size];
        }

        public void Insert(object car)
        {
            if ((count == size) || (rear == (size - 1)))
            {
                throw new Exception("Parking full");
            }
            if (front == -1)
            {
                front = 0;
            }
            queue[++rear] = car;
            count++;
        }

        public object Remove()
        {
            if (this.IsEmpty())
            {
                throw new Exception("Queue is empty...");
            }
            object deletedCar = queue[front];
            queue[front] = null;
            front++;
            count--;
            return deletedCar;
        }

        public object[] Peek()
        {
            return queue;
        }

        public bool IsEmpty()
        {
            return (count == 0);
        }
    }
}
