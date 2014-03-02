using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrintFirstTenOfASequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int plus = 0;
            int minus = -1;

            for (int i = 0; i < 5; i++)
            {
                Console.Write("{0}, ", plus += 2);
                Console.Write("{0}, ", minus += -2);
            }
        }
    }
}
