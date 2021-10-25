using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BALlayer;
using System.Data.SqlClient;
using System.Data;

namespace DALlayer
{
    public class CategoryDAl
    {
        public DataTable showall()
        {
            SqlConnection conn = new SqlConnection("Data Source = DESKTOP-13LEK98\\SQLEXPRESS; Initial Catalog = ShoppingDB; Integrated Security = True");
            SqlDataAdapter da = new SqlDataAdapter("select *from categories", conn);
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            DataSet ds = new DataSet();
            da.Fill(ds, "categories");
            return ds.Tables["categories"];
        }
        
        public string InsertCategory(CategoryBAL category)
        {
            SqlConnection conn = new SqlConnection("Data Source = DESKTOP-13LEK98\\SQLEXPRESS; Initial Catalog = ShoppingDB; Integrated Security = True");
            SqlDataAdapter da = new SqlDataAdapter("select *from categories", conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "categories");

            DataRow row = ds.Tables["categories"].NewRow();
            row["Catname"] = category.Catname;
            row["Description"] = category.CatDesc;


            DataRowState state = row.RowState;
            string rowstate = null;
            if (state == DataRowState.Detached)
            {
                rowstate = "Not Added to existing rows yet";
            }
            ds.Tables["categories"].Rows.Add(row);
           
            
            if (state == DataRowState.Added)
            {
                rowstate = "This row is added not yet committed tho";
            }
            SqlCommandBuilder bldr = new SqlCommandBuilder(da);
            da.Update(ds.Tables["categories"]);

            
            return rowstate;

        }
        public CategoryBAL FindCategory(int catid)
        {
            SqlConnection conn = new SqlConnection("Data Source = DESKTOP-13LEK98\\SQLEXPRESS; Initial Catalog = ShoppingDB; Integrated Security = True");
            SqlDataAdapter da = new SqlDataAdapter("select *from categories", conn);
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            DataSet ds = new DataSet();
            da.Fill(ds, "categories");

            DataRow drowFound = ds.Tables["categories"].Rows.Find(catid);
            CategoryBAL bal = new CategoryBAL();
            if(drowFound!=null)
            {
                bal.CategoryID = catid;
                bal.Catname = drowFound["Catname"].ToString();
                bal.CatDesc = drowFound["Description"].ToString();
            }

            return bal;
        }
        public string UpdateCategory(CategoryBAL newdata)
        {
            SqlConnection conn = new SqlConnection("Data Source = DESKTOP-13LEK98\\SQLEXPRESS; Initial Catalog = ShoppingDB; Integrated Security = True");
            SqlDataAdapter da = new SqlDataAdapter("select *from categories", conn);
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            DataSet ds = new DataSet();
            da.Fill(ds, "categories");
            DataRow drowFound = ds.Tables["categories"].Rows.Find(newdata.CategoryID);
            drowFound["Catname"] = newdata.Catname;
            drowFound["Description"] = newdata.CatDesc;
            
            
            DataRowState state = drowFound.RowState;
            string rowstate = null;
            if (state == DataRowState.Modified)
            {
                rowstate = "This row is updated";
            }

            SqlCommandBuilder bldr = new SqlCommandBuilder(da);
            da.Update(ds.Tables["categories"]);
            return rowstate;
        }
        
        public string DeleteCategory(int id)
        {
            SqlConnection conn = new SqlConnection("Data Source = DESKTOP-13LEK98\\SQLEXPRESS; Initial Catalog = ShoppingDB; Integrated Security = True");
            SqlDataAdapter da = new SqlDataAdapter("select *from categories", conn);
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            DataSet ds = new DataSet();
            da.Fill(ds, "categories");
            DataRow drowFound = ds.Tables["categories"].Rows.Find(id);
            drowFound.Delete();

            DataRowState state = drowFound.RowState;
            string rowstate = null;
            if(state==DataRowState.Deleted)
            {
                rowstate = "This row is deleted";
            }
            


            
            SqlCommandBuilder bldr = new SqlCommandBuilder(da);
            da.Update(ds.Tables["categories"]);
            return rowstate;
        }
    }
}
