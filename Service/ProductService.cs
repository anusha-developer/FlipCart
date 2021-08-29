using FlipCart.Models;
using FlipCart.Repositary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FlipCart.Service
{
    public class ProductService
    {

        private ProductRepositaryImp productRepositaryImp;

         public ProductService()
          {
            productRepositaryImp = new ProductRepositaryImp();
          }
          public Product Saveproduct(Product product)
          {
              return productRepositaryImp.CreateProduct(product);
          }
        public  Product GetProductById(int productId)
        {
            return productRepositaryImp.findProductById(productId);
        }
        public List<Product> GetAllProducts()
        {
            return productRepositaryImp.findAllProducts();
        }
        public Product UpdateProductById(int productId,Product product)
        {
            return productRepositaryImp.updateProduct(productId , product);
        }
        public string DeleteProductById(int productId)
        {
            return productRepositaryImp.DeleteProduct(productId);
        }
        public Product GetProductByName(String Name)
        {
            return productRepositaryImp.findProductByName(Name);
        }
        public List<Product> SearchAllProductsByName( string Name)
        {
            return productRepositaryImp.SearchAllProductsByName(Name);
        }
        public List<Product> FindAllProductsBetweenRange(decimal MinPrice, decimal MaxPrice)
        {
            return productRepositaryImp.FindAllProductsBetweenRange(MinPrice, MaxPrice);
        }

    }
}