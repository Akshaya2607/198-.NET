using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProdNameBLLayer;
using System.Data.SqlClient;
using System.Data;

namespace ProdNameDALayer
{
    [Serializable]
    public class ProductNotFoundException : Exception
    {
        public ProductNotFoundException() { }
        public ProductNotFoundException(string message) : base(message) { }
        public ProductNotFoundException(string message, Exception inner) : base(message, inner) { }
        protected ProductNotFoundException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
    public class ProductsDAL
    {
        public string SearchByProductID(ProductsBAL data)
        {
            SqlConnection conn = new SqlConnection("Server=DESKTOP-13LEK98\\SQLEXPRESS; Integrated Security=true; database=northwind");
            string s1 = "SELECT [dbo].[fn_getProductName] (@p_prodid)";
            SqlCommand cmd = new SqlCommand(s1, conn);
            cmd.Parameters.AddWithValue("@p_prodid", data.ProdId);
            
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            String name;
            name = Convert.ToString(dr[0]);
            if(string.IsNullOrEmpty(name))
            {
                throw new ProductNotFoundException("Product ID not found");
            }
            //Console.WriteLine(name);
            conn.Close();
            conn.Dispose();
            return name;
        }
        public ProductsBAL DisplayALLDetails(int productid)
        {
            SqlConnection conn = new SqlConnection("Server=DESKTOP-13LEK98\\SQLEXPRESS; Integrated Security=true; database=northwind");
            string s1 = "SELECT * FROM [dbo].[fn_getProductDetails] (@p_prodid)";
            SqlCommand cmd = new SqlCommand(s1, conn);
            cmd.Parameters.AddWithValue("@p_prodid", productid);
            conn.Open();
            SqlDataReader dr=cmd.ExecuteReader();
            ProductsBAL bal = new ProductsBAL();
            if (dr.HasRows)
            {
                dr.Read();
                bal.ProdId = Convert.ToInt32(dr[0]);
                bal.ProductName = dr[1].ToString();
                bal.UnitPrice = Convert.ToSingle(dr[2]);
                bal.CategoryID = Convert.ToInt32(dr[3]);
                bal.SupplierID = Convert.ToInt32(dr[4]);
            }
            else
            {     
                    throw new ProductNotFoundException("Product ID not found");
            }
            conn.Close();
            conn.Dispose();
            return bal;
        }

    }
}
