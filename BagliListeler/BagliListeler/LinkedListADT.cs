using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BagliListeler
{
    public class LinkedListADT
    {
        public Node Head;
        public int Size = 0;
        public void InsertFirst(int value)
        {
            Node tmpHead = new Node { Data = value };
            if (Head == null)
                Head = tmpHead;
            else
            { 
                //En kritik nokta: tmpHead'in next'i //eski Head'i göstermeli
                tmpHead.Next = Head;
                //Yeni Head artık tmpHead oldu
                Head = tmpHead;
            }

            //Bağlı listedeki eleman sayısı bir arttı
            Size++;
        }

        public void InsertLast(int value)
        {
            Node newLast = new Node { Data = value };

            if (Head == null)
                Head = newLast;
            else
            {
                Node oldLast = Head;
                while (oldLast != null)
                {
                    if (oldLast.Next != null)
                        oldLast = oldLast.Next;
                    else
                        break;
                }
                oldLast.Next = newLast;
            }
            Size++;
        }
        public void InsertPos(int position, int value)
        {
            if (position >= Size)
                return;

            Node newNode = new Node { Data = value };

            if (Head == null)
                Head = newNode;
            else
            {
                Node posNode = Head;
                int i  = 0;
                while (posNode != null)
                {
                    if (i == position)
                        break;

                    if (posNode.Next != null)
                    {
                        posNode = posNode.Next;
                        i++;
                    }
                }

                Node tmpNext = posNode.Next;
                posNode.Next = newNode;
                newNode.Next = tmpNext;
            }
            Size++;
        }
        public void DeleteFirst()
        {
            if (Head == null)
                return;

            Node tmpHeadNext = Head.Next;
            
            if (tmpHeadNext == null)
            {
                Head = null;
            }
            else
            {
                Head = tmpHeadNext;
            }

            Size--;
        }
        public void DeleteLast()
        {
            Node lastPrevNode = new Node();
            Node lastNode = Head;

            while (lastNode != null)
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
            lastPrevNode.Next = null;
            lastNode = null;
            Size--;
        }
        public void DeletePos(int position)
        {
            if (position >= Size)
                return;

            Node posNode = Head;
            Node lastPrevNode = new Node();
            int i = 0;

            while (posNode != null)
            {
                if (i == position)
                    break;

                if (posNode.Next != null)
                {
                    lastPrevNode = posNode;
                    posNode = posNode.Next;
                    i++;
                }


            }
            lastPrevNode.Next = posNode.Next;
            posNode = null;
            Size--;
        }

        public  Node GetElement(int position)
        {
            Node posNode = Head;

            if (position >= Size)
                return null;

            int i = 0;
            while (posNode != null)
            {
                if (i == position)
                    break;

                if (posNode.Next != null)
                {
                    posNode = posNode.Next;
                    i++;
                }
            }
            return posNode;
        }
        public string DisplayElements()
        {
            if (Head == null)
                return "Empty List";

            string values = "";
            Node tmpNode = Head;

            while (tmpNode != null)
            {
                if (tmpNode.Next != null)
                {
                    values += tmpNode.Data.ToString() + "->";
                    tmpNode = tmpNode.Next;
                }
                else
                {
                    values += tmpNode.Data.ToString() + "->";
                    break;
                }
            }
            return values.Substring(0, values.Length - 2);
        }
    }
    public class Node
    {
        public int Data;
        public Node Next;
    }
}
