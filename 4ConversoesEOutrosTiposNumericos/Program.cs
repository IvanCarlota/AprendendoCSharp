using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4ConversoesEOutrosTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 4 - Criando variaveis");

            double salario = 1250.70;
            Console.WriteLine("O valor de salario é: " + salario);

            //Fazendo casting de dados
            int salarioInteiro = (int)salario;
            Console.WriteLine("Exibindo o novo valor de salário após o casting para 'int': " + salarioInteiro);
            
            
            Console.WriteLine("Execução finalizada. Tecle enter para sair...");
            Console.ReadLine();
        }
    }
}
