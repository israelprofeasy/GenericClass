using System;
using System.Collections.Generic;
using System.Text;

namespace GenericClass
{
    class Stack<T>
    {

        // field declarations
        Node<T> head;
        private int count;


        //creating a construct of generic class stack
        public Stack()
        {
            this.head = null;
            this.count = 0;
        }

        // check if a stack list is empty - IsEmpty method
        public bool IsEmpty()
        {
            return count == 0;
        }

        //count the number of items in a stack list - size method
        public int Size()
        {
            return this.count;
        }


        // add items to the tail of a stack list
        public void Push(T item)
        {
            Node<T> _item = new Node<T>(item);
            _item.Next = head;
            this.head = _item;
            count++;
        }

        // remove the last item in a stack list and returns the item - pop method
        public T Pop()
        {
            if (count == 0)
            {
                throw new Exception("No item Present");
            }
            else
            {
                Node<T> _item = this.head;
                this.head = this.head.Next;
                this.count--;
                return _item.Data;

            }
        }


        //check for the last item added to a stack list and returns it - peek method
        public T Peek()
        {
            return this.head.Data;
        }
    }
}
