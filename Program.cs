using System;
using System.Collections.Generic;
// using Humans;

namespace Humans
{
    class Program
    {
        public static void Main(string[] args)
        {
            Human h1 = new Human();
            Ninja n2 = new Ninja("Ausar", 9, 10);
            Ninja n3= new Ninja("Kyle", 8, 10);
            Wizard w4 = new Wizard("Ale", 7, 9);
            Samuri s5= new Samuri("Nina", 7, 9);


            // List<Ninja> Ninjas = new List<Ninja>();
            // Ninjas.Add(ninja1);
            // Ninjas.Add(ninja2);
            // Ninjas.Add(ninja3);
            // Ninjas.Add(ninja4);

            Console.WriteLine(n2.Attack(s5));
            Console.WriteLine("***********************");

            // n2.Display();
            // n3.Display();
            s5.Attack(w4);
            w4.Attack(s5);
            Console.WriteLine(s5.health);

            w4.Heal(s5);
            Console.WriteLine(s5.health);
            s5.Meditate();
            // s5.Display();
            
            n2.Steal(n3);
            // Console.WriteLine(n2.Steal(n3));

        }
    }
}
