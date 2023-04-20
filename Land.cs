using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Land : Vehicle
    {
        int _Wheels;

        public Land(int wheels, string color) : base(color)
        {
            _Wheels = wheels;
        }

        public int Wheels { get => _Wheels; set => _Wheels = value; }

        public override string ToString()
        {
            return (base.ToString() + $" - Number of Wheels: {_Wheels}");
        }          
    }
}
