using MongoDB.Entities;
using System;
using System.Threading.Tasks;

namespace Braveior.MongoDB.FuzzyTextSearch
{
    class Program
    {
        static async Task Main(string[] args)
        {
            await DB.InitAsync("fuzzysearch", "192.168.0.9", 27017);

            await DB.Index<Person>().Key(p => p.Name, KeyType.Text).CreateAsync();

            await new[]
            {
                new Person { Name = "Jack Jonas" },
                new Person { Name = "Marcus Katerin Thompson" },
                new Person { Name = "Catherine Marcus" },
                new Person { Name = "Katheryne Markus" }
            }.SaveAsync();

            var people = await DB.Find<Person>()
               .Match(Search.Fuzzy, "Catheryn Marcus")
               .ExecuteAsync();

            var list = people.SortByRelevance("Catheryn Marcus", p => p.Name);


            foreach (var person in list)
            {
                Console.WriteLine(person.Name);
            }

            Console.Read();



        }
    }

    public class Person : Entity
    {
        public FuzzyString Name { get; set; }
    }
}
