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
    public class Movie : Media
    {
        public override void Print()
        {
                string displayRecords;
                string sortChoice;
                string sortChoiceMovieId;
                string sortChoiceMovieTitle;
                string sortChoiceMovieGenres;

                using (var streamReader = new StreamReader("Movie.csv"))
                {
                    using (var csvReader = new CsvReader(streamReader, CultureInfo.InvariantCulture))
                    {
                        csvReader.Context.RegisterClassMap<MovieInfoClassMap>();
                        var records = csvReader.GetRecords<MovieInfo>().ToList();

                        System.Console.WriteLine("There are " + records.Count + " records. would you like to display them all? \nType 1 for yes" 
                            + " or 2 to sort");

                        displayRecords = Console.ReadLine();

                        if (displayRecords == "1")
                        {
                                foreach (var record in records)
                                    {
                                        System.Console.WriteLine(record.MovieId + " " + record.Title + " " + record.Genres);
                                        
                                    }System.Console.WriteLine();
                        }else if (displayRecords == "2")
                        {
                            System.Console.WriteLine("How would you like to sort the records?");
                            System.Console.WriteLine("#######################################");
                            System.Console.WriteLine(" 1) Sort by movie ID?");
                            System.Console.WriteLine(" 2) Sort by movie Title?");
                            System.Console.WriteLine(" 3) Sort by move Genre?");

                            sortChoice = Console.ReadLine();

                            if (sortChoice == "1")
                            {
                                System.Console.WriteLine("Please enter the Movie ID # and press enter to continue.");
                                sortChoiceMovieId = Console.ReadLine();
                                
                                foreach (var record in records)
                                {
                                    if (record.MovieId == int.Parse(sortChoiceMovieId))
                                    {

                                        System.Console.WriteLine(record.MovieId + " " + record.Title + " " + record.Genres);

                                    }

                                }
                            }else if (sortChoice == "2")
                            {
                                System.Console.WriteLine("Please enter the Movie Title and press enter to continue.");
                                sortChoiceMovieTitle = Console.ReadLine();
                                foreach (var record in records)
                                {
                                    if (record.Title.ToUpper().Contains(sortChoiceMovieTitle.ToUpper()))
                                    {
                                        System.Console.WriteLine(record.MovieId + " " + record.Title + " " + record.Genres);
                                    }
                                }                                    
                            }else if (sortChoice == "3")
                            {
                                System.Console.WriteLine("Please select Genre = Adventure|Action|Crime|Thriller|Animation|Children|Comedy|Fantasy|Drama|Romance|Sci-Fi.");
                                sortChoiceMovieGenres = Console.ReadLine();
                                foreach (var record in records)
                                {
                                    if (record.Genres.ToUpper().Contains(sortChoiceMovieGenres.ToUpper()))
                                    {
                                        System.Console.WriteLine(record.MovieId + " " + record.Title + " " + record.Genres);
                                    }
                            }   
                        }
                    }
                }
            }
        }
    }
}