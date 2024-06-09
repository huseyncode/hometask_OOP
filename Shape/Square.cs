using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    public class Square : Shape
    {
        public double Side { get; set; }

        public override double CalculateArea()
        {
            return Math.Pow(Side, 2);
        }
    }
}
