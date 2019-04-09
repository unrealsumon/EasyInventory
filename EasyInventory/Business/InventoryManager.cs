using EasyInventory.Data;
using EasyInventory.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyInventory.Business
{
    public class InventoryManager
    {
        private readonly InventoryContext _context;

        public InventoryManager(InventoryContext context)
        {
            _context = context;
        }


        public List<Product> GetProduct()
        {
            var result = _context.TB_Products.Select(x => x).ToList();

            var productList = result.Select(x => new Product
            {
                ProductID=x.ProductID,
                ProductName=x.ProductName,
                CategoryID=x.CategoryID,
                UnitName=x.UnitName,
                Barcode=x.Barcode,
                Brand=x.Brand,
                IsActive=x.IsActive,
                Model=x.Model,
                Description=x.Description

            }).ToList();

            return productList;
        }

        public Product GetProductByID(int id)
        {
            var result = _context.TB_Products.Where(x => x.ProductID==id).FirstOrDefault();

            Product aProduct = new Product {
                ProductID = result.ProductID,
                ProductName = result.ProductName,
                CategoryID = result.CategoryID,
                UnitName = result.UnitName,
                Barcode = result.Barcode,
                Brand = result.Brand,
                IsActive = result.IsActive,
                Model = result.Model,
                Description = result.Description
            };  
            return aProduct;
        }


        public string AddUpdateProduct(Product model)
        {
            if (model.ProductID == -1)                       // new product
            {
                TB_Products aProduct = new TB_Products
                {                    
                    ProductName = model.ProductName,
                    CategoryID = model.CategoryID,
                    UnitName = model.UnitName,
                    Barcode = model.Barcode,
                    Brand = model.Brand,
                    IsActive = model.IsActive,
                    Model = model.Model,
                    Description = model.Description
                };

                _context.TB_Products.Add(aProduct);
            }
            else                                                // update product
            {
                var aProduct = _context.TB_Products.Find(model.ProductID);

                aProduct.ProductName = model.ProductName;
                aProduct.CategoryID = model.CategoryID;
                aProduct.UnitName = model.UnitName;
                aProduct.Barcode = model.Barcode;
                aProduct.Brand = model.Brand;
                aProduct.IsActive = model.IsActive;
                aProduct.Model = model.Model;
                aProduct.Description = model.Description;
               
            }
           
            try
            {
                _context.SaveChanges();
                _context.Dispose();
                return "";
            }
            catch (Exception ex)
            {
               return ex.Message;
            }
         

                       

        }



       public string Delete(int id)
        {
            var aProduct = _context.TB_Products.Find(id);           
            aProduct.IsActive = false;
            try
            {
                _context.SaveChanges();
                _context.Dispose();
                return "";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }





    }
}
