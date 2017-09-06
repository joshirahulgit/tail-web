using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tail_Impl;

namespace Test_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Tail tail = new Tail(@"C:\Users\rjoshi.QUICKLOOK\Desktop\test-tail.txt");
            tail.Follow(item => {
                Console.WriteLine(item);
            });

            Console.ReadLine();
        }
    }
}
