using System;
using System.Globalization;

namespace Course 
{
   
    public class Program
    {

        public static void Main(string[] args)
        {
            char op; //definindo variavel
            float num1, num2, calc; //definindo variavel
            char per = 's'; //definindo variavel e o valor

            while (per == 's')
            { //enquanto per for igual a s faça

                Console.WriteLine("ENTRE COM O OPERADOR: +, -, /, *: ");//mensagem na interface do usuario
                op = char.Parse(Console.ReadLine()); //solicitando o valor do char
                Console.WriteLine("ENTRE COM OS VALORES"); //mensagem na interface do usuario
                num1 = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                num2 = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                switch (op)
                {
                    case '+'://caso valor for +
                        Console.Write(num1.ToString(CultureInfo.InvariantCulture) + " + " + num2.ToString(CultureInfo.InvariantCulture) + " = ");
                        calc = num1 + num2;
                        Console.WriteLine(calc.ToString(CultureInfo.InvariantCulture));
                        break;//pare o switch
                    case '-'://caso valor for -
                        Console.Write(num1.ToString(CultureInfo.InvariantCulture) + " - " + num2.ToString(CultureInfo.InvariantCulture) + " = ");
                        calc = num1 - num2;
                        Console.WriteLine(calc.ToString(CultureInfo.InvariantCulture));
                        break;//pare o switch
                    case '/'://caso valor for /
                        Console.Write(num1.ToString(CultureInfo.InvariantCulture) + " / " + num2.ToString(CultureInfo.InvariantCulture) + " = ");
                        calc = num1 / num2;
                        Console.WriteLine(calc.ToString(CultureInfo.InvariantCulture));
                        break;//pare o switch
                    case '*'://caso valor for *
                        Console.Write(num1.ToString(CultureInfo.InvariantCulture) + " * " + num2.ToString(CultureInfo.InvariantCulture) + " = ");
                        calc = num1 * num2;
                        Console.WriteLine(calc.ToString(CultureInfo.InvariantCulture));
                        break;//pare o switch
                    default://se não for nenhum dos valores necessarios
                        Console.WriteLine("OPERADOR ERRADO, POR FAVOR INSIRA CORRETAMENTE");
                        break;//pare o switch
                }
                Console.WriteLine("quer continuar com a calculadora? s/n"); //mensagem para o usuario
                per = char.Parse(Console.ReadLine()); //pedindo o valor de per
            }
            Console.WriteLine("Calculadora Finalizada"); //mensagem para o usuario


        }
    }
}