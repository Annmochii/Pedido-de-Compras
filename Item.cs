using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedido
{
    class Item
    {
        public int Quantidade { get; set; }
        public double Desconto { get; set; }
        public double Valor { get; set; }
        public double ValorFinal { get; set; }
        public Produto produto;


        public Item(int quantidade, Produto produto, double desconto)
        {
            Quantidade = quantidade;
            Valor = produto.Preco * quantidade;
            Desconto = desconto;
            ValorFinal = Valor - (Valor * (Desconto / 100));
            this.produto = produto;
        }
    }
}
