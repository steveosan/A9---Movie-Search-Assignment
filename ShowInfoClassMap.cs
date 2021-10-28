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
    public class ShowInfoClassMap : ClassMap<ShowInfo>
    {
        public ShowInfoClassMap()
        {
            Map(m => m.ShowId).Name("id");
            Map(m => m.Title).Name("title");
            Map(m => m.Season).Name("season");
            Map(m => m.Episode).Name("episode");
            Map(m => m.Writer).Name("writers");
        }
    }
}