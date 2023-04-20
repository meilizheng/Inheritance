using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Plane : Air
    {
        int _NumberOfJets;

        public Plane(int numberOfJets, string color) : base(color)
        {
            _NumberOfJets = numberOfJets;
        }

        
        public int NumberOfJets { get => _NumberOfJets; set => _NumberOfJets = value; }
        public override string ToString()
        {
            return (base.ToString() + $" - Number of Jets {_NumberOfJets}");
        }
    }
}
