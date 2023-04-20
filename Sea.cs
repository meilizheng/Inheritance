using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Sea : Vehicle
    {
        string _Type;

        public Sea(string color, string type) : base(color)
        {
            _Type = type;
        }

        public override string ToString()
        {
            return (base.ToString() + $"- It is a {_Type}");
        }
    }
}
