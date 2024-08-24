using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProductManager.Models
{
    public class ProductEventArgs : EventArgs
    {
        public ProductModel Product { get; }
        public string OriginalProductName { get; }

        public ProductEventArgs(ProductModel product, string originalProductName = null)
        {
            Product = product;
            OriginalProductName = originalProductName;
        }
    }
}
