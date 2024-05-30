using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generator_Spisu.Classes
{
    public static class ProductList
    {
        private static List<Product> _products = new List<Product>();

        public static void clearList()
        {
            _products.Clear();
        }

        public static void AddProductToList(Product product)
        {
            _products.Add(product);

            OnProductAdded(product);

        }

        public static int GetProductsCount()
        {
            return _products.Count;
        }

        private static void OnProductAdded(Product product)
        {
            ProductAdded?.Invoke(null, new ProductAddedEventArgs(product));
        }


        public static void RemoveProductFromList(int id)
        {
            for(int i=0; i< _products.Count; i++)
            {
                if (_products[i].Id == id)
                {
                    _products.RemoveAt(i);
                    return;
                }
            }

            throw new Exception("Product not found");
        }


        public static event EventHandler<ProductAddedEventArgs> ProductAdded;   // static event

    }

    public class ProductAddedEventArgs : EventArgs
    {
        public Product Product { get; }

        public ProductAddedEventArgs(Product product)
        {
            Product = product;
        }
    }

}
