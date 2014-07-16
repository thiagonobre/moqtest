using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Moqtest
{
    public class MoqModel
    {
        public DateTime Date { get; set; }

        public MoqModel()
        {
            Date = DateTime.Now;
        }

        public double Hypotenuse(double a, double b)
        {
            return Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
        }
    }
}
