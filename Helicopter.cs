using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Helicopter : Air  //creat a  inheritace class called Helicopter;
    {
        int _numberOfPropellers; //creat field;

        public Helicopter(string color, int numberOfPropellers = 0) : base(color) //creat constructor with 2 arguments, one is inherited form the parent class;
        {
            _numberOfPropellers = numberOfPropellers;
        }

        public override string ToString() //use override to display result;
        {
            return (base.ToString() + $" - Number of Propellers{_numberOfPropellers}");
        }
    }
   
}
