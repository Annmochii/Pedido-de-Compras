using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedido
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p1 = new Produto("Camisa Social Preta", 150.00);
            Produto p2 = new Produto("Camiseta Blink 182 Cinza", 45.00);
            Produto p3 = new Produto("Tênis All-Star Azul", 265.00);
            Produto p4 = new Produto("Calça Social Xadrez", 350.00);
            Produto p5 = new Produto("Calça Wide-Leg Jeans", 265.00);

            Pedido ped001 = new Pedido();
            Pedido ped002 = new Pedido();
            Pedido ped003 = new Pedido();

            ped001.adicionarItem(3, p1, 15);
            ped001.adicionarItem(5, p4, 0);
            ped002.adicionarItem(10, p2, 5);
            ped002.adicionarItem(15, p5, 10);
            ped003.adicionarItem(3, p3, 0);

            ped001.imprimirDados();
            ped002.imprimirDados();
            ped003.imprimirDados();
        }
    }
}
