using System;
using System.Globalization;

namespace Course 
{
   
    public class Program
    {

        public static void Main(string[] args)
        {
            double soma = Soma(6, 4);
            double mult = Mult(6, 4);
            double sub = Sub(6, 4);
            double div = Div(6, 4);

            Console.WriteLine(soma.ToString(CultureInfo.InvariantCulture));
            Console.WriteLine(mult.ToString(CultureInfo.InvariantCulture));
            Console.WriteLine(sub.ToString(CultureInfo.InvariantCulture));
            Console.WriteLine(div.ToString(CultureInfo.InvariantCulture));


        }
        public static double Soma(double a, double b)
        {
            
            double soma = a + b;
            return soma;
        }
        public static double Mult(double a, double b)
        {
           
            double mult = a * b;
            return mult;
        }
        public static double Sub(double a, double b)
        {
            
            double sub = a - b;
            return sub;
        }
        public static double Div(double a, double b)
        {
            
            double div = a / b;
            return div;
        }
    }
}