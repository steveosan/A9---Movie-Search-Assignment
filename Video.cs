using System;
using CsvHelper;
using System.IO;
using System.Globalization;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using CsvHelper.Configuration;
using CsvHelper.Configuration.Attributes;

namespace Abstract_Project
{
    public class Video : Media
    {
        public override void Print()
        {
            System.Console.WriteLine();
            System.Console.WriteLine();
            System.Console.WriteLine("VIDEOS LIST");
            System.Console.WriteLine("----------");
            string file = "Video.csv";
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