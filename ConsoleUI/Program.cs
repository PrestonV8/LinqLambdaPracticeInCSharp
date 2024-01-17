namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            LinqTests();

            Console.ReadLine();
        }

        private static void LinqTests()
        {
            var members = SampleData.GetMemberData();

            var something = (from m in members
                             select m); // SQL command in expression form
            foreach (var member in members)
            {
                Console.Write($"{member.Name} [{member.Level}]");
                GetGames(member.Games);
                Console.WriteLine();
            }

            Console.WriteLine("===");
        }

        private static void GetGames(List<string> games)
        {
            Console.Write(" Games: ");
            foreach (var game in games)
            {
                Console.Write($"{game}, ");
            }
        }
    }
}