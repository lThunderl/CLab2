using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class ClassLab1
    {
        public double[] Solve(int start, int stop)
        { 

            int len = stop - start + 1;

            double[] mas = new double[len];
            mas[0] = 0;

            for (int i = 1; i < 11; i++)
            {
                mas[i] = Math.Round((Math.Pow(i, 2) - Math.Pow(i, 3)) - ((Math.Pow(Math.Cos(i), 3) + 7 * Math.Pow(i, 2))/((Math.Pow(i, 3) - 15 * i)))/(Math.Pow(Math.Cos(i), 2)), 2);
                
            }

            return mas;
        }
    }
}
