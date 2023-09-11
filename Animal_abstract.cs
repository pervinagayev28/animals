using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animalsPractic
{
    internal  abstract class Animal_abstract
    {
        private Guid id;
        private string name;
        private Color _color;
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Color color { get; set; }

        public Animal_abstract()
        {
            Id = default;
            Name= default;
            color = default;
        }
        public Animal_abstract(string name,Color color)
        {
            Id = new Guid();
            Name = name;
            this.color = color;
        }
        abstract public void eat();


    }
}
