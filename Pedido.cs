using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedido
{
    class Pedido
    {
        public double ValorTotal { get; set; }
        Dictionary<Produto, Item> Itens = new Dictionary<Produto, Item>();

        public bool adicionarItem(int quantidade, Produto produto, double desconto)
        {
            if(Itens.ContainsKey(produto))
            {
                Console.WriteLine("Já existe um item com esse produto!");
                return false;
            }

            Item item = new Item(quantidade, produto, desconto);

            Itens.Add(produto, item);
            calcularTotal(item.ValorFinal);
            return true;
        }

        public void calcularTotal(double valor)
        {
            ValorTotal += valor;
        }

        public void imprimirDados()
        {
            Console.WriteLine("----- Dados do Pedido -----");
            foreach (KeyValuePair<Produto, Item> item in Itens)
            {
                Console.WriteLine("Nome do Produto: " + item.Key.Nome);
                Console.WriteLine("Preço Unitário: " + item.Key.Preco.ToString("C"));
                Console.WriteLine("Quantidade: " + item.Value.Quantidade);
                Console.WriteLine("Valor Total: " + item.Value.Valor.ToString("C"));
                Console.WriteLine("Desconto: " + item.Value.Desconto + "%");
                Console.WriteLine("Valor Final: " + item.Value.ValorFinal.ToString("C"));
                Console.WriteLine(" ");
            }
            Console.WriteLine("Total do pedido: " + this.ValorTotal.ToString("C"));
            Console.WriteLine("---------------------------");
        }
    }
}
