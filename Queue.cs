using System;
using System.Collections.Generic;
using System.Text;

namespace GenericClass
{
    class Queue<T>
    {
        //field declarations
        Node<T> head;
        Node<T> tail;
        private int count;


        //creating a contructor of the generic queue class
        public Queue()
        {
            this.head = null;
            this.tail = null;
            this.count = 0;
        }

        // check if a queue list is empty - IsEmpty method
        public bool IsEmpty()
        {
            return this.count == 0;
        }

        //count the number of items in a queue list - size method
        public int Size()
        {
            return this.count;
        }

        // creating an enqueue method that adds to the tail of a queue List
        public void Enqueue(T item)
        {
            Node<T> _item = new Node<T>(item);
            if (count == 0)
            {
                this.head = _item;
                this.tail = _item;
            }
            else
            {
                Node<T> headNode = this.head;
                Node<T> tailNode = this.head;
                for (int i = 0; i < this.count; i++)
                {
                    if (tailNode.Next == null)
                    {

                        this.tail = _item;
                    }
                    else
                    {
                        tailNode = tailNode.Next;
                    }
                }


            }
            this.count++;

        }
        //creating a dequeue method that removes first item  of a queue list and returns it
        public T Dequeue()
        {
            if (count == 0) throw new Exception("List is empty");
            Node<T> _item = this.head;
            this.head = this.head.Next;
            count--;
            return _item.Data;

        }
    }
}
