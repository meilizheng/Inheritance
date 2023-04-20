using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Vehicle
    {
        string _Color;

        public Vehicle(string color)
        {
            _Color = color;
        }

        public string Color { get => _Color; set => _Color = value; }

        public override string ToString()
        {
            return $"{this.GetType()} - {_Color}";
        }
    }
}
