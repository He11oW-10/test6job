using System;

namespace test6job
{
    class Program
    {
        static void Main(string[] args)
        {
            int i=1;
            do
            {
                Console.WriteLine();
                Console.WriteLine("Version: {0}", Environment.Version.ToString());
            }while (i>0);
        }
    }
}