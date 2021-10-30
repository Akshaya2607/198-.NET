using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CategoryWebAPI.Models;
using BALlayer;
using DALlayer;
using System.Data;
namespace CategoryWebAPI.Controllers
{
    public class ShopCategoryController : ApiController
    {
        // GET: api/ShopCategory
        public List<CategoriesModel> Get()
        {
            CategoryDAl dal = new CategoryDAl();
            DataTable dt = new DataTable();
            dt = dal.showall();
            List<CategoriesModel> list = new List<CategoriesModel>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                CategoriesModel m = new CategoriesModel();
                m.CategoryID = Convert.ToInt32(dt.Rows[i][0]);
                m.Catname = dt.Rows[i][1].ToString();
                m.CatDesc = dt.Rows[i][2].ToString();
                list.Add(m);
            }
            return list;
            
            //return new string[] { "value1", "value2" };
        }

        // GET: api/ShopCategory/5
        public CategoriesModel Get(int id)
        {
            CategoryDAl dal = new CategoryDAl();
            CategoryBAL bal = new CategoryBAL();
            bal = dal.FindCategory(id);
            CategoriesModel m = new CategoriesModel();
            m.CategoryID = bal.CategoryID;
            m.Catname = bal.Catname;
            m.CatDesc = bal.CatDesc;
            return m;

            //return "value";
        }

        // POST: api/ShopCategory
        public void Post([FromBody]CategoriesModel value)
        {
            CategoryDAl dal = new CategoryDAl();
            CategoryBAL bal = new CategoryBAL();
            bal.Catname = value.Catname;
            bal.CatDesc = value.CatDesc;
            string s=dal.InsertCategory(bal);

        }

        // PUT: api/ShopCategory/5
        public void Put(int id, [FromBody]CategoriesModel value)
        {
            CategoryDAl dal = new CategoryDAl();
            CategoryBAL bal = new CategoryBAL();
            bal.CategoryID = value.CategoryID;
            bal.Catname = value.Catname;
            bal.CatDesc = value.CatDesc;
            dal.UpdateCategory(bal);
        }

        // DELETE: api/ShopCategory/5
        public void Delete(int id)
        {
            CategoryDAl dal = new CategoryDAl();
            dal.DeleteCategory(id);
        }
    }
}
