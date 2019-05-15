using System;
using System.Collections.Generic;


namespace Humans{

    class Samuri:Human
    {

        
        public Samuri(string name, int intel, int dex)
        {
            Name = name;
            health = 1000;
            Intelligence = intel;
            Dexterity = dex;
            Strength = 3;
        }

        public override int Attack(Human target)
        {
            if(target.health == 50)
        {
            target.health = 0;
        }
        else
        {
            target.health -= (5*this.Strength);
        }

        return target.health;
        }

        public int Meditate()
        {
            health = 1000;
            Console.WriteLine($"When {this.Name} meditates {this.Name} recieves {health} points");
            return health;
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
    }






}