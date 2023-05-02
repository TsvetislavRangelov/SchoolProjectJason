using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject
{
   public class AdditionCalculator
    {
        public int Num1 { get; private set; }
        public int Num2 { get; private set; }
        public int Answer { get; private set; }

        public AdditionCalculator()
        {

        }


        public string Generate()
        {
            Random rand = new();

            Num1 = rand.Next(1, 10);
            Num2 = rand.Next(1, 10);

            Answer = Num1 + Num2;

            return $"Addition: What's {Num1} + {Num2}?";
        }
    }
}
