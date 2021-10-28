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
    public class MediaSearch : Media
    {
        public override void Print()
        {

                string sortChoiceMovieTitle;

                using (var streamReader = new StreamReader("Movie.csv"))
                {
                    using (var csvReader = new CsvReader(streamReader, CultureInfo.InvariantCulture))
                    {
                        csvReader.Context.RegisterClassMap<MovieInfoClassMap>();
                        var records = csvReader.GetRecords<MovieInfo>().ToList();
                        {
                                System.Console.WriteLine("Please enter the Media Title ONLY and press enter to continue.");
                                sortChoiceMovieTitle = Console.ReadLine();
                                int count = 1;
                                System.Console.WriteLine("\n");
                                foreach (var record in records)
                                {
                                    
                                    if (record.Title.ToUpper().Contains(sortChoiceMovieTitle.ToUpper()))
                                    {

                                        System.Console.WriteLine(count + ")" +record.MovieId + " " + record.Title + " " + record.Genres);
                                        count++; 
                                    }
                                   
                                } 
                                int i = count -1;
                                System.Console.WriteLine("\n######## There were " + i + " results in the Movie DataBase ######## \n");  
                        }   
                    }
                }
                using (var streamReader = new StreamReader("Shows.csv"))
                {
                    using (var csvReader = new CsvReader(streamReader, CultureInfo.InvariantCulture))
                    {
                        csvReader.Context.RegisterClassMap<ShowInfoClassMap>();
                        var records = csvReader.GetRecords<ShowInfo>().ToList();
                        {
                                int count = 1;
                                System.Console.WriteLine("\n");
                                foreach (var record in records)
                                {
                                    
                                    if (record.Title.ToUpper().Contains(sortChoiceMovieTitle.ToUpper()))
                                    {

                                        System.Console.WriteLine(count + ")" +record.ShowId + " " + record.Title + " " + record.Season);
                                        count++; 
                                    }
                                   
                                } 
                                int i = count -1;
                                System.Console.WriteLine("\n######## There were " + i + " results in the Shows DataBase ######## \n");    
                        }   
                    }
                }
                using (var streamReader = new StreamReader("Video.csv"))
                {
                    using (var csvReader = new CsvReader(streamReader, CultureInfo.InvariantCulture))
                    {
                        csvReader.Context.RegisterClassMap<VideoInfoClassMap>();
                        var records = csvReader.GetRecords<VideoInfo>().ToList();
                        {
                                int count = 1;
                                System.Console.WriteLine("\n");
                                foreach (var record in records)
                                {
                                    
                                    if (record.Title.ToUpper().Contains(sortChoiceMovieTitle.ToUpper()))
                                    {

                                        System.Console.WriteLine(count + ")" +record.VideoId + " " + record.Title + " " + record.Length);
                                        count++; 
                                    }
                                   
                                } 
                                int i = count -1;
                                System.Console.WriteLine("\n######## There were " + i + " results in the Video DataBase ######## \n");  
                    }
                }
        }
    }
}
}