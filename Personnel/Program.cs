using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personnel
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\projects\קורס .net\10.1\Personnel\NamesList.txt";
            FileReader reader = new FileReader();
            if (reader.Reader(path) == null)
            {
                Console.WriteLine("file path is incorrect");
            }
            else
            {
                foreach (string line in reader.Reader(path))
                {
                    Console.WriteLine(line);
                }
            }
            

            Console.ReadLine();
        }


    }
}
