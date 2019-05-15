using System;
using System.Collections.Generic;


namespace Humans {

    class Wizard:Human
    {

        
        public Wizard(string name, int dex, int strength)
        {
            Name = name;
            health = 50;
            Intelligence = 25;
            Dexterity = dex;
            Strength = strength;
        }

        
    public override int Attack(Human target)
    {
        int Damage = Dexterity * 5;

        target.health -= Damage;
        Console.WriteLine($"{Name} attacked {target.Name} for {Damage} damage!");
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

    public int Heal(Human target)
        {
            target.health = Intelligence * 10;
            Console.WriteLine($"The Wizard healed the Samuri by giving him or her {target.health} points");
            return target.health;
        }
    }


}