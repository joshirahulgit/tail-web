using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace File_Writter
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int start = 0;
            string error = string.Empty;
            while (start < 100)
            {
                int exceptionValue = random.Next(1, 5);
                switch (exceptionValue)
                {
                    case 1:
                        error = (new ArgumentException()).Message;
                        break;
                    case 2:
                        error = (new NullReferenceException()).Message;
                        break;
                    case 3:
                        error = (new FileLoadException()).Message;
                        break;
                    case 4:
                        error = (new FileNotFoundException()).Message;
                        break;
                    case 5:
                        error = (new IndexOutOfRangeException()).Message;
                        break;
                    default:
                        break;
                }

                File.AppendAllText(@"C:\Users\rjoshi.QUICKLOOK\Desktop\test-tail.txt", error + Environment.NewLine);
                Thread.Sleep(1000);
            }
        }
    }
}
