using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    //класс InterfaceCalc
    public class Calc : InterfaceCalc
    {
        private double a = 0;
        private double memory = 0;

        public void PutA(double a)
        {
            this.a = a;
        }

        public void ClearA()
        {
            a = 0;
        }

        public double Multiplication(double b)
        {
            return a * b;
        }

        public double Division(double b)
        {
            return a / b;
        }

        public double Sum(double b)
        {
            return a + b;
        }

        public double Subtraction(double b) 
        {
            return a - b;
        }

        public double SqrtX(double b)
        {
            return Math.Pow(a, 1 / b);
        }

        public double DegreeY(double b)
        {
            return Math.Pow(a, b);
        }

        public double Sqrt()
        {
            return Math.Sqrt(a);
        }

        public double Square()
        {
            return Math.Pow(a, 2.0);
        }

        public double Factorial()
        {
            double f = 1;

            for (int i = 1; i <= a; i++)
                f *= (double)i;

            return f;
        }

        
        public double MemoryShow()
        {
            return memory;
        }

        
        public void MemoryClear()
        {
            memory = 0.0;
        }

        public void MSum(double b)
        {
            memory += b;
        }

        public void MSubtraction(double b)
        {
            memory -= b;
        }

    }
}
