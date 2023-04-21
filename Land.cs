using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Land : Vehicle //creat a inherit class;
    {
        int _Wheels; //creat field;

        public Land(int wheels, string color) : base(color) //creat constructor with two arguments, one is inherited from the parent class;
        {
            _Wheels = wheels;
        }

        protected int Wheels { get => _Wheels; set => _Wheels = value; } //creat the properties;

        public override string ToString() //display the result;
        {
            return (base.ToString() + $" - Number of Wheels: {_Wheels}");
        }          
    }
}
