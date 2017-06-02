using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FCamara.Domain.Entities
{
    public class Product
    {
        public Product(string title, decimal price)
        {
            // Id = Guid.NewGuid();
            Title = title;
            Price = price;
        }

        public Product()
        {

        }
        public int Id { get; private set; }
        public string Title { get; private set; }
        public decimal Price { get; private set; }
    }
}
