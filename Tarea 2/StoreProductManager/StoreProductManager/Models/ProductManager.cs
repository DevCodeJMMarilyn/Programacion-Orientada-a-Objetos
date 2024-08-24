using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProductManager.Models
{
    public class ProductManager
    {
        public event EventHandler<ProductEventArgs> ProductAdded;
        public event EventHandler<ProductEventArgs> ProductUpdated;

        private List<ProductModel> products = new List<ProductModel>();

        public bool AddProduct(ProductModel product)
        {
            products.Add(product);
            OnProductAdded(product);
            return true;
        }

        public void UpdateProduct(ProductModel updatedProduct)
        {
            // Encontrar el producto original en la lista por su ID
            var originalProduct = products.FirstOrDefault(p => p.Id == updatedProduct.Id);

            if (originalProduct != null)
            {
                // Guarda el nombre original para poder pasarlo al evento
                string originalProductName = originalProduct.Name;

                // Actualizar las propiedades del producto
                originalProduct.Name = updatedProduct.Name;
                originalProduct.Price = updatedProduct.Price;
                originalProduct.Quantity = updatedProduct.Quantity;
                originalProduct.Category = updatedProduct.Category;

                // Llamar al evento de producto actualizado con el nombre original
                OnProductUpdated(updatedProduct, originalProductName);
            }
        }

        protected virtual void OnProductAdded(ProductModel product)
        {
            ProductAdded?.Invoke(this, new ProductEventArgs(product));
        }

        protected virtual void OnProductUpdated(ProductModel updatedProduct, string originalProductName)
        {
            ProductUpdated?.Invoke(this, new ProductEventArgs(updatedProduct, originalProductName));
        }

        public List<ProductModel> GetProducts()
        {
            return products;
        }
    }
}
