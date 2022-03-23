using System;
using Registro_de_compra.Entities.Enum;
using Registro_de_compra.Entities;
using System.Globalization;

namespace Registro_de_compra
{
    class Program
    {
        static void Main (string[] args)
        {
            Console.WriteLine("------------------------------");
            Console.Write("Enter cliente data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime date = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("------------------------------");
            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            OrderStatus orderStatus = Enum.Parse<OrderStatus>(Console.ReadLine());

            Client clint = new Client(name, email, date);
            Order order = new Order(DateTime.Now, orderStatus, clint);

            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Product name: ");
                string prod = Console.ReadLine();
                Console.Write("Product price: ");
                double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Product product = new Product(prod, value);

                Console.Write("Quantity: ");
                int quant = int.Parse(Console.ReadLine());
                
                OrderItem orders = new OrderItem(quant, value, product);
                
                order.AddOrder(orders);
            }

            Console.WriteLine("==============================");
            Console.WriteLine("ORDER SUMMARY:");
            Console.WriteLine(order);
        }
    }
}