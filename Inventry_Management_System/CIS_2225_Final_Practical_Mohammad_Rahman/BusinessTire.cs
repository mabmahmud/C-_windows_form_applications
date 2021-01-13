using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS_2225_Final_Practical_Mohammad_Rahman
{
   public class BusinessTire
    {

        //Declaring Properties
        public string ProductId { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
        public string Quantity { get; set; }
        public string MarkUp { get; set; }


        private DataAccessTire prodData;
        public BusinessTire()
        {
            prodData = new DataAccessTire();
        }

        /*
        Method name: Add
        Author: Mohammad Rahman
        Description: Adding product object 
      */
        public void Add()
        {
            prodData.Add(this);
        }

        /*
        Method name: Delete
        Author: Mohammad Rahman
        Description: Deleting product object 
      */

        public void Delete()
        {
            prodData.Delete(this);
        }

        /*
        Method name: Search
        Author: Mohammad Rahman
        Description: Searching product object 
      */
        public void Search()
        {
            //prodData = new DataLayer();
            prodData.Search(this);
        }

        /*
        Method name: LoadProdIds
        Author: Mohammad Rahman
        Description: Loading all product ids
      */

        public List<string> LoadProdIds()
        {
            List<string> prodIds = new List<string>();
            prodIds = prodData.LoadsProdId(this);
            return prodIds;
        }
    }
}
