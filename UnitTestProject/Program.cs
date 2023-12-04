namespace UnitTestProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintAvailablePets();

            PetTest pt = new PetTest();
            _ = pt.GetAvailablePets_ShouldHaveSuccessStatusCode();
            _ = pt.GetAvailablePets_ShouldHaveSuccessStatusCodeAndValidJsonResponse();
        }

        private static void PrintAvailablePets()
        {
            var pets = PetstoreAPI.Program.GetAvailablePets().Result;

            if (pets != null)
            {
                var gPets = pets.GroupBy(pt => pt.category.name);

                foreach (var grp in gPets.OrderBy(g => g.Key))
                {
                    Console.WriteLine($"Category: {grp.Key}");

                    foreach (var pet in grp.OrderByDescending(pt => pt.name))
                    {
                        Console.WriteLine($"  Pet Name: {pet.name}");
                    }
                }
            }
            else
            {
                Console.WriteLine("Pet(s) not available!");
            }
        }
    }
}