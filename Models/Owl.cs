using System;

namespace AbstractExample.Models
{
    public class Owl : AnimalBarry
    {
        public Owl(string name)
        {
            Name = name;
        }

        public Owl()
        {
            Name = "Hooty";
        }

        public override void MakeNoise()
        {
            Console.WriteLine($"{Name} says Hoot Hoot");
        }

        public override void Sleep()
        {
            Console.WriteLine("hazzooo");
        }
    }
}