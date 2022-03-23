using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Registro_de_compra.Entities;
using System.Globalization;

namespace Registro_de_compra.Entities
{
    internal class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }

        public OrderItem()
        {
        }

        public OrderItem(int quantity, double price, Product product)
        {
            Quantity = quantity;
            Price = price;
            Product = product;
        }

        public double TotalValue()
        {
            return (Price * Quantity);
        }

        public override string ToString()
        {
            return Product.Name
                + ", R$"
                + Price.ToString("F2", CultureInfo.InvariantCulture)
                + ", Quantity: "
                + Quantity
                + ", SubTotal: R$"
                + TotalValue().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
