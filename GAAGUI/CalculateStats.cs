using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace GAAFullStackProject
{
    public class CalculateStats
    {
        
        public double Max(List<double> numbers)
        {
            int n = numbers.Count - 1;
            numbers.Sort();
            return numbers[n];

        }

        public double Min(List<double> numbers)
        {
            numbers.Sort();
            return numbers[0];

         }

        public double Mean(List<double> numbers)
        {
            double total = numbers.Sum();
            int n = numbers.Count();
            return total / n;

        }

    }
}

/* //decision to handle them all as doubles allows for use of delegate method

        public delegate double Calculate(List<double> numbers);
                
            public double Mean(List<double> numbers)
            {
                double total = numbers.Sum();
                int n = numbers.Count();
                return total / n;
                
                //Console.WriteLine("Mean: {0}.", total / n);
            }

            public double Max(List<double> numbers)
            {
                numbers.Sort();
                return numbers.IndexOf(0);

                //Console.WriteLine("Max: {0}.", numbers.IndexOf(0));
            }

            public double Min(List<double> numbers)
            {
                int n = numbers.Count - 1;
                numbers.Sort();
                return numbers.IndexOf(n);
                
                //Console.WriteLine("Min: {0}.", numbers.IndexOf(n));
            }
 * 
 * 
 * 
 * 
 * public int returnMaxAge(SqlConnection connection)
        //pass in connection and reader
        {
            int result = 0;

            try
            {
                connection.Open();//open connection to db
                string query = "SELECT MAX(Age) FROM Player";
                SqlCommand cmd = new SqlCommand(query, connection);
                return result = (int)cmd.ExecuteScalar();

            }
            catch { }
            finally//encompasses the code to fully close the connection
            {
                if (connection != null)//if there is a connection that is open - close it
                {
                    connection.Close();
                }
            }

            return result;
        }

        public int returnMinAge(SqlConnection connection)
        //pass in connection and reader
        {
            int result = 0;

            try
            {
                connection.Open();//open connection to db
                string query = "SELECT MIN(Age) FROM Player";
                SqlCommand cmd = new SqlCommand(query, connection);
                return result = (int)cmd.ExecuteScalar();

            }
            catch { }
            finally//encompasses the code to fully close the connection
            {
                if (connection != null)//if there is a connection that is open - close it
                {
                    connection.Close();
                }
            }

            return result;
        }


        public double returnMeanAge(SqlConnection connection)
        //pass in connection and reader
        {
            double result = 0;

            try
            {
                connection.Open();//open connection to db
                string query = "SELECT AVG(Age) FROM Player";
                SqlCommand cmd = new SqlCommand(query, connection);
                return result = (double)cmd.ExecuteScalar();

            }
            catch { }
            finally//encompasses the code to fully close the connection
            {
                if (connection != null)//if there is a connection that is open - close it
                {
                    connection.Close();
                }
            }

            return result;
        }


        public int returnMaxHeight(SqlConnection connection)
        //pass in connection and reader
        {
            int result = 0;

            try
            {
                connection.Open();//open connection to db
                string query = "SELECT MAX(Height) FROM Player";
                SqlCommand cmd = new SqlCommand(query, connection);
                return result = (int)cmd.ExecuteScalar();

            }
            catch { }
            finally//encompasses the code to fully close the connection
            {
                if (connection != null)//if there is a connection that is open - close it
                {
                    connection.Close();
                }
            }

            return result;
        }

        public int returnMinHeight(SqlConnection connection)
        //pass in connection and reader
        {
            int result = 0;

            try
            {
                connection.Open();//open connection to db
                string query = "SELECT MIN(Height) FROM Player";
                SqlCommand cmd = new SqlCommand(query, connection);
                return result = (int)cmd.ExecuteScalar();

            }
            catch { }
            finally//encompasses the code to fully close the connection
            {
                if (connection != null)//if there is a connection that is open - close it
                {
                    connection.Close();
                }
            }

            return result;
        }

        public double returnMeanHeight(SqlConnection connection)
        //pass in connection and reader
        {
            double result = 0;

            try
            {
                connection.Open();//open connection to db
                string query = "SELECT AVG(Height) FROM Player";
                SqlCommand cmd = new SqlCommand(query, connection);
                return result = (double)cmd.ExecuteScalar();

            }
            catch { }
            finally//encompasses the code to fully close the connection
            {
                if (connection != null)//if there is a connection that is open - close it
                {
                    connection.Close();
                }
            }

            return result;
        }

        public int returnMaxRunningDistance(SqlConnection connection)
        //pass in connection and reader
        {
            int result = 0;

            try
            {
                connection.Open();//open connection to db
                string query = "SELECT MAX(RunningDistance) FROM Player";
                SqlCommand cmd = new SqlCommand(query, connection);
                return result = (int)cmd.ExecuteScalar();

            }
            catch { }
            finally//encompasses the code to fully close the connection
            {
                if (connection != null)//if there is a connection that is open - close it
                {
                    connection.Close();
                }
            }

            return result;
        }

        public int returnMinRunningDistance(SqlConnection connection)
        //pass in connection and reader
        {
            int result = 0;

            try
            {
                connection.Open();//open connection to db
                string query = "SELECT MIN(RunningDistance) FROM Player";
                SqlCommand cmd = new SqlCommand(query, connection);
                return result = (int)cmd.ExecuteScalar();

            }
            catch { }
            finally//encompasses the code to fully close the connection
            {
                if (connection != null)//if there is a connection that is open - close it
                {
                    connection.Close();
                }
            }

            return result;
        }

        public double returnMeanRunningDistance(SqlConnection connection)
        //pass in connection and reader
        {
            double result = 0;

            try
            {
                connection.Open();//open connection to db
                string query = "SELECT AVG(RunningDistance) FROM Player";
                SqlCommand cmd = new SqlCommand(query, connection);
                return result = (double)cmd.ExecuteScalar();

            }
            catch { }
            finally//encompasses the code to fully close the connection
            {
                if (connection != null)//if there is a connection that is open - close it
                {
                    connection.Close();
                }
            }

            return result;
        }


        public double returnMaxSpeed(SqlConnection connection)
        //pass in connection and reader
        {
            double result = 0;

            try
            {
                connection.Open();//open connection to db
                string query = "SELECT MAX(MaxSpeed) FROM Player";
                SqlCommand cmd = new SqlCommand(query, connection);
                return result = (double)cmd.ExecuteScalar();

            }
            catch { }
            finally//encompasses the code to fully close the connection
            {
                if (connection != null)//if there is a connection that is open - close it
                {
                    connection.Close();
                }
            }

            return result;
        }


        public double returnMinSpeed(SqlConnection connection)
        //pass in connection and reader
        {
            double result = 0;

            try
            {
                connection.Open();//open connection to db
                string query = "SELECT MIN(MaxSpeed) FROM Player";
                SqlCommand cmd = new SqlCommand(query, connection);
                return result = (double)cmd.ExecuteScalar();

            }
            catch { }
            finally//encompasses the code to fully close the connection
            {
                if (connection != null)//if there is a connection that is open - close it
                {
                    connection.Close();
                }
            }

            return result;
        }

        public double returnMeanSpeed(SqlConnection connection)
        //pass in connection and reader
        {
            double result = 0;

            try
            {
                connection.Open();//open connection to db
                string query = "SELECT AVG(MaxSpeed) FROM Player";
                SqlCommand cmd = new SqlCommand(query, connection);
                return result = (double)cmd.ExecuteScalar();

            }
            catch { }
            finally//encompasses the code to fully close the connection
            {
                if (connection != null)//if there is a connection that is open - close it
                {
                    connection.Close();
                }
            }

            return result;
        }


*/
