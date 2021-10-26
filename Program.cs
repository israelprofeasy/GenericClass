using System;

namespace GenericClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> isreal = new Queue<int>();
            Stack<string> isreal2 = new Stack<string>();
            Stack<string> isreal3 = new Stack<string>();
            isreal.Enqueue(1);
            isreal.Enqueue(2);
            isreal.Enqueue(3);
            isreal.Enqueue(9);
            isreal.Enqueue(5);

            //isreal2.Add("zsjdhsd");
            Console.WriteLine(isreal.IsEmpty());
            Console.WriteLine(isreal.Size());
            Console.WriteLine(isreal.Dequeue());
            Console.WriteLine(isreal.Size());

        }
    }
}
