using Adidas.Models.Enity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopSWE.Models.ViewModels
{
    public class ProductNew
    {
        adidasEntities db = null;
        public ProductNew()
        {
            db = new adidasEntities();
        }
        public List<Sanpham> ListNewProduct()
        {
            return db.Sanphams.Where(x => x.Category == 0).OrderByDescending(x => x.ID).ToList();
        }
        public List<Sanpham> QuanAo()
        {
            return db.Sanphams.Where(x => x.Category == 1).OrderByDescending(x => x.ID).ToList();
        }
        public List<Sanpham> Phukien()
        {
            return db.Sanphams.Where(x => x.Category == 2).OrderByDescending(x => x.ID).ToList();
        }
    }
}