using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            _products = new List<Product>
            {
                new Product{ProductId = 1, ProductName ="Bardak",CategoryId=1,UnitPrice=15,UnitsInStock=10},
                new Product{ProductId = 3, ProductName ="Kamera",CategoryId=1,UnitPrice=500,UnitsInStock=3},
                new Product{ProductId = 4, ProductName ="Telefon",CategoryId=2,UnitPrice=1500,UnitsInStock=10},
                new Product{ProductId = 5, ProductName ="Klavye",CategoryId=2,UnitPrice=150,UnitsInStock=10},
                new Product{ProductId = 6, ProductName ="Mouse",CategoryId=2,UnitPrice=85,UnitsInStock=1},
            };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            //LİNQ- First Method-Language Integrated Query

            Product productToDelete = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            _products.Remove(productToDelete);

            //Second Method
            //Algorithm(product);
        }

        //private void Algorithm(Product product)
        //{
        //    Product productToDelete = null;
        //    foreach (var p in _products)
        //    {
        //        if (p.ProductId == product.ProductId)
        //        {
        //            productToDelete = p;
        //        }
        //    }
        //    _products.Remove(productToDelete);
        //}

        public List<Product> GetAll()
        {
            return _products;
        }

        public void Update(Product product)
        {
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;

        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            return _products.Where(p => p.CategoryId == categoryId).ToList();
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            throw new NotImplementedException();
        }
    }
}
