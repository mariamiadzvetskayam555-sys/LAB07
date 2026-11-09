using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB07
{
    public class PowerFunction : Function
    {
        public double A { get; set; }
        public double N { get; set; }

        public PowerFunction(
            double a, 
            double n, 
            double lower, 
            double upper
            ) : base("Power", lower, upper)
        {
            A = a;
            N = n;
        }

        public override double Calculate(double x)
        {
            base.Calculate(x);
            return A * Math.Pow(x, N);
        }
    }
}
