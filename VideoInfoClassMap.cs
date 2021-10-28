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
    public class VideoInfoClassMap: ClassMap<VideoInfo>
    {
        public VideoInfoClassMap()
        {
            Map(m => m.VideoId).Name("id");
            Map(m => m.Title).Name("title");
            Map(m => m.Length).Name("length");
            Map(m => m.Format).Name("format");
            Map(m => m.Region).Name("region");
        }
    }
}   