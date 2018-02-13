using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tail_Impl;
using Tail_Spec;

namespace Test_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            ITail tail = new Tail(@"C:\rahul\src\Tail-Web\Tail-Web\Tail-Api\test-tail.txt");
            tail.Follow(item => {
                Console.WriteLine(item);
            });

            Console.ReadLine();
            tail.Unfollow();
        }
    }
}
