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
    public class ShowInfo
    {
        public int ShowId {get; set;}
        public string Title {get; set;}
        public int Season {get; set;}
        public int Episode {get; set;}
        public string Writer {get; set;}

    }
}