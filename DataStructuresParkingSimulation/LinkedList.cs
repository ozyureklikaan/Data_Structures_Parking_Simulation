using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresParkingSimulation
{
    public class LinkedList : LinkedListADT
    {
        public override void InsertFirst(object araba)
        {
            Node tmpHead = new Node { Data = araba };
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

        public override void InsertLast(object araba)
        {
            Node oldLast = Head;
            if (Head == null)
            {
                InsertFirst(araba);
            }
            else
            {
                Node newLast = new Node { Data = araba };
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

        public override void InsertPos(int position, object araba)
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
            string strListe = "" + Environment.NewLine + "     2. Kattaki Arabalar :" + Environment.NewLine;
            Node item = Head;
            while (item != null)
            {
                strListe += "" + ((Araba)item.Data).Numara + " Numaralı Arabanın --> Rengi : " + ((Araba)item.Data).Renk + ", Bulunduğu Kat : " + ((Araba)item.Data).BulunduguKat + Environment.NewLine;
                item = item.Next;
            }
            return strListe;
        }
    }
}
