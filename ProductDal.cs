using System;
using System.Collections.Generic;
using System.Text;

using System.Data;

namespace AdoNetDemo
{
    public class ProductDal
    {
        public DataTable GetAll()
        {
            SqlConnection connections = new SqlConnection("server=(localdb)\mssqllocaldb;inittal catalog=ETrade;integrated securutiy=true");
            if (connections.State==ConnectionState.Closed)
            {
                connections.Open();    
            }
            SqlCommand command = new SqlCommand("Select * from Products",connections);

            SqlDataReader reader=command.ExecuteReader();
            DataTable datatable = new DataTable();
            dataTable.Load(reader);

        }
    }
}
