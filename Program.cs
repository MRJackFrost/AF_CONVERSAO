using System;
using System.Globalization;

namespace Course
{
    public class While
    {
        public static void Main(string[] args)
        {
            double num, i = 1; //definindo as variavels e o valor de i

            Console.WriteLine("digite um numero"); //enviando uma informação para a interface do usuario
            num = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); //recevendo um valor do usuario

            while (i <= num)
            { //enquanto i for menor ou igual a num faça
                Console.WriteLine(i + ", "); //mostre o valor para o usuario
                i++; //adicione mais 1 no valor de i
            }


        }
    }
}