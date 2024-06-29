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
        private static List<DynamicProduct> _products = new List<DynamicProduct>();

        public static void ClearList()
        {
            _products.Clear();
        }

        public static void AddProductToList(DynamicProduct product)
        {
            _products.Add(product);

            OnProductAdded(product);

        }

        public static int GetProductsCount()
        {
            return _products.Count;
        }

        /*    public static List<List<Object>> GetProductLists()
            {
                if (_products.Count == 0)
                {
                    return null;
                }
               List<List<Object>> ListofProductLists = new List<List<Object>>();
                foreach(DynamicProduct product in _products)
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
    */



        public static List<List<string>> GetProductLists()
        {
            if (_products.Count == 0)
            {
                return null;
            }
            List<List<string>> ListofProductLists = new List<List<string>>();

            List<ProductAttribute> ProductAttributes = AttributeList.GetAttributes();


            foreach (DynamicProduct product in _products)
            {
                List<string> productProperties = new List<string>();
                foreach (ProductAttribute attribute in ProductAttributes)
                {
                    string nextValue = product.GetAttributeValue(attribute) == null ? "" : product.GetAttributeValue(attribute).ToString();

                    productProperties.Add(nextValue);


                }
                ListofProductLists.Add(productProperties);


            }


            return ListofProductLists;
        }




        private static void OnProductAdded(DynamicProduct product)
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


        public static int GetNextId()
        {
            if (_products.Count == 0)
            {
                return 1;
            }
            else
            {
                return _products[_products.Count - 1].Id+1;   // returns latest id incremented by 1
            }
        }   

        public static List<string> GetProductCsvList()
        {
            List<string> productsCSV = new List<string>();
            
            for(int i=0;i<_products.Count;i++)
            {

                productsCSV.Add(_products[i].ToCSVline());
                
            }

            return productsCSV;
        }


        public static void EditProductInList(DynamicProduct product)
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

            DynamicProduct product = new DynamicProduct();

            PropertyInfo[] properties = typeof(Product).GetProperties();

            for (int i = 1; i < properties.Length; i++)
            {
                properties[0].SetValue(product, GetNextId());

                if (properties[i].PropertyType == typeof(int))
                {
                    
                    if (int.TryParse(parts[i-1], out int intValue))
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
                    
                    properties[i].SetValue(product, parts[i-1]);
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
        public DynamicProduct Product { get; }

        public ProductAddedEventArgs(DynamicProduct product)
        {
            Product = product;
        }
    }

}
