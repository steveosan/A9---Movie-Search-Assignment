using System;
using CsvHelper;
using System.IO;
using System.Globalization;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using CsvHelper.Configuration;
using CsvHelper.Configuration.Attributes;
// using Newtonsoft.Json;

namespace Abstract_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice;
            string viewChoice;
            string addChoice;

            do
            {

                ///ASK USER if they want to read the file or wite to the file
                System.Console.WriteLine("##### Media Database #####");
                System.Console.WriteLine("1) Read specific media data type file?");
                System.Console.WriteLine("2) Add new file data?");
                System.Console.WriteLine("3) Run JSON repository");
                System.Console.WriteLine("4) Search ALL Media titles");
                choice = Console.ReadLine();

                if (choice == "1")
                {
                    System.Console.WriteLine("Which File would you like to view?");
                    System.Console.WriteLine("1) Movie");
                    System.Console.WriteLine("2) Video");
                    System.Console.WriteLine("3) Shows");
                    viewChoice = Console.ReadLine();
                    if (viewChoice == "1")
                    {
                        var m = new Movie();                       
                    }else if (viewChoice == "2")
                    {
                        var v = new Video();
                    }else if (viewChoice == "3")
                    {
                        var s = new Show();
                    }
                }else if (choice == "2")
                {
                    System.Console.WriteLine("Which File would you like ADD new data to?");
                    System.Console.WriteLine("1) Movie");
                    System.Console.WriteLine("2) Shows");
                    System.Console.WriteLine("3) Videos");
                    addChoice = Console.ReadLine();
                    if (addChoice == "1")
                    {
                            System.Console.WriteLine("Enter movie Id Number");
                            string NewMovieId = Console.ReadLine();

                            System.Console.WriteLine("Enter movie title");
                            string NewTitle = Console.ReadLine();

                            System.Console.WriteLine("Enter movie Genre");
                            string NewGenre = Console.ReadLine();

                            var records = new List<MovieInfo>
                            {
                            };
                            records = new List<MovieInfo>
                            {

                                new MovieInfo { MovieId = int.Parse(NewMovieId), Title = NewTitle , Genres = NewGenre},
                            };
                            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
                            {
                                // Don't write the header again.
                                HasHeaderRecord = false,
                            };
                            using (var stream = File.Open("Movies.csv", FileMode.Append))
                            using (var writer = new StreamWriter(stream))
                            using (var csv = new CsvWriter(writer, config))
                            {
                                csv.WriteRecords(records);
                            }
                            System.Console.WriteLine();
                            System.Console.WriteLine();
                            System.Console.WriteLine("Movie Information updated");
                            System.Console.WriteLine();
                            System.Console.WriteLine(); 
                                       
                    }else if (addChoice == "2")
                    {
                            System.Console.WriteLine("Enter show Id Number");
                            string NewShowId = Console.ReadLine();

                            System.Console.WriteLine("Enter show Title");
                            string NewTitle = Console.ReadLine();

                            System.Console.WriteLine("Enter show Season");
                            string NewSeason = Console.ReadLine();

                            System.Console.WriteLine("Enter show Episode");
                            string NewEpisode = Console.ReadLine();

                            System.Console.WriteLine("Enter show Writer");
                            string NewWriter = Console.ReadLine();

                            var records = new List<ShowInfo>
                            {
                            };
                            records = new List<ShowInfo>
                            {

                                new ShowInfo { ShowId = int.Parse(NewShowId), Title = NewTitle , Season = int.Parse(NewSeason) , Episode = int.Parse(NewEpisode) , Writer = NewWriter},
                            };
                            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
                            {
                                // Don't write the header again.
                                HasHeaderRecord = false,
                            };
                            using (var stream = File.Open("Shows.csv", FileMode.Append))
                            using (var writer = new StreamWriter(stream))
                            using (var csv = new CsvWriter(writer, config))
                            {
                                csv.WriteRecords(records);
                            }
                            System.Console.WriteLine();
                            System.Console.WriteLine();
                            System.Console.WriteLine("Show Information updated");
                            System.Console.WriteLine();
                            System.Console.WriteLine(); 
                    }else if (addChoice == "3")
                    {
                            System.Console.WriteLine("Enter video Id Number");
                            string NewVideoId = Console.ReadLine();

                            System.Console.WriteLine("Enter video title");
                            string NewTitle = Console.ReadLine();

                            System.Console.WriteLine("Enter video format");
                            string NewFormat = Console.ReadLine();

                            System.Console.WriteLine("Enter video length");
                            string NewLength = Console.ReadLine();

                            System.Console.WriteLine("Enter video regions");
                            string NewRegion = Console.ReadLine();

                            var records = new List<VideoInfo>
                            {
                            };
                            records = new List<VideoInfo>
                            {

                                new VideoInfo { VideoId = int.Parse(NewVideoId), Title = NewTitle , Format = NewFormat, Length = int.Parse(NewLength), Region = int.Parse(NewRegion)},
                            };
                            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
                            {
                                // Don't write the header again.
                                HasHeaderRecord = false,
                            };
                            using (var stream = File.Open("Video.csv", FileMode.Append))
                            using (var writer = new StreamWriter(stream))
                            using (var csv = new CsvWriter(writer, config))
                            {
                                csv.WriteRecords(records);
                            }
                            System.Console.WriteLine();
                            System.Console.WriteLine();
                            System.Console.WriteLine("Vidoe Information updated");
                            System.Console.WriteLine();
                            System.Console.WriteLine(); 
                    }
                }
            else if (choice == "3")
            {
                System.Console.WriteLine("XX Under Construction XX");
            }
            else if (choice == "4")
            {
                var s = new MediaSearch();;

            }
            }while (choice == "1" || choice == "2" || choice == "3" || choice == "4");

            System.Console.WriteLine("Thank you for using the media database!");


        }
    }
}
