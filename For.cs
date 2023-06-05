using System;
using System.Globalization;

namespace Course 
{ 
    public class For
    {
        public static void Main(string[] args)
        {
            double num; //definindo a variavel

            Console.WriteLine("digite um numero positivo"); //mensagem para a interface do usuario
            num = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); //solicitando o valor para o usuario

            Console.WriteLine("Os primeiros " + num.ToString(CultureInfo.InvariantCulture) + " Numeros pares são: "); //mensagem para o usuario

            for (int i = 2; i <= num * 2; i += 2)
            { //definindo o valor de i; enquanto i for menor igual ao valor de num multiplicado por 2 some
                Console.Write(i.ToString(CultureInfo.InvariantCulture) + ", "); //mostre o valor de i pro usuario
            }

        }
    }
}