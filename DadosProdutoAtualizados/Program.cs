using System;
using System.Globalization;

namespace DadosProdutoAtualizados {
    class Program {
        static void Main(string[] args) {

            Produto p = new Produto();
            Console.WriteLine("Entre os dados do produto: ");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados do produto: " + p);

            Console.WriteLine();
            Console.WriteLine("Digite o número de produtos a ser adicionados ao estoque: ");
            int qtd = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qtd);
            Console.WriteLine("Dados atualizados "+ p);

            Console.WriteLine();
            Console.WriteLine("Digite o numero de produtos a ser Removidos do estoque: ");
            qtd = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qtd); Console.WriteLine("Dados Atualizados " + p);
        }
    }
}
