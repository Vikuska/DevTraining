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
            q.Enqueu(1);
            q.Enqueu(2);
            q.Enqueu(3);
            Console.WriteLine("Size = {0}", q.Size);
            Console.WriteLine("FirstElement = {0}", q.FirstElement());
            Console.WriteLine("LastElement = {0}", q.LastElement());

            q.Dequeu();
            Console.WriteLine("Size = {0}", q.Size);
            Console.WriteLine("FirstElement = {0}", q.FirstElement());

            Console.ReadLine();
        }
    }
}
