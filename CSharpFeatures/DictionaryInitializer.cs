using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpFeatures
{
    public class Employees
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Email { get; set; }
    }

    public class DictionaryInitializer
    {

        public void Initializer()
        {
            Dictionary<int, Employees> dictEmployees = new Dictionary<int, Employees>()
            {
                {1, new Employees(){ Id=1, Name = "Saurabh", Email="Saurabh.singh@gmail.com"} },
                {2, new Employees(){ Id=2, Name = "Anik", Email="anik.singh@gmail.com"} }
            };

            foreach(KeyValuePair<int, Employees> item in dictEmployees)
            {
                Console.WriteLine($"Key={ item.Key} and the name of the value={item.Value.Name} and email of the value {item.Value.Name}");
            }
        }

    }
}
