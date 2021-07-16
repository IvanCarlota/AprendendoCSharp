using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestaPontoFlutuante
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando a o projeto 2 - Criando variaveis");

            double salario = 1250.70;
            Console.WriteLine("Meu salário é: "+salario);

            //int valor = 12.5;             // não compila.

            //int valor2 = 0.0;             // não compila.

            //double teste = 125.50;        // compila

            //int valor3 = teste;           // não compila.

            int divisao = 5 / 2;
            Console.WriteLine("Divisão de 5/2 resultando em um inteiro pois foi utilizada a palavra reservada 'int' e utilizado variaveis inteiras: "+divisao);

            double divisao2 = 5.0 / 2;
            Console.WriteLine("Divisão de 5.0/2 resultando em um ponto flutuante pois foi utilizada a palavra reservada 'double' e variaveis de ponto flutuante: "+divisao2);

            Console.WriteLine("Execução finalizada. Tecle enter para sair...");
            Console.ReadLine();
        }
    }
}
