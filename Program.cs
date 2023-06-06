using System;
using System.Globalization;

namespace Course
{
    public class While
    {
        public static void Main(string[] args)
        {
            double num, i = 1; //definindo as variaveis e o valor de i

            do
            { //faça
                Console.WriteLine("digite um numero entre 1 e 10");//mensagem para o usuario
                num = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); //solicitando o valor pro usuario
            } while (num < 1 || num > 10); //enquanto o num for menor que 1 OU maior que 10

            Console.WriteLine("Voce digitou o numero: " + num); //mensgem na interface para o usuario


        }
    }
}