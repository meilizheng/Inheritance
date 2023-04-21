using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Plane : Air //creat a inheritace class called plane; and the the parent class is Air;
    {
        int _NumberOfJets; //creat field;

        public Plane(int numberOfJets, string color) : base(color)  //creat constructor with 2 arguments, one is from the parent class;
        {
            _NumberOfJets = numberOfJets;
        }

        
        public int NumberOfJets { get => _NumberOfJets; set => _NumberOfJets = value; }//creat propeties;
        public override string ToString() //use override to display result;
        {
            return (base.ToString() + $" - Number of Jets {_NumberOfJets}");
        }
    }
}
