using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace CIS_2225_Final_Practical_Mohammad_Rahman
{
   public class DataAccessTire
    {

        private OleDbConnection Conn;
        private const string ConnStr =
            "Provider=Microsoft.ACE.OLEDB.12.0;" +
           "Data Source = Product.accdb";

        private string strTable = "";
        private string strFields = "";
        private string strValues = "";
        private string insertStr = "";

        private const string thisTable = "Product";
        private const string product_id = "Product_ID";
        private const string description = "Description";
        private const string price = "Retail_Price";
        private const string quantity = "Quantity";
        private const string markUp = "MarkUP";


        public DataAccessTire() { }


        /*
         Method name: OpenConn
         Author: Mohammad Rahman
         Description: Open connection of database 
       */
        private void OpenConn()
        {
            String connStr = ConnStr;
            Conn = new OleDbConnection(connStr);
            Conn.Open();
        }

        /*
         Method name: CloseConn
         Author: Mohammad Rahman
         Description: Close connection of database 
       */
        private void CloseConn()
        {
            Conn.Close();
        }


        /*
         Method name: Add
         Author: Mohammad Rahman
         Description: Execute Insert Query to database 
       */
        public void Add(BusinessTire Prod)
        {
            String Str = BuildAddQuery(Prod);
            OpenConn();

            OleDbCommand cmd = new OleDbCommand(Str, Conn);

            cmd.ExecuteNonQuery();

            CloseConn();

        }

        /*
         Method name: Delete
         Author: Mohammad Rahman
         Description: Execute Insert Query to database 
       */

        public void Delete(BusinessTire Prod)
        {
            String Str = BuildDeleteQuery(Prod);
            OpenConn();

            OleDbCommand cmd = new OleDbCommand(Str, Conn);

            cmd.ExecuteNonQuery();

            CloseConn();
        }


        /*
        Method name: BuildAddQuery
        Author: Mohammad Rahman
        Description: Prepare to insert query

      */
        private String BuildAddQuery(BusinessTire Prod)
        {
            try
            {
                strTable = "Insert into " + thisTable;
                strFields = " (" + product_id +
                    "," + description +
                    "," + price +
                    "," + quantity +
                    "," + markUp + ")";
                strValues = " Values ( '" + Prod.ProductId +
                             "' , '" + Prod.Description +
                             "' , '" + Prod.Price +
                             "' , '" + Prod.Quantity +
                             "' , '" + Prod.MarkUp + "' )";

                insertStr = strTable + strFields + strValues;

                return insertStr;
            }
            catch (Exception ex)
            {
                throw;
            }

        }

        /*
        Method name: BuildDeleteQuery
        Author: Mohammad Rahman
        Description: Prepare to delete query
      */
        private String BuildDeleteQuery(BusinessTire Prod)
        {
            strTable = "Delete From " + thisTable;
            strFields = " Where (" + product_id +
                "=" + Prod.ProductId + ")";


            insertStr = strTable + strFields;

            return insertStr;
        }
        /*
        Method name: Search
        Author: Mohammad Rahman
        Description: Perform searching in database
        */

        public void Search(BusinessTire Product)
        {
            string connectionString = null;
            OleDbConnection OledbCnn;
            OleDbCommand oledbCmd;
            string sql = null;

            connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;" +
                               "Data Source = Product.accdb";
            sql = "Select * from Product where Product_ID = " + Product.ProductId;

            OledbCnn = new OleDbConnection(connectionString);
            OledbCnn.Open();

            oledbCmd = new OleDbCommand(sql, OledbCnn);

            OleDbDataReader OledbReader = oledbCmd.ExecuteReader();

            while (OledbReader.Read())
            {
                Product.Description = OledbReader.GetValue(1).ToString();
                Product.Price = OledbReader.GetValue(2).ToString();
                Product.Quantity = OledbReader.GetValue(3).ToString();
                Product.MarkUp = OledbReader.GetValue(4).ToString();
            }

            OledbReader.Close();
            oledbCmd.Dispose();
            OledbCnn.Close();

        }


        /*
        Method name: LoadsProdId
        Author: Mohammad Rahman
        Description: Loads all the product ids from the database 
      */
        public List<string> LoadsProdId(BusinessTire product)
        {
            string connectionString = null;
            OleDbConnection OledbCnn;
            OleDbCommand oledbCmd;
            string sql = null;

            connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;" +
                               "Data Source = Product.accdb";

            sql = "Select * from Product";

            List<string> productIds = new List<string>();

            OledbCnn = new OleDbConnection(connectionString);
            OledbCnn.Open();

            oledbCmd = new OleDbCommand(sql, OledbCnn);

            OleDbDataReader OledbReader = oledbCmd.ExecuteReader();

            while (OledbReader.Read())
            {
                productIds.Add(OledbReader.GetValue(0).ToString());
            }

            OledbReader.Close();
            oledbCmd.Dispose();
            OledbCnn.Close();

            return productIds;
        }
    }
}
