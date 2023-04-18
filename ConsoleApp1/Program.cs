using ConsoleApp1.Models;

class Program
{
    static void Main(string[] args)
    {
        /*
        Dragon dragon = new Dragon("Drakaris", "légendaire");
        Console.WriteLine(dragon.Name);
        dragon.Moove();
        dragon.Sleep();
        Console.WriteLine("");
        Griffin griffin = new Griffin("Ziz", "rare");
        Console.WriteLine(griffin.Name);
        griffin.Moove();
        griffin.Sleep();
        Console.WriteLine("");
        */

        /*
        string[] chiens = { "Garm", "Croc Blanc", "Cerbère", "Orthos", "Snow" };
        IEnumerable<string> nosnow =
            from chien in chiens
            where chien != "Snow"
            select chien;
        foreach ( string chien in nosnow )
        {
            Console.WriteLine(chien);
        }
        */
        Animal[] arrayAnimals = { new Chien("Garm", "Légendaire"), new Chien("Rex", "Commun"), new Chien("Snow", "Commun"), new Griffin("Ziz", "Rare"), new Chien("Croc Blanc", "Légendaire"), new Griffin("Erondir", "Rare") };
        foreach (Animal animal in arrayAnimals)
        {
            Console.WriteLine("Nom : " + animal.Name + " | " + "Rareté" + animal.Rarity + " | " + "Id : " + animal.Id);
        }
        Console.WriteLine("");


        var rareAnimals = arrayAnimals.Where(animal => animal.Rarity == "Rare").ToList();
        foreach (Animal animal in rareAnimals)
        {
            Console.WriteLine("Nom : " + animal.Name + " | " + "Id : " + animal.Id);
        }
        Console.WriteLine("");
        IEnumerable<Animal> communAnimals =
            from animal in arrayAnimals
            where animal.Rarity == "Commun"
            orderby animal.Id descending
            select animal;
        foreach (Animal animal in communAnimals)
        {
            Console.WriteLine("Nom : " + animal.Name);
        }


    }
}
