using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMegaCoolQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            MySuperQueue<int> q = new MySuperQueue<int>();
            //Console.WriteLine("Count = {0}", q.Count);
            //Console.WriteLine("FirstElement = {0}", q.FirstElement());
            //Console.WriteLine("LastElement = {0}", q.LastElement());

            q.Enqueue(1);
            q.Enqueue(2);
            q.Enqueue(3);
            Console.WriteLine("Count = {0}", q.Count);
            Console.WriteLine("FirstElement = {0}", q.FirstElement());
            Console.WriteLine("LastElement = {0}", q.LastElement());

            var deleted = q.Dequeue();
            Console.WriteLine("deleted: {0}", deleted.Data);
            Console.WriteLine("Count = {0}", q.Count);
            Console.WriteLine("FirstElement = {0}", q.FirstElement());

            Console.WriteLine("STACK");

            SexyStack<int> s = new SexyStack<int>();
            s.Push(1);
            s.Push(2);
            Console.WriteLine("Count = {0}", s.Count);
            Console.WriteLine("Peek = {0}", s.Peek());

            var popElement = s.Pop();
            Console.WriteLine("pop = {0}", popElement);
            Console.WriteLine("Count = {0}", s.Count);
            Console.WriteLine("Peek = {0}", s.Peek());


            Console.ReadLine();
        }
    }
}
