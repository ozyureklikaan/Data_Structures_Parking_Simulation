using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresParkingSimulation
{
    public class LinkedList : LinkedListADT
    {
        public override void InsertFirst(object car)
        {
            Node tmpHead = new Node { Data = car };
            if (Head == null)
            {
                Head = tmpHead;
            }
            else
            {
                tmpHead.Next = Head;
                Head = tmpHead;
            }
            Size++;
        }

        public override void InsertLast(object car)
        {
            Node oldLast = Head;
            if (Head == null)
            {
                InsertFirst(car);
            }
            else
            {
                Node newLast = new Node { Data = car };
                while (oldLast != null)
                {
                    if (oldLast.Next != null)
                    {
                        oldLast = oldLast.Next;
                    }
                    else
                    {
                        break;
                    }
                }
                oldLast.Next = newLast;
                Size++;
            }
        }

        public override void InsertPos(int position, object car)
        {
            throw new NotImplementedException();
        }

        public override void DeleteFirst()
        {
            if (Head != null)
            {
                Node tempHeadNext = this.Head.Next;
                if (tempHeadNext == null)
                {
                    Head = null;
                }
                else
                {
                    Head = tempHeadNext;
                }
                Size--;
            }
        }

        public override void DeleteLast()
        {
            Node lastNode = Head;
            Node lastPrevNode = null;
            while (true)
            {
                if (lastNode.Next != null)
                {
                    lastPrevNode = lastNode;
                    lastNode = lastNode.Next;
                }
                else
                {
                    break;
                }
            }
            Size--;
            lastNode = null;

            if (lastPrevNode != null)
            {
                lastPrevNode.Next = null;
            }
            else
            {
                Head = null;
            }
        }

        public override void DeletePos(int position)
        {
            throw new NotImplementedException();
        }

        public override Node GetElement(int position)
        {
            Node retNode = null;
            Node tempNode = Head;
            int count = 0;
            while (tempNode != null)
            {
                if (count == position)
                {
                    retNode = tempNode;
                    break;
                }
                tempNode = tempNode.Next;
                count++;
            }
            return retNode;
        }

        public override string DisplayElements()
        {
            string strList = "" + Environment.NewLine + "     Cars on the 2nd floor :" + Environment.NewLine;
            Node item = Head;
            while (item != null)
            {
                strList += "" + " Number" + ((Car)item.Data).Number + " car --> Color" + ((Car)item.Data).Color + ", Available Floor : " + ((Car)item.Data).AvailableFloor + Environment.NewLine;
                item = item.Next;
            }
            return strList;
        }
    }
}
