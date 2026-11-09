using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB07
{
    public class TrigonometricFunction : Function
    {
        public double A { get; set; }
        public double B { get; set; }

        public TrigonometricFunction(
            double a, 
            double b, 
            double lower,
            double upper
            ) : base("Trigonometric", lower, upper)
        { 
            A = a;
            B = b;
        }

        public override double Calculate(double x)
        {
            base.Calculate(x);
            return A * Math.Sin(x) + B;
        }
    }
}
