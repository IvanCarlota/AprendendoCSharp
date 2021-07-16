using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3CriandoVariaveisPontoFlutuante
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 3 - Criando variaveis");

            double salario;
            String nome;

            salario = 1200.70;
            nome = "Ivan";

            Console.WriteLine("O salário de "+nome+" é: "+salario );

            Console.WriteLine("Execução finalizada. Tecle enter para sair...");
            Console.ReadLine();
        }
    }
}
