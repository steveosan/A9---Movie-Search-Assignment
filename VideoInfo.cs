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
    public class VideoInfo
    {
        public int VideoId {get; set;}
        public string Title {get; set;}
        public int Length {get; set;}
        public string Format {get; set;}
        public int Region {get; set;}

    }
}