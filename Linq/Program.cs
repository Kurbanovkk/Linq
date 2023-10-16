namespace Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var topItems = list.Top(30);
            Console.WriteLine(string.Join(", ", topItems));

            var people = new List<Person>
            {
                new Person { Name = "Амир", Age = 25 },
                new Person { Name = "Ахмад", Age = 30 },
                new Person { Name = "Алихан", Age = 40 },
                new Person { Name = "Абубакр", Age = 35 },
            };

            var topAgedPeople = people.Top(50, person => person.Age);
            foreach (var person in topAgedPeople)
            {
                Console.WriteLine($"{person.Name} ({person.Age} лет)");
            }
        }
    }
}