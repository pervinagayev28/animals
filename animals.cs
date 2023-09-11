using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animalsPractic
{
    internal class cat : Animal_abstract
    {
        public cat(string name, Color color) : base(name, color) { }
        public override void eat()
        {
            Console.WriteLine("cat ate");
        }
    }

    internal class dog : Animal_abstract
    {
        public dog(string name, Color color) : base(name, color) { }
        public override void eat()
        {
            Console.WriteLine("dog ate");
        }
    }

    internal class ship : Animal_abstract
    {
        public ship(string name, Color color) : base(name, color) { }
        public override void eat()
        {
            Console.WriteLine("ship ate");
        }
    }
}
