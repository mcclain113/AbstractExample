using System;

namespace AbstractExample.Models
{
    public abstract class AnimalBarry
    {
        public string Name { get; set; }

        // common methods
        public abstract void MakeNoise();

        public virtual void Sleep()
        {
            Console.WriteLine("ZZZZzzzzzbydefault");
        }
    }
}