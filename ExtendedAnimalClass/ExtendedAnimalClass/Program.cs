using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtendedAnimalClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter an animal name: ");
            string name = Console.ReadLine();
            Console.Write("Please enter this animal's sound: ");
            string sound = Console.ReadLine();

            Animal a1 = new Animal(name, sound);
            Console.WriteLine(a1.AnimalSays());        
            Console.ReadLine();
        }
    }

    class Animal
    {
        string name;
        string sound;

        public string Name { get { return name; } set { name = value; } }
        public string Sound { get { return sound; } set { sound = value; } }

        public string AnimalSays()
        {
            return $"The {Name} says {Sound}";
        }

        public Animal(string _name, string _sound)
        {
            Name = _name;
            Sound = _sound;
        }

    }

}
