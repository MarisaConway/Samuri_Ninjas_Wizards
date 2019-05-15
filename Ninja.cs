using System;
using System.Collections.Generic;

namespace Humans{
class Ninja:Human
{

    public Ninja(string name, int strength, int intel)
    {
        Name = name;
        Strength = strength;
        Intelligence = intel;
        Dexterity = 75;
        health= 100;
    }


    public override int Attack(Human target)
    {
        Random rand = new Random();
        int chance = rand.Next(1,6);
        if(chance == 5)
        {
            target.health -=(5*this.Dexterity + 10);
        }
        else
        {
            target.health -= (5*this.Dexterity);
        }

        Console.WriteLine($"{Name} attacked {target.Name} and {target.Name} rolled a {chance}/5 for {target.Dexterity} damage!");
        return target.health;
    }

    public void Display()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Dexterity: {Dexterity}");
        Console.WriteLine($"Strength: {Strength}");
        Console.WriteLine($"Intelligence: {Intelligence}");
        Console.WriteLine($"Health: {health}");
        Console.WriteLine("--------------------------");
    }


    public int Steal(Human target)
    {
        target.health -= 5;
        health += target.health;
        Console.WriteLine($"Ninja stole {target.health} points away from {target.Name}");
        return target.health;

    }
    }   
}