using System.Collections;

namespace Lesson36_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<Person> list = new List<Person>();
            //list.Add(new Person { Name = "Gor", Age = 53 });
            //list.Add(new Person { Name = "Arthur", Age = 56 });
            //list.Add(new Person { Name = "Ani", Age = 30 });
            //foreach (var l in list)
            //{
            //    Console.WriteLine(l.Name);
            //}

            //Dictionary<string, string> dict = new Dictionary<string, string>();
            //dict.Add("1", "one");
            //dict.Add("2", "two");
            //dict.Add("3", "threre");
            //if (dict.ContainsKey("1")) { }

            //Stack<string> strings = new Stack<string>();
            //string[] arr = new string[2];
            //arr[0] = "aaa";
            //arr[1] = "bbb";
            //strings.Push(arr[0]);
            //strings.Push(arr[1]);


            Hashtable filmGenre = new Hashtable();
            filmGenre.Add("Namus", "Melodram");
            filmGenre.Add("Pepo", "Tragicomedy");
            filmGenre.Add("ShorShorshor", "Comedy");

            Hashtable filmCost = new Hashtable();
            filmCost.Add("Namus", 100);
            filmCost.Add("Pepo", 150);
            filmCost.Add("ShorShorshor", null);

            foreach (DictionaryEntry item in filmGenre)
            {
                Console.Write($"FilmName: {item.Key}, ");
                Console.Write($"FilmGenre: {item.Value}, ");
                if (filmCost.ContainsKey(item.Key))
                {
                    Console.WriteLine(filmCost[item.Key] == null ? "Free" : filmCost[item.Key]);
                }
            }
        }


    }

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}