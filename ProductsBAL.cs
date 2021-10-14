using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdNameBLLayer
{
    public class ProductsBAL
    {
        private int _prodid;
        public int ProdId
        {
            get
            {
                return _prodid;
            }
            set
            {
                if (value > 0)
                    _prodid = value;
                else
                    throw new ArgumentNullException("Product ID should be greater than 0");
            }
        }
      
        public string ProductName { get; set; }

        public float UnitPrice { get; set; }
        public int CategoryID { get; set; }
        public int SupplierID { get; set; }
    }
}
