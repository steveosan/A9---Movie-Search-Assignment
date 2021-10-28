using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abstract_Project
{
    public class Show : Media
    {

        public override void Print()
        {
            System.Console.WriteLine();
            System.Console.WriteLine();
            System.Console.WriteLine("SHOWS LIST");
            System.Console.WriteLine("----------");
            string file = "Shows.csv";
            StreamReader sr = new StreamReader(file);
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                System.Console.WriteLine(line);
            }sr.Close();
            System.Console.WriteLine();
            System.Console.WriteLine();
        }
    }
}