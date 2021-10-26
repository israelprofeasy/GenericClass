using System;
using System.Collections.Generic;
using System.Text;

namespace GenericClass
{
    class LinkedList<T>
    {
        //field declarations
        private Node<T> head;
        private int count;


        // creating constructor of LinkedList
        public LinkedList()
        {
            this.head = null;
            this.count = 0;
        }

        // creating an add method that adds to the tail of a LinkedList and returns its size
        public int Add(T value)
        {
            Node<T> data = new Node<T>(value);
            if (this.count == 0)
            {
                this.head = data;
            }
            else
            {
                Node<T> presentNode = this.head;
                for (int i = 0; i < this.count; i++)
                {
                    if (presentNode.Next == null)
                    {
                        presentNode.Next = data;
                    }
                    else
                    {
                        presentNode = presentNode.Next;
                    }

                }

            }
            this.count++;
            return this.count;

        }

        // creating a check item method that checks for an item in a linkedlist

        public bool Check(T item)
        {
            Node<T> _item = this.head; ;
            for (int i = 0; i < this.count; i++)
            {
                if (_item.Data.Equals(item))
                {
                    return true;
                }
                else
                {
                    _item = _item.Next;
                }
            }
            return false;
        }


        //creating a Remove method that Remove first occurence of an item and return true
        public bool Remove(T item)
        {
            Node<T> _item = new Node<T>(item);
            if (this.head.Data.ToString() == _item.Data.ToString())
            {
                this.head = this.head.Next;
                this.count--;
                return true;
            }
            else
            {
                if (Check(item))
                {
                    Node<T> presentNode = this.head;
                    for (int i = 0; i < this.count; i++)
                    {
                        if (presentNode.Next.Data.ToString() == _item.Data.ToString())
                        {
                            presentNode.Next = presentNode.Next.Next;
                            this.count--;
                            return true;

                        }
                        else
                        {
                            presentNode = presentNode.Next;
                        }

                    }

                }
                else
                {
                    return false;
                }
                return false;
            }



        }

        //creating index method that returns the index of an item in a linkedlist

        public int Index(T item)
        {
            Node<T> node = this.head;
            if (this.head.Data.ToString() == item.ToString())
            {
                return 0;
            }
            else
            {
                for (int i = 0; i < this.count; i++)
                {
                    if (node.Data.Equals(item))
                    {
                        return i;
                    }
                    node = node.Next;
                }
            }
            return -1;
        }
        //print function
        public void Display()
        {
            Node<T> counter = this.head;
            while (counter != null)
            {
                Console.WriteLine(counter.Data);
                counter = counter.Next;
            }
        }
    }
}
