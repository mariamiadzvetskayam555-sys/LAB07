using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB07
{
    public class Function
    {
        public double LowerBound { get; set; }
        public double UpperBound { get; set; }
        public string FunctionName { get; set; }

        public Function(string name, double lower, double upper)
        {
            if (lower > upper)
            {
                throw new ArgumentException($"Нижняя граница не может быть больше верхней.");
            }
            FunctionName = name;
            LowerBound = lower;
            UpperBound = upper;
        }

        public virtual double Calculate(double x)
        {
            if (x < LowerBound || x > UpperBound)
            {
                throw new ArgumentException($"Точка x={x} не принадлежит отрезку.");
            }
            return 0; 
        }

        public override string ToString()
        {
            string result = $"{FunctionName}(x) [{LowerBound}, {UpperBound}] = ";

            for (double x = LowerBound; x <= UpperBound; x++)
            {
                result += $"{Calculate(x)}";

                if (x < UpperBound) result += ", ";
            }
            return result;
        }
    }
}
