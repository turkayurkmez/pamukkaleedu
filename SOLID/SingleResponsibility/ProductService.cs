using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility
{
   public class ProductService
    {

        private string connectionString;
        public ProductService()
        {
            //DRY:
            connectionString = @"Data Source=(localdb)\Mssqllocaldb;Initial Catalog=miniDatabase;Integrated Security=True";
        }
        public int AddProduct(string name, double price)
        {        

            string commandText = "INSERT into Products (Name, Price, CreatedDate) values (@name,@price,GETDATE())";

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@name", name);
            parameters.Add("@price", price);

            DbHelper dbHelper = new DbHelper(connectionString);
            int result = dbHelper.ExecuteCommand(commandText, parameters);

            return result;
          
        }
    }
}
