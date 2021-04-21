using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraOrientada.ConsoleApp
{
    class Program
    {
        #region Requisito 01 [OK]
        //Nossa calculadora deve ter a possibilidade de somar dois números
        #endregion

        #region Requisito 02 [OK]
        //Nossa calculadora deve ter a possibilidade fazer várias operações de soma
        #endregion

        #region Requisito 03 [OK]
        //Nossa calculadora deve ter a possibilidade fazer várias operações de soma e de subtração
        #endregion

        #region Requisito 04 [OK]
        //Nossa calculadora deve ter a possibilidade fazer as quatro operações básicas da matemática
        #endregion

        #region Requisito 05 [OK]
        //Nossa calculadora deve validar a opções do menu [OK]
        #endregion

        #region BUG 01 [OK]
        //Nossa calculadora deve realizar as operações com "0"
        #endregion

        #region Requisito 06
        /** Nossa calculadora deve permitir visualizar as operações já realizadas
         *  Critérios:
         *      1 - A descrição da operação realizada deve aparecer assim, exemplo:
         *          2 + 2 = 4
         *          10 - 5 = 5
         */
        #endregion


        static void Main(string[] args)
            {

                Operacaoes CalculadotaOrientada = new Operacaoes();

                while (true)
                {
                    CalculadotaOrientada.MostrarMenu();

                    CalculadotaOrientada.opcao = Console.ReadLine();

                    if (CalculadotaOrientada.EhOpcaoInvalida(CalculadotaOrientada.opcao))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Opção escolhida é inválida, Tente Novamente");
                        Console.ResetColor();
                        Console.ReadLine();
                        Console.Clear();
                        continue;
                    }
                    if (CalculadotaOrientada.EhOpcaoVizualizacao(CalculadotaOrientada.opcao))
                    {
                        if (CalculadotaOrientada.OperacoesRealizadas == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Nenhuma operação foi realizada!.");
                            Console.ResetColor();
                        }
                        else
                        {
                            for (int i = 0; i < CalculadotaOrientada.operacoesRealizadas.Length; i++)
                            {
                                if (CalculadotaOrientada.operacoesRealizadas[i] != null)
                                    Console.WriteLine(CalculadotaOrientada.operacoesRealizadas[i]);
                            }
                        }
                        Console.ReadLine();
                        Console.Clear();

                        continue;
                    }

                    if (CalculadotaOrientada.EhOpcaoSair(CalculadotaOrientada.opcao))
                    {
                        break;
                    }

                    //PRIMEIRO NUMERO
                    Console.Write("Digite o primeiro número: ");
                    CalculadotaOrientada.primeiroNumero = Convert.ToDouble(Console.ReadLine());

                    //SEGUNDO NUMERO
                    Console.Write("Digite o segundo número: ");
                    CalculadotaOrientada.segundoNumero = Convert.ToDouble(Console.ReadLine());


                    CalculadotaOrientada.Operacoes(CalculadotaOrientada.opcao, ref CalculadotaOrientada.resultado, CalculadotaOrientada.primeiroNumero, CalculadotaOrientada.segundoNumero, ref CalculadotaOrientada.simboloOperacao);

                    string operacaoRealizada =
                        CalculadotaOrientada.primeiroNumero.ToString() + " " + CalculadotaOrientada.simboloOperacao + " " +
                        CalculadotaOrientada.segundoNumero.ToString() + " = " + CalculadotaOrientada.resultado.ToString();


                    // NÃO CONSEGUI CONCATENAR 
                   // string operacaoRealizada = $"{CalculadotaOrientada.primeiroNumero} {CalculadotaOrientada.ObterSimbolo(CalculadotaOrientada.opcao)} {CalculadotaOrientada.segundoNumero} = {CalculadotaOrientada.resultado} ";
                   // CalculadotaOrientada.operacoesRealizada[contadorOperacoesRealizadas] = operacaoRealizada;


                CalculadotaOrientada.operacoesRealizadas[CalculadotaOrientada.OperacoesRealizadas] = operacaoRealizada;

                    CalculadotaOrientada.OperacoesRealizadas++;

                    Console.WriteLine();
                    Console.ReadLine();
                    Console.Clear();
                }

            }

        }
    }

