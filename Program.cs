using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MainProject_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fPath = "D:\\Second\\";
            Console.WriteLine("Enter file Name");
            string FName=Console.ReadLine();
            String Path = fPath + FName;

            if (File.Exists(Path))
            {
                string[] texts = File.ReadAllLines(Path);
                foreach (string text in texts)
                {
                  
                    Console.WriteLine(text);
                  
                }
             
            }
            else
            {
                Console.WriteLine("Students Data File Not Found!!!");
                Console.ReadKey();
            }


        }
    }
}
