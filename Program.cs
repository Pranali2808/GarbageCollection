using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarbageCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long nem1 = GC.GetTotalMemory(false);
            {
                int[] values = new int[50000];//array of size
                values = null;
            }
            long nem2 = GC.GetTotalMemory(false);
            {
                GC.Collect();
            }
            long nem3 = GC.GetTotalMemory(false);
            {
                Console.WriteLine(nem1);
                Console.WriteLine(nem2);
                Console.WriteLine(nem3);
            }
            Console.WriteLine("##########");

            long bytes1 = GC.GetTotalMemory(false);//calculate memory in bytes

            byte[] memory = new byte[1000 * 1000 * 10];//add ten million bytes
            memory[0] = 1;

            long bytes2 = GC.GetTotalMemory(false);
            long bytes3 = GC.GetTotalMemory(true);

            Console.WriteLine(bytes1);
            Console.WriteLine(bytes2);
            Console.WriteLine(bytes2 - bytes1);//diff between intial and added memory
            Console.WriteLine(bytes3);
            Console.WriteLine(bytes3 - bytes2);//memory after gc
            Console.ReadLine();
        }
    }
}
    

