using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImpostoDeRenda {
    internal class Program {

        static void Main(string[] args) {

            Pessoa pessoa = new Pessoa();

            Console.Write("Digite o valor do seu salário com o desconto do INSS: ");
            pessoa.Salario = float.Parse(Console.ReadLine());

            Console.WriteLine("\nQuanto você paga de pensão alimentícia?");
            pessoa.Pensao = float.Parse(Console.ReadLine());

            Console.WriteLine("\nQuantos dependentes você possui?");
            pessoa.Dependentes = int.Parse(Console.ReadLine());


            pessoa.CalculoSalario(); 

            pessoa.DefineFaixa();

            Console.WriteLine("\nPressiona enter para sair...");
            Console.ReadLine();

            //Fonte utilizada para a lógica do cálculo: https://blog.convenia.com.br/como-calcular-irrf-na-folha-de-pagamento/
        }
    }
}