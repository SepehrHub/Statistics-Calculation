using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication4
{
    class Statistics
    {


        public double Miyangin(double[] a)
        {
            double res = (a.Sum()) / (a.Length);
            return res;
        }
        //========================================
        public double Varians(double[] a)
        {
            double s1 = 0;
            for (int i = 0; i < a.Length; i++)
            {
                s1 += Math.Pow(a[i], 2);
            }
            s1 /= a.Length;
            //==========================
            double s2 = Math.Pow((a.Sum()) / (a.Length), 2);
            return (s1 - s2);
        }
        //========================================
        public double Enherafe_Meyar(double[] a)
        {
            double vr = this.Varians(a);
            return Math.Sqrt(vr);
        }
        //========================================
        public double Multiply(double[] a)
        {
            double f = 1;
            foreach (double d in a)
            {
                f *= d;
            }
            return f;
        }
        //========================================
    }

        
    
}
