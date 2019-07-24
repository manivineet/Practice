using System;
using System.Collections.Generic;
using System.Linq;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"/Users/vineetsingh/Desktop/Code/Practice/C#/Collections/src/Pop by Largest Final.csv";
            CsvReader reader = new CsvReader(filePath);

            List<Country> countries = reader.ReadAllCountries();

            Console.WriteLine($"There are: {countries.Count} countries");

            foreach (var country in countries
                        .Where (x => x.Name.StartsWith("B") )
                        .OrderBy(c => c.Name)
                        .Take(10))
            {
                Console.WriteLine(country.Name);
            }

        }
    }
}
