using System;
using System.Globalization;

namespace ProductStock
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite os dados do produto: ");
            Console.Write("Nome: ");
            string name = Console.ReadLine();

            Console.Write("Preço: ");
            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantidade em estoque: ");
            int quantityStock = int.Parse(Console.ReadLine());

            Product product = new Product(name, price, quantityStock);

            Console.WriteLine("Dados do produto: " + product.ToString());

            Console.WriteLine();
            Console.Write("Digite a quantidade para adicionar no estoque: ");
            int quantity = int.Parse(Console.ReadLine());

            product.AddStock(quantity);

            Console.WriteLine("Dados do produto: " + product.ToString());

            Console.WriteLine();
            Console.Write("Digite a quantidade para retirar do estoque: ");
            quantity = int.Parse(Console.ReadLine());

            product.RemoveStock(quantity);

            Console.WriteLine("Dados do produto: " + product.ToString());
        }
    }
}
