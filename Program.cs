using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProdNameBLLayer;
using ProdNameDALayer;

namespace DisplayProdNameApp
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Menu \n 1.Search By ID \n 2.Show All Details");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    SearchByID();
                    break;
                case 2:
                    ShowAllDetails();
                    break;
                default:
                    break;
            }
            
            Console.Read();
        }

        private static void ShowAllDetails()
        {
            try
            {
                Console.WriteLine("Enter Product ID");
                int ProdId = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Processing ur request....");
                ProductsBAL bal = new ProductsBAL();
                ProductsDAL dn = new ProductsDAL();
                bal=dn.DisplayALLDetails(ProdId);
                Console.WriteLine("Product ID= "+bal.ProdId);
                Console.WriteLine("Product Name= "+bal.ProductName);
                Console.WriteLine("Unit Price= " +bal.UnitPrice);
                Console.WriteLine("Category ID= "+bal.CategoryID);
                Console.WriteLine("Supplier ID= "+bal.SupplierID);

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }

        private static void SearchByID()
        {
            ProductsBAL d = new ProductsBAL();
            try
            {
                Console.WriteLine("Enter Product ID");
                d.ProdId = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Processing ur request....");

                ProductsDAL dn = new ProductsDAL();
                String name = dn.SearchByProductID(d);

                Console.WriteLine("Product name= " + name);

            }
            catch (ProductNotFoundException ex)
            {
                //Console.WriteLine("Product Id not found");
                Console.WriteLine(ex.Message);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
