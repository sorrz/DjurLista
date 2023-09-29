using DjurLista.Models;

internal class App
{

    public List<Animal> petsList = new List<Animal>();

    public App()
    {
    }

    internal void Run()
    {

        // MENY?!
        Console.WriteLine("1. Skapa nytt husdjur");
        Console.WriteLine("2. Lista alla sparade husdjur");
        Console.WriteLine("3. Avsluta");

        var choice = Console.ReadLine();

        if (choice == "1") 
        {
            CreateNewPet();
        }
        if (choice == "2") 
        {
            ListPets();
        }
        if (choice == "3") 
        {
            Environment.Exit(0);
        }


    }

    private void ListPets()
    {
        foreach (var pet in petsList)
        {
            Console.WriteLine($"Name: {pet.Name} " +
                $"\n Color: {pet.Color} ");
        }
        Run();
    }

    private void CreateNewPet()
    {
        //  MATA IN VÄRDEN OCH SKAPA DJUR!
        Console.Write("Vilket namn?");
        var name = Console.ReadLine();

        Console.Write("Vilken Färg?");
        var color = Console.ReadLine();

        Console.Write("Vilket Vingspann?");
        var wingspan = Int32.Parse(Console.ReadLine());

        Console.Write("Vilket Id?");
        var id = Int32.Parse(Console.ReadLine());

        // Create an Animal, Type Should be a Class of Bird
        var newBird = new Bird(id, wingspan, name, color);

        //POPULERA LISTAN MED DJUR
        petsList.Add(newBird);

        Run();
    }
}


