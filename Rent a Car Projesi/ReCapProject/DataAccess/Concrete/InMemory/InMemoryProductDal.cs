using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;

        public InMemoryProductDal()
        {
            _products = new List<Product> { 
            
                new Product{ProductId=1,BrandID=1,ColorId=1,ProductName="Opel",ModelYear=2020,Description="Astra Sedan",DailyPrice=600},
                new Product{ProductId=2,BrandID=2,ColorId=3,ProductName="Ford",ModelYear=2018,Description="Fiesta",DailyPrice=350},
                new Product{ProductId=3,BrandID=2,ColorId=2,ProductName="Ford",ModelYear=2021,Description="Focus",DailyPrice=650},
                new Product{ProductId=4,BrandID=1,ColorId=4,ProductName="Opel",ModelYear=2019,Description="Insignia",DailyPrice=800}

            };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            Product productToDelete = _products.SingleOrDefault(p=>p.ProductId==product.ProductId);
            _products.Remove(productToDelete);
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetById(int brandId)
        {
            return _products.Where(p => p.BrandID == brandId).ToList();    
        }

        public void Update(Product product)
        {
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.ProductId = product.ProductId;
            productToUpdate.ModelYear = product.ModelYear;
            productToUpdate.BrandID = product.BrandID;
            productToUpdate.ColorId = product.ColorId;
            productToUpdate.DailyPrice = product.DailyPrice;
            productToUpdate.Description = product.Description;

        }
    }
}
