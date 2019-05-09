using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal a1 = new Animal("Cat", "Tiger");
            Console.WriteLine($"Animal Type: {a1.Type}\nName: {a1.Name}\nId: {a1.Id}");
            Console.ReadLine();
            
        }
    }

    class Animal
    {
        string type;
        string name;
        int id;

        public string Type { get { return type; } set { type = value; } }
        public string Name { get { return name; } set { name = value; } }
        public int Id { get { return id; } set { id = value; } }

        // Method
        private int RandomId()
        {
            Random rand = new Random();
            return rand.Next(1000, 9999);
        }

        // Constructor
        public Animal(string _type, string _name)
        {
            Type = _type;
            Name = _name;
            Id = RandomId();
        }

    }

}
