using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Half_wave
{
    public class half_wave
    {
       public double areaCircle(double rad)
        {
            return 3.1415 * rad * rad;
        }
        public double perimeter(double a, double b, double c, double d)
        {
            double p = a + b + d;
            return p;
        }
    }
}
