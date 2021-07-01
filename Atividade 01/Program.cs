using System;
using System.Collections.Generic;

namespace Atividade_01
{
    class ItemPedido
    {
        public String descricao;
        public double valor_unitario;
        public int quantidade;

        public ItemPedido(String d, double v, int q){
        descricao = d;
        valor_unitario = v;
        quantidade = q;
        }
 
   }
}

class Pedido
{
    private List<Pedido> itemPedido;
    public Pedido()
    {
        ItemPedido = new List<Pedido>();

    }

    public void AdicionaPedido(Pedido item)
    {
        Pedido.Add(item);

    }

    public double TotalizarPedidos()
    {
        double total = 0;


        foreach (var item in ItemPedido)
        {
            total = total + 1; 

        }

        return total;
    }

}
class Program
{
    static void Main(string[] args)
    {
        String descricao, valor_unitario, quantidade;
        char continuar = 's';

        ItemPedido novoPedido = new Pedido();

        do
        {
            Console.Clear();
            Console.WriteLine("Lista de Pedidos");
            
            Console.WriteLine("Descrição do produto ");
            descricao = Console.ReadLine();

            Console.WriteLine("Coloque o valor unitario ");
            valor_unitario = Convert.ToDouble.(Console.ReadLine()); 

            Console.WriteLine("Informe a quantiadade do produto ");
            quantidade = Convert.ToInt32.(Console.ReadLine());


            ItemPedido novoItemPedido = new ItemPedido (descricao, valor_unitario, quantidade);
            novoPedido.AdicionaPedido(novoItemPedido);


        } while (continuar == 's');
        Console.WriteLine("Total de pedidos: " + novoPedido.TotalizarPedidos());
    }
}
