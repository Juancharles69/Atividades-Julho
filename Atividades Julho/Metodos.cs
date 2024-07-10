using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaAtividades
{
    public class Metodos
    {
        public double EstoqueMedio { get; set; }

        public void CalcularEstoqueMedio(int QuantidadeMin, int QuantidadeMax)
        {
            EstoqueMedio = (QuantidadeMin + QuantidadeMax) / 2;
        }

        public void DolarToReal()
        {
            Console.WriteLine("Digite a atual cotação do dólar:");
            double dolar = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite um valor: (dólar)");
            double valor = int.Parse(Console.ReadLine());
            double resultado = valor * dolar;

            Console.WriteLine($"US {valor} = R$ {resultado}. DOL: {dolar}");
        }

        public int ValorA { get; set; }
        public int ValorB { get; set; }

        public void TrocarValores()
        {

            int ValorAuxA = ValorA;
            int ValorAuxB = ValorB;

            Console.WriteLine($"<--- VALORES ORIGINAIS --->");
            Console.WriteLine($"Valor A: {ValorA}");
            Console.WriteLine($"Valor B: {ValorB}");
            Console.WriteLine($"<------------------------->");

            ValorA = ValorAuxB;
            ValorB = ValorAuxA;

            Console.WriteLine($"<--- VALORES TROCADOS --->");
            Console.WriteLine($"Valor A: {ValorA}");
            Console.WriteLine($"Valor B: {ValorB}");
            Console.WriteLine($"<------------------------>");
        }

        public int Num { get; set; }

        public void Modulo(int num)
        {
            Num = num;

            if (Num >= 0)
            {
                Num = Num;
            }
            else if (Num < 0)
            {
                Num = Num * (-1);
            }

            Console.WriteLine($"O seu módulo é: {Num}");
        }
    }
}
