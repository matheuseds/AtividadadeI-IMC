using System;

namespace AtividadeIMC
{
    class Program
    {
        static void Main(string[] args)
        {
            char sexo;
            double peso;
            double altura;
            double resultado;

            Console.Write("Digite M para sexo masculino e F para sexo feminino: ");
            sexo = char.Parse(Console.ReadLine());

            Console.Write("Digite o seu peso: ");
            peso = double.Parse(Console.ReadLine());

            Console.Write("Digite a sua altura: ");
            altura = double.Parse(Console.ReadLine());

            if(sexo == 'M' || sexo == 'm')
            {
                resultado = Math.Pow(peso / altura, 2);
                Console.Write("O índice de massa corporal é " + resultado);
            }

            else if(sexo == 'F' || sexo == 'f')
            {
                resultado = (peso / altura) - 10;
                Console.Write("O índice de massa corporal é " + resultado);
            }
        }
    }
}
