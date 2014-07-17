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

        public double Greatest(double a, double b)
        {
            return (a + b + (Math.Abs(a-b)))/2;
        }

        public string ConvertToHMS(int seconds)
        {
            int s, m, h;

            s = seconds % 60;
            int totalMinutes = (seconds - s) / 60;
            m = totalMinutes % 60;
            h = (totalMinutes - m) / 60;

            return String.Format("{0}:{1}:{2}", h, m, s);
        }
    }
}
