using ConsoleApp1.Models;
using System.Collections.Generic;
using System;
using ConsoleApp1.Service;
using System.Data.SqlClient;

class Program
{
    static void Main(string[] args)
    {
        /*Animal[] arrayAnimals = { new Dog("Garm", "Légendaire", "Chien", 1), new Dog("Rex", "Commun", "Chien", 2), new Dog("Snow", "Commun", "Chien", 3), new Griffin("Ziz", "Rare", "Griffin", 4), new Dog("Croc Blanc", "Légendaire", "Chien", 5), new Griffin("Erondir", "Rare", "Griffin", 6), new Eagles("Alexis", "Rare", "Eagle", 7), new Birds("Will", "Commun", "Bird", 8), new Dragon("Drakaris", "Légendaire", "Dragon", 9) };
        foreach (Animal animal in arrayAnimals)
        {
            
            Console.WriteLine("Nom : " + animal.Name + " | " + "Rareté" + animal.Rarity + " | " + "Id : " + animal.Id);
            Dragon dragon = animal as Dragon;
            if (dragon != null)
            {
                dragon.Fly();
            }
            Griffin griffin = animal as Griffin;
            if (griffin != null)
            {
                griffin.Fly();
            }
            Birds bird = animal as Birds;
            if (bird != null)
            {
                bird.Fly();
            }
            Eagles aigle = animal as Eagles;
            if (aigle != null)
            {
                aigle.Fly();
            }
            animal.Moove();
            animal.Sleep();
        }
        Console.WriteLine("");


        var rareAnimals = arrayAnimals.Where(animal => animal.Rarity == "Rare").ToList();
        foreach (Animal animal in rareAnimals)
        {
            Console.WriteLine("Nom : " + animal.Name + " | " + "Id : " + animal.Id);
            animal.Moove();
            animal.Sleep();
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
            animal.Moove();
            animal.Sleep();
        }*/


        BDD mybdd = new BDD();
        //mybdd.Read();
        bool stop = false;
        while (!stop)
        {
            Console.WriteLine("Quel est le type / espèce de votre animal ?");
            string specie = Console.ReadLine();
            Console.WriteLine("Quel est le nom de votre animal ?");
            string name = Console.ReadLine();
            Console.WriteLine("Quel est la rareté de votre animal ?");
            string rarity = Console.ReadLine();
            mybdd.Write(name, specie, rarity);
            Console.WriteLine("Voulez-vous continuer ? Oui : o / Non : n");
            string anwser = Console.ReadLine();

            Type type  = Type.GetType("Animals.Models." + specie);
            object[] xx = { name, rarity, specie };
            Animal instance = (Animal)Activator.CreateInstance(type, xx);
            if (anwser == "n")
            {
                stop = true;
            }

        }
        mybdd.Read();






    }
}
