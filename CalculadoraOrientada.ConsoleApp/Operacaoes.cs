using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraOrientada.ConsoleApp

{
  
    class Operacaoes
    {
        public double primeiroNumero, segundoNumero;
        public string[] operacoesRealizadas = new string[1000];
        public string opcao = "";
        public int OperacoesRealizadas = 0;
        public double resultado = 0;
        public string simboloOperacao = "";

        public bool EhOpcaoVizualizacao(string opcao)
        {
            return opcao == "5";

        }

        public void Operacoes(string opcao, ref double resultado, double primeiroNumero, double segundoNumero, ref string simboloOperacao)
        {

            switch (opcao)
            {
                case "1":
                    resultado = primeiroNumero + segundoNumero;
                    simboloOperacao = "+";
                    Console.WriteLine(resultado); 
                    
                    break;
                case "2":

                    resultado = primeiroNumero - segundoNumero;
                    simboloOperacao = "-";
                    Console.WriteLine(resultado);
                    
                    break;
                case "3":

                    resultado = primeiroNumero * segundoNumero;
                    simboloOperacao = "*";
                    Console.WriteLine(resultado);
                    
                    break;
                case "4":
 
                    resultado = primeiroNumero / segundoNumero;
                    simboloOperacao = "/";
                    Console.WriteLine(resultado); 
                    
                    break;
            }
        }

        public bool EhOpcaoSair(string opcao)
        {
            return opcao.Equals("s", StringComparison.OrdinalIgnoreCase);
        }

        public bool EhOpcaoInvalida(string opcao)
        {
            return opcao != "1" && opcao != "2" && opcao != "3"
                                && opcao != "4" && opcao != "5"
                                && opcao != "S" && opcao != "s";
        }
        public void MostrarMenu()
        {
            Console.WriteLine("Calculadora Tabajara Orientada 2.0");

            Console.WriteLine();

            Console.WriteLine("Digite 1 para somar");

            Console.WriteLine("Digite 2 para subtrair");

            Console.WriteLine("Digite 3 para multiplicação");

            Console.WriteLine("Digite 4 para divisão");

            Console.WriteLine("Digite 5 para visualizar as operações realizadas");

            Console.WriteLine("Digite S para sair");
        }


    }
}




