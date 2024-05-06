using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thirteenth_lesson
{
    internal class Product
    {

        public int Id { get; set; }
        public List<string> Categories { get; set; }
        public int Price { get; set; }

        public override bool Equals(object? obj)
        {
            var product = (Product)obj;
            if (product.Price == Price)
            {
                return true;
            }
            return false;
        }
    }
}
