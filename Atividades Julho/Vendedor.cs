using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaAtividades
{
    public class Vendedor
    {
        public int Identificacao { get; set; }
        public double Comissao { get; set; }
        public int QuantidadeVendas { get; set; }

        public void CalculoComissao(Peca peca)
        {
            Comissao = (peca.Valor * QuantidadeVendas) * 0.05;
        }
    }
}
