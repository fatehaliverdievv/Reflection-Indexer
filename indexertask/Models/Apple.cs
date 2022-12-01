using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace indexertask.Models
{
    internal class Apple : Fruit
    {
        public int VitaminA { get; set; }
        public override void Smell()
        {
            Console.WriteLine("Smells like apple");
        }
    }
}
