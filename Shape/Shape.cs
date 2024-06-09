using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    public abstract class Shape
    {
        public abstract double CalculateArea();
    }

    public class Triangle : Shape
    {
        public double Side { get; set; }
        public double Height { get; set; }

        public override double CalculateArea()
        {
            return 0.5 * Side * Height;
        }
    }
}
