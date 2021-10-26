using System;
using System.Collections.Generic;
using System.Text;

namespace GenericClass
{
    class Node<T>
    {
        private T data;
        private Node<T> next;

        public Node(T value)
        {
            this.data = value;
            this.next = null;
        }
        public T Data
        {
            get
            {
                return this.data;
            }
            set
            {
                this.data = value;

            }
        }
        public Node<T> Next
        {
            get
            {
                return this.next;
            }
            set
            {
                this.next = value;
            }
        }
    }
}
