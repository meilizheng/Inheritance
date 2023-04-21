using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Sea : Vehicle //creat a inheritance class called sea;
    {
        string _Type; //creat the field;

        public Sea(string color, string type) : base(color) //creat constructor with two arguments, one is inherited from the parent class;
        {
            _Type = type;
        }

        public override string ToString() //use override to display result;
        {
            return (base.ToString() + $"- It is a {_Type}");
        }
    }
}
