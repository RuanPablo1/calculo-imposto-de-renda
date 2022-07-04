using System;

namespace ImpostoDeRenda {
    internal class Pessoa {

        public float Salario;
        public float Pensao;
        public int Dependentes;

        public float DescontoDependente() { //Valor fixo descontado sobre cada dependente
            return Dependentes * 189.59f;
        }

        public float CalculoSalario() {
            return Salario - Pensao - DescontoDependente();//Salário já retirando o desconto do INSS, pensão alimentícia e taxa fixa sobre cada dependente.
        }
        public void DefineFaixa() {

            float porc, resultado;

            if (CalculoSalario() >= 1903.99 && CalculoSalario() <= 2826.65) {

                Console.WriteLine("\nVocê está na faixa de cálculo 1!;");
                Console.WriteLine("A aliquota e de 7.5% !");
                porc = (CalculoSalario() * 0.075f);
                resultado = porc - 142.8f;
                Console.WriteLine("O desconto total do seu imposto de renda é de " + resultado.ToString("F2"));

            }else

            if (CalculoSalario() >= 2826.66 && CalculoSalario() <= 3751.05) {

                Console.WriteLine("\nVocê está na faixa de cálculo 2!;");
                Console.WriteLine("A aliquota e de 15% !");
                porc = (CalculoSalario() * 0.15f);
                resultado = porc - 354.8f;
                Console.WriteLine("O desconto total do seu imposto de renda é de " + resultado.ToString("F2"));

            }else


            if (CalculoSalario() >= 3751.06 && CalculoSalario() <= 4664.68) {

                Console.WriteLine("\nVocê está na faixa de cálculo 3!;");
                Console.WriteLine("A aliquota e de 22.5% !");
                porc = (CalculoSalario() * 0.225f);
                resultado = porc - 636.13f;
                Console.WriteLine("O desconto total do seu imposto de renda é de " + resultado.ToString("F2"));
            }else


            if (CalculoSalario() > 4664.69) {

                Console.WriteLine("\nVocê está na faixa de cálculo 4!;");
                Console.WriteLine("A aliquota é de 27.5% !");
                porc = (CalculoSalario() * 0.275f);
                resultado = porc - 869.36f;
                Console.WriteLine("O desconto total do seu imposto de renda é de " + resultado.ToString("F2"));
            }
            else {
                Console.WriteLine("\nNão é necessário declarar imposto de renda!");
            }
        }

    }
}