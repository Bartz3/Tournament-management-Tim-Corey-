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
            return $" {ConfigurationManager.AppSettings["filePath"] }\\{fileName}";
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

    }
}
