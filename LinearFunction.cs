using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB07
{
    public class LinearFunction : Function
    {
        public double K { get; set; }
        public double B { get; set; }

        public LinearFunction(
            double k, 
            double b, 
            double lower, 
            double upper
            ) : base("Linear", lower, upper)
        {
            K = k;
            B = b;
        }

        public override double Calculate(double x)
        {
            base.Calculate(x);
            return K * x + B;
        }
    }
}
