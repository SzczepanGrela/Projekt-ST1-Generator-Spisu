using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Generator_Spisu.Classes
{
    public static class ProductList
    {
        private static List<Product> _products = new List<Product>();

        public static void ClearList()
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

        public static List<List<Object>> GetProductLists()
        {
            if (_products.Count == 0)
            {
                return null;
            }
           List<List<Object>> ListofProductLists = new List<List<Object>>();
            foreach(Product product in _products)
            {
                List<Object> productProperties = new List<Object>();

                foreach (PropertyInfo property in product.GetType().GetProperties())
                {
                    if (property.Name != "ColumnHeaders")
                    {
                        object propertyValue = property.GetValue(product);
                        productProperties.Add(propertyValue);
                    }
                }
                ListofProductLists.Add(productProperties);
                
            }

            return ListofProductLists;
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


        public static string[] GetProductCsvList()
        {
            string[] productsCSV = new string[_products.Count];
            
            for(int i=0;i<_products.Count;i++)
            {

                productsCSV[i] = _products[i].ToCSV();
                
            }

            return productsCSV;
        }


        public static void EditProductInList(Product product)
        {
            for (int i = 0; i < _products.Count; i++)
            {
                if (_products[i].Id == product.Id)
                {
                    _products[i] = product;
                    return;
                }
            }

            throw new Exception("Product not found");
        }

        internal static void AddFromCsv(string line)
        {
            string[] parts = line.Split(';');

            Product product = new Product();

            PropertyInfo[] properties = typeof(Product).GetProperties();

            for (int i = 0; i < properties.Length && i < parts.Length; i++)
            {

                if (properties[i].PropertyType == typeof(int))
                {
                    
                    if (int.TryParse(parts[i], out int intValue))
                    {
                        
                        properties[i].SetValue(product, intValue);
                    }
                    else
                    {
                       
                            throw new Exception($"Nie można przekonwertować wartości {parts[i]} na int");

                    }
                }
                else if (properties[i].PropertyType == typeof(string))
                {
                    
                    properties[i].SetValue(product, parts[i]);
                }
                else
                {
                    
                     throw new Exception($"Nieobsługiwany typ danych {parts[i]}");
                }

            }

            AddProductToList(product);
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
