using System;
using System.Linq;
using System.Collections.Generic;

namespace Features
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int> square = x => x*x;
            Func<int, int, int> add = (x, y) => x+y;

            Console.WriteLine(square(add(3, 1)));


            IEnumerable<Employee> developers = new List<Employee>(){
                new Employee { Id = 1, Name = "Aineet"},
                new Employee { Id = 1, Name = "Viraj"}
            };

            Console.WriteLine($"There are a total of {developers.Count()} {nameof(developers)}");

            var query = developers.Where( e => e.Name.Length <= 5)
                                                .OrderBy (e => e.Name);

            foreach (var developer in query)
            {
                Console.WriteLine(value: developer.Name);

            }

            bool NameStartsWithS(Employee employee)
            {

                    return employee.Name.StartsWith("A");
            }



            // Console.WriteLine("Hello World!");
        }
    }
}
