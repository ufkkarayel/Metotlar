using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Product:IEntity
    {
        public int  ProductId { get; set; }
        public string ProductName { get; set; }
        public int BrandID { get; set; }
        public int ColorId { get; set; }
        public int ModelYear { get; set; }
        public int DailyPrice { get; set; }
        public string Description { get; set; }


    }
}
