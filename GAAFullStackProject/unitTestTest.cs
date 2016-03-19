using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using System.Data.SqlClient;

namespace GAAFullStackProject
{
    [TestFixture]
    public class unitTestTest
    {
        //string connString = "Server=lugh4.it.nuigalway.ie; database=msdb2355; uid=msdb2355";
        //SqlConnection connection = new SqlConnection(connString);
        //SqlDataReader reader = null;//set as null

        [Test]
        public void testMaxAge()
        {
            //instantiate the return type
            int result = 0;
            
            //set up connection
            string connString = "Server=lugh4.it.nuigalway.ie; database=msdb2355; uid=msdb2355";
            SqlConnection connection = new SqlConnection(connString);

            //open connection
            connection.Open();

            string query = "SELECT MAX(Age) FROM Player";

            SqlCommand command = new SqlCommand(query, connection);

            result = (int)command.ExecuteScalar();

            int expected = 25;
            int actual = result;

            Assert.AreEqual(expected, actual);

            //close connection
            connection.Close();


        }

    }
}
