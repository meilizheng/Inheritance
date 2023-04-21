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
        string _Color; //creat filed;

        public Vehicle(string color) //creat constructor with one argument;
        {
            _Color = color;
        }

        public string Color { get => _Color; set => _Color = value; } //create properties;

        public override string ToString() //use override to display the sult;
        {
            return $"{this.GetType()} - {_Color}";
        }
    }
}
