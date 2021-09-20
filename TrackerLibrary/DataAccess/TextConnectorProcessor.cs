using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.IO;
using System.Linq;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess.TextHelpers
{

    /// <summary>
    /// Extention method (this string) that returns full file path to text file
    /// </summary>
    public static class TextConnectorProcessor
    {
        public static string FullFilePath(this string fileName) 
        {
            return $"{ConfigurationManager.AppSettings["filePath"] }\\{ fileName}";
        }
        /// <summary>
        /// Extention method that loads the text file
        /// </summary>
        public static List<string> LoadFile(this string file)
        {
            if (!File.Exists(file))
            {
                return new List<string>();
            }

            return File.ReadAllLines(file).ToList();
        }

        public static List<PrizeModel> ConvertToPrizeModels(this List<string> lines)
        {
            List<PrizeModel> output = new List<PrizeModel>();
            foreach (string line in lines)
            {
                string[] columns = line.Split(',');

                PrizeModel p = new PrizeModel();
                p.Id = int.Parse(columns[0]);
                p.PlaceNumber = int.Parse(columns[1]);
                p.PlaceName = columns[2];
                p.PrizeAmount = decimal.Parse(columns[3]);
                p.PrizePercentage = double.Parse(columns[4]);

                output.Add(p);
            }
            return output;
        }

        public static List<PersonModel> ConvertToPersonModels(this List<string> lines)
        {
            List<PersonModel> output = new List<PersonModel>();

            foreach (string line in lines)
            {
                string[] columns = line.Split(',');

                PersonModel p = new PersonModel();

               p.Id = int.Parse(columns[0]);
               p.FirstName =columns[1];
               p.LastName =columns[2];
               p.EmailAddress=columns[3];
               p.CellphoneNumber = columns[4];

                output.Add(p);
            }
            return output;
        }

        public static List<TeamModel> ConvertToTeamModels(this List<string> lines,string peopleFileName)
        {
            List<TeamModel> output = new List<TeamModel>();
            List<PersonModel> people = peopleFileName.FullFilePath().LoadFile().ConvertToPersonModels();

            foreach (string line in lines)
            {
                string[] columns = line.Split(',');

                TeamModel t = new TeamModel();
                t.Id = int.Parse(columns[0]);
                t.TeamName = columns[1];

                string[] personId = columns[2].Split('|');

                foreach (string id in personId)
                {
                    t.TeamMembers.Add(people.Where(x => x.Id == int.Parse(id)).First());
                    //finds the person object and add it to the TeamMembers list of object
                    //for each line in text file add the ID and team name and then loop through and add the team members based upon spliting coulmuns[2]
                }
                output.Add(t);
            }
            return output;
        }

        
        
        public static void SaveToPrizeFile(this List<PrizeModel> models, string fileName)
        {
            List<string> lines = new List<string>();

            foreach (PrizeModel p in models)
            {
                lines.Add($"{p.Id},{ p.PlaceNumber},{ p.PlaceName},{ p.PrizeAmount},{ p.PrizePercentage}");

            }
            File.WriteAllLines(fileName.FullFilePath(), lines);
        }

        public static void SaveToPeopleFile(this List<PersonModel> models, string fileName)
        {
            List<string> lines = new List<string>();

            foreach (PersonModel p in models)
            {
                lines.Add($"{p.Id},{p.FirstName},{p.LastName},{p.EmailAddress},{p.CellphoneNumber}");
            }
            File.WriteAllLines(fileName.FullFilePath(), lines);
        }

        public static void SaveToTeamFile(this List<TeamModel> models, string fileName)
        {
            List<string> lines = new List<string>();

            foreach (TeamModel tm in models)
            {
                lines.Add($"{tm.Id},{tm.TeamName},{ConvertPeopleListToString(tm.TeamMembers)}");
            }
            File.WriteAllLines(fileName.FullFilePath(), lines);

        }
        private static string ConvertPeopleListToString(List<PersonModel> people)
        {
            string output = "";

            if (people.Count == 0) return "";

            foreach (PersonModel pm in people)
            {       
                output += $"{pm.Id}|";
            }
            output = output.Substring(0, output.Length - 1);

            return output;    
        }
    }
}
