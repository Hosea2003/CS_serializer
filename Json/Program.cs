using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Json
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Serializer
            //List<Person> list = new List<Person>()
            //{
            //    new Person(){Nom="Ranto",Prenom="Hossana",Age=19},
            //    new Person(){Nom="Rindra",Prenom="Hosea",Age=20}
            //};

            //string data = JsonConvert.SerializeObject(list);
            //Console.WriteLine(data);

            //Deserilize
            //Donnée JSon
            string data = File.ReadAllText(@"datajson.txt");


            //Type d'objet après la déserilize
            //Pour ce cas une liste de person
            List<Person> list = JsonConvert.DeserializeObject<List<Person>>(data);
            Console.WriteLine(list);
            Console.ReadKey();
        }
        class Person
        {
            public string Nom { get; set; }
            public string Prenom { get; set; }
            public int Age { get; set; }
        }
    }
}
