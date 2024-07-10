using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public class Sistema
    {
        public void RodarSistema()
        {
            int num1 = 0;
            int num2 = 0;
            int acao = -1;

            while (acao != 0)
            {
                int opcao = MenuInicial();
                if (opcao == 1)
                {
                    num1 = LerNumero();
                    num2 = LerNumero();
                    acao = MenuCalculadora();
                    if (acao == 0)
                    {
                        break;
                    }
                    else
                    {
                        Calcular(num1, num2, acao);
                    }
                }
                else if (opcao == 2)
                {
                    num1 = LerNumero();
                    num2 = LerNumero();
                    acao = MenuVerificacoes();
                    if (acao == 0)
                    {
                        break;
                    }
                    else
                    {
                        Verificar(num1, num2, acao);
                    }
                }
            }
        }

        private int MenuInicial()
        {
            int opcao = 0;

            while (opcao != 1 && opcao != 2)
            {
                Console.WriteLine("<--- CALCULOS --->");
                Console.WriteLine("1 - CALCULADORA");
                Console.WriteLine("2 - VERIFICAÇÕES");
                Console.WriteLine("<---------------->");
                Console.WriteLine("Digite um número respectivo à ação que deseja realizar:");
                opcao = int.Parse(Console.ReadLine());

                if (opcao != 1 && opcao != 2)
                {
                    Console.WriteLine("Digite uma opção válida");
                }
            }

            return opcao;
        }

        private int MenuCalculadora()
        {
            int acao = -1;

            while (acao != 1 && acao != 2 && acao != 3 && acao != 4 && acao != 0)
            {
                Console.WriteLine("<--- CALCULADORA --->");
                Console.WriteLine("1 - Adição");
                Console.WriteLine("2 - Subtração");
                Console.WriteLine("3 - Multiplicação");
                Console.WriteLine("4 - Divisão");
                Console.WriteLine("0 - Sair");
                acao = int.Parse(Console.ReadLine());

                if (acao != 1 && acao != 2 && acao != 3 && acao != 4 && acao != 0)
                {
                    Console.WriteLine("Digite uma opção válida");
                }
            }
            return acao;
        }

        private int MenuVerificacoes()
        {
            int acao = -1;

            while (acao != 1 && acao != 2 && acao != 3 && acao != 4 && acao != 0)
            {
                Console.WriteLine("<------- VERIFICAÇÕES ----->");
                Console.WriteLine("1 - Verificar se um dos números lidos é ou não múltiplo de outro");
                Console.WriteLine("2 - Verificar se os dois números lidos são pares");
                Console.WriteLine("3 - Verificar se a média dos dois números é maior ou igual a 7");
                Console.WriteLine("0 - Sair");
                acao = int.Parse(Console.ReadLine());

                if (acao != 1 && acao != 2 && acao != 3 && acao != 4 && acao != 0)
                {
                    Console.WriteLine("Digite uma opção válida");
                }
            }
            return acao;
        }

        private int LerNumero()
        {
            int numero = 0;

            while (numero < 0 && numero > 100000000)
            {
                Console.WriteLine("<------------------->");
                Console.WriteLine("Digite um número entre 0 e 100000000:");
                Console.WriteLine("<------------------->");
                numero = int.Parse(Console.ReadLine());

                if (numero < 0 && numero > 100000000)
                {
                    Console.WriteLine("Digite um número válido");
                }
            }

            return numero;
        }

        private int Calcular(int num1, int num2, int acao)
        {
            int resultado = 0;

            if (acao == 1)
            {
                resultado = Calculadora.Adicao(num1, num2);
            }
            else if (acao == 2)
            {
                resultado = Calculadora.Subtracao(num1, num2);
            }
            else if (acao == 3)
            {
                resultado = Calculadora.Multiplicacao(num1, num2);
            }
            else if (acao == 4)
            {
                resultado = Calculadora.Divisao(num1, num2);
            }

            return resultado;
        }

        private bool Verificar(int num1, int num2, int acao)
        {
            bool verificacao = false;

            if (acao == 1)
            {
                verificacao = Calculadora.VerificaMultiplo(num1, num2);
            }
            else if (acao == 2)
            {
                verificacao = Calculadora.VerificaPares(num1, num2);
            }
            else if (acao == 3)
            {
                verificacao = Calculadora.VerificaMedia(num1, num2);
            }

            return verificacao;
        }
    }
}
