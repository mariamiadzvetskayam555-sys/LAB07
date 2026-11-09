using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB07
{
    public class LogarithmicFunction : Function
    {
        public double A { get; set; }
        public double B { get; set; }

        public LogarithmicFunction(
            double a, 
            double b, 
            double lower,
            double upper
            ) : base("Logarithmic", lower, upper)
        {
            A = a;
            B = b;
        }

        public override double Calculate(double x)
        {
            base.Calculate(x);
            if (x <= 0) return double.NaN; 
            return A * Math.Log(x) + B;
        }
    }
}
