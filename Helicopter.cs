using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Helicopter : Air
    {
        int _numberOfPropellers;

        public Helicopter(string color, int numberOfPropellers = 0) : base(color)
        {
            _numberOfPropellers = numberOfPropellers;
        }

        public override string ToString()
        {
            return (base.ToString() + $" - Number of Propellers{_numberOfPropellers}");
        }
    }
   
}
