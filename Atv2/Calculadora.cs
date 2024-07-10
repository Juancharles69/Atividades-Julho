using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public static class Calculadora
    {
        public static int Adicao(int num1, int num2)
        {
            int resultado = num1 + num2;
            return resultado;
        }

        public static int Subtracao(int num1, int num2)
        {
            int resultado = num1 - num2;
            return resultado;
        }

        public static int Multiplicacao(int num1, int num2)
        {
            int resultado = num1 * num2;
            return resultado;
        }

        public static int Divisao(int num1, int num2)
        {
            int resultado = num1 / num2;
            return resultado;
        }

        public static bool VerificaMultiplo(int num1, int num2)
        {
            bool verificacao = false;
            if (num1 > num2)
            {
                int resultado = num1 % num2;
                Console.WriteLine($"Os números {num1} e {num2} são múltiplos");
                verificacao = true;
            }
            else if (num1 < num2)
            {
                int resultado = num2 % num1;
                Console.WriteLine($"Os números {num1} e {num2} são múltiplos");
                verificacao = true;
            }
            else
            {
                Console.WriteLine($"Os números {num1} e {num2} não são múltiplos");
            }
            return verificacao;
        }

        public static bool VerificaPares(int num1, int num2)
        {
            bool verificacao = false;
            if (num1 % 2 == 0 && num1 % 2 == 0)
            {
                Console.WriteLine($"Os números {num1} e {num2} são pares");
                verificacao = true;
            }
            return verificacao;
        }

        public static bool VerificaMedia(int num1, int num2)
        {
            bool verificacao = false;
            double media = (num1 + num2) / 2;
            if (media >= 7)
            {
                Console.WriteLine($"A média de {num1} e {num2} é maior ou igual a 7.");
            }
            return verificacao;
        }
    }
}
