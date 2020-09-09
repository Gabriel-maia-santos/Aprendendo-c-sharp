using System;
using System.Globalization;

namespace Aprendendo_c_sharp_1 {
    class Program {
        static void Main(string[] args) {
            Produto p = new Produto();

            Console.WriteLine("Entre os dados do produto: ");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.Write("Quantidade no estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados do produto: " + p);

        }
    }
}
