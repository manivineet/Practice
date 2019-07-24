using System;
using System.Collections.Generic;
using System.IO;

namespace Collections
{

    public class CsvReader
    {
        private string filePath;

        public CsvReader(string filePath)
        {
            this.filePath = filePath;
        }

        public List<Country> ReadAllCountries()
        {
            var countries = new List<Country>();

            using(StreamReader sr = new StreamReader(filePath)) 
            {
                string csvLine;

                while((csvLine = sr.ReadLine()) != null)
                {
                    countries.Add(ReadCountryFromCsvLine(csvLine));
                }
            }   

            //inserting a special case 
            var liliput = new Country("Liliput", "unknown", "Somewhere", 2000000);

            var index = countries.FindIndex(x => x.Population <= liliput.Population);

            countries.Insert(index, liliput);

            return countries;
        }

        private Country ReadCountryFromCsvLine(string csvLine)
        {
            string[] parts = csvLine.Split(',');
			string name;
			string code;
			string region;
			string popText;
			switch (parts.Length)
			{
				case 4:
					name = parts[0];
					code = parts[1];
					region = parts[2];
					popText = parts[3];
					break;
				case 5:
					name = parts[0] + ", " + parts[1];
					name = name.Replace("\"", null).Trim();
					code = parts[2];
					region = parts[3];
					popText = parts[4];
					break;
				default:
					throw new Exception($"Can't parse country from csvLine: {csvLine}");
			}

			// TryParse leaves population=0 if can't parse
			int.TryParse(popText, out int population);
			return new Country(name, code, region, population);
        }
    }
}