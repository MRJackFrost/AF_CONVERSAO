using System;
using System.Globalization;

namespace Course 
{
   
    public class Program
    {

        public static void Main(string[] args)
        {
            double soma = Soma(6, 4); //Definindo as variaveis e chamando uma função para inputar o valor
            double mult = Mult(6, 4);//Definindo as variaveis e chamando uma função para inputar o valor
            double sub = Sub(6, 4);//Definindo as variaveis e chamando uma função para inputar o valor
            double div = Div(6, 4);//Definindo as variaveis e chamando uma função para inputar o valor

            Console.WriteLine(soma.ToString(CultureInfo.InvariantCulture)); //mostrando o resultado na interface do usuario
            Console.WriteLine(mult.ToString(CultureInfo.InvariantCulture)); //mostrando o resultado na interface do usuario
            Console.WriteLine(sub.ToString(CultureInfo.InvariantCulture)); //mostrando o resultado na interface do usuario
            Console.WriteLine(div.ToString(CultureInfo.InvariantCulture)); //mostrando o resultado na interface do usuario


        }
        public static double Soma(double a, double b)  //criando a função de soma pedindo os valores de a e b
        {
            
            double soma = a + b; //definindo a variavel e o calculo
            return soma; //retornando o valor
        }
        public static double Mult(double a, double b) //criando a função de multiplicação pedindo os valores de a e b
        {
           
            double mult = a * b;//definindo a variavel e o calculo
            return mult; //retornando o valor
        }
        public static double Sub(double a, double b) //criando a função de subtração pedindo os valores de a e b
        {
            
            double sub = a - b;//definindo a variavel e o calculo
            return sub; //retornando o valor
        }
        public static double Div(double a, double b) //criando a função de divisão pedindo os valores de a e b
        {
            
            double div = a / b;//definindo a variavel e o calculo
            return div; //retornando o valor
        }
    }
}
