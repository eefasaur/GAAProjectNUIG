using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAAFormGui
{
    public class DBmethod
    {

        //insert player
        internal void insertPlayer(SqlConnection connection, SqlDataReader reader, Player p)
        //pass in connection, reader, player
        {
            try//encompass within a try/catch/finally block
            {
                connection.Open();//open connection to db

                //get parameters
                string name = p.Name;
                int height = p.Height;
                int age = p.Age;
                int distance = p.Distance;
                double speed = p.Speed;

                //instantiate new sql command which takes a statement and a connection as parameters
                //pass the variable parameters into sql statement
                SqlCommand command = new SqlCommand("INSERT INTO PlayerData (Name, Age, Height, RunningDistance, MaxiumumSpeed) VALUES "
                    + "(@name, @age, @height, @distance, @speed)", connection);

                //two different ways of setting the parameter values
                //command.Parameters.Add("@name", SqlDbType.Text);
                //command.Parameters["@name"].Value = name;//the proper way
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@age", age);//shortcut
                command.Parameters.AddWithValue("@height", height);
                command.Parameters.AddWithValue("@distance", distance);
                command.Parameters.AddWithValue("@speed", speed);

                command.ExecuteNonQuery();//excecutes the query

            }
            catch { }//catch exceptions - not currently set for any
            
            finally//encompasses the code to fully close the connection
            {
                if (reader != null)//if there is a reader that is open - close it
                {
                    reader.Close();
                }
                if (connection != null)//if there is a connection that is open - close it
                {
                    connection.Close();
                }
            }



        }


        //delete player
        internal void deletePlayer(SqlConnection connection, SqlDataReader reader, int id)
        //pass in connection, reader, id (from user input)
        {
            try
            {
                connection.Open();

                //create sql statement as a string
                string delete = @"DELETE FROM PlayerData WHERE PlayerID = @id";
                //pass string and connection into sql command instance
                SqlCommand deleteCommand = new SqlCommand(delete, connection);

                deleteCommand.Parameters.AddWithValue("@id", id);//set the parameter value

                deleteCommand.ExecuteNonQuery();//excecute the query
            }
            catch { }
            
            finally//encompasses the code to fully close the connection
            {
                if (reader != null)//if there is a reader that is open - close it
                {
                    reader.Close();
                }
                if (connection != null)//if there is a connection that is open - close it
                {
                    connection.Close();
                }
            }
        }


        //view players
        internal DataSet viewPlayers(SqlConnection connection, SqlDataReader reader)
        //pass in connection and reader
        {
            //http://stackoverflow.com/questions/18113278/populate-a-datagridview-with-sql-query-results

            try
            {
                connection.Open();//open connection to db

                //new command
                //SqlCommand command = new SqlCommand("SELECT * FROM Player", connection);
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT Name, Age, Height, RunningDistance, MaxiumumSpeed FROM PlayerData", connection);
                SqlCommandBuilder command = new SqlCommandBuilder(adapter);

                DataSet ds = new DataSet();
                adapter.Fill(ds);

                return ds;


            }
            catch 
            {
                
            }
            
            finally//encompasses the code to fully close the connection
            {
                if (reader != null)//if there is a reader that is open - close it
                {
                    reader.Close();
                }
                if (connection != null)//if there is a connection that is open - close it
                {
                    connection.Close();
                }
            }

            return null;
        }

        //used to list players id and name for user selection
        internal void playersListIDName(SqlConnection connection, SqlDataReader reader)
        //pass in connection and reader
        {
            try
            {
                connection.Open();//open connection to db

                //select players id and name
                SqlCommand command = new SqlCommand("SELECT PlayerID, Name FROM PlayerData", connection);

                Console.WriteLine("PLayer ID\tName");//formatting heading for output

                reader = command.ExecuteReader();//excecute the reader

                while (reader.Read())
                {
                    Console.WriteLine("{0}\t\t{1}", reader[0], reader[1]);//output
                }

            }
            catch { }
            
            finally//encompasses the code to fully close the connection
            {
                if (reader != null)//if there is a reader that is open - close it
                {
                    reader.Close();
                }
                if (connection != null)//if there is a connection that is open - close it
                {
                    connection.Close();
                }
            }
        }


        //update height
        internal void updateHeight(SqlConnection connection, SqlDataReader reader, int player, int h)
        //pass in connection, reader, player id, height
        {
            try
            {
                connection.Open();

                //set variables
                int id = player;
                int height = h;

                //set sql string
                string insert = @"UPDATE PlayerData SET Height = @height WHERE PlayerID = @player";
                //new command
                SqlCommand insertCommand = new SqlCommand(insert, connection);

                //set values
                insertCommand.Parameters.AddWithValue("@player", id);
                insertCommand.Parameters.AddWithValue("@height", height);

                insertCommand.ExecuteNonQuery();//excecute query


            }
            catch { }
            
           finally//encompasses the code to fully close the connection
            {
                if (reader != null)//if there is a reader that is open - close it
                {
                    reader.Close();
                }
                if (connection != null)//if there is a connection that is open - close it
                {
                    connection.Close();
                }
            }
        }


        //update age
        internal void updateAge(SqlConnection connection, SqlDataReader reader, int player, int a)
        //pass in connection, reader, player id, age
        {
            try
            {
                connection.Open();

                //set variables
                int id = player;
                int age = a;

                //set string
                string insert = @"UPDATE PlayerData SET Age = @age WHERE PlayerID = @player";
                //new connection
                SqlCommand insertCommand = new SqlCommand(insert, connection);

                //set values
                insertCommand.Parameters.AddWithValue("@player", id);
                insertCommand.Parameters.AddWithValue("@age", age);

                insertCommand.ExecuteNonQuery();//execute query


            }
            catch { }
            finally//encompasses the code to fully close the connection
            {
                if (reader != null)//if there is a reader that is open - close it
                {
                    reader.Close();
                }
                if (connection != null)//if there is a connection that is open - close it
                {
                    connection.Close();
                }
            }
        }


        //update distance
        internal void updateDistance(SqlConnection connection, SqlDataReader reader, int player, int d)
        //pass in connection, reader, player id, age
        {
            try
            {
                connection.Open();

                //set variables
                int id = player;
                int distance = d;

                //set string
                string insert = @"UPDATE PlayerData SET RunningDistance = @distance WHERE PlayerID = @player";
                //new connection
                SqlCommand insertCommand = new SqlCommand(insert, connection);

                //set values
                insertCommand.Parameters.AddWithValue("@player", id);
                insertCommand.Parameters.AddWithValue("@distance", d);

                insertCommand.ExecuteNonQuery();//execute query


            }
            catch { }
            finally//encompasses the code to fully close the connection
            {
                if (reader != null)//if there is a reader that is open - close it
                {
                    reader.Close();
                }
                if (connection != null)//if there is a connection that is open - close it
                {
                    connection.Close();
                }
            }
        }


        //update speed
        internal void updateSpeed(SqlConnection connection, SqlDataReader reader, int player, double s)
        //pass in connection, reader, player id, age
        {
            try
            {
                connection.Open();

                //set variables
                int id = player;
                double speed = s;

                //set string
                string insert = @"UPDATE PlayerData SET MaxSpeed = @speed WHERE PlayerID = @player";
                //new connection
                SqlCommand insertCommand = new SqlCommand(insert, connection);

                //set values
                insertCommand.Parameters.AddWithValue("@player", id);
                insertCommand.Parameters.AddWithValue("@speed", s);

                insertCommand.ExecuteNonQuery();//execute query


            }
            catch { }
            finally//encompasses the code to fully close the connection
            {
                if (reader != null)//if there is a reader that is open - close it
                {
                    reader.Close();
                }
                if (connection != null)//if there is a connection that is open - close it
                {
                    connection.Close();
                }
            }
        }



        //List<double>
        internal void arrayTest(SqlConnection connection, SqlDataReader reader)
        //pass in connection, reader, player id, age
        {
            //List<double> test = new List<double>(); ;

            try
            {
                connection.Open();


                string query = @"SELECT Age FROM PlayerData";
                SqlCommand arrayTest = new SqlCommand(query, connection);

                reader = arrayTest.ExecuteReader();
                while (reader.Read())
                {
                    //test.Add(reader.GetDouble(0));
                    Console.WriteLine(reader[0]);
                }

                //return test.ToList();

            }
            catch { }
            finally//encompasses the code to fully close the connection
            {
                if (reader != null)//if there is a reader that is open - close it
                {
                    reader.Close();
                }
                if (connection != null)//if there is a connection that is open - close it
                {
                    connection.Close();
                }
            }

            //return test;
        }




        public List<double> returnArray(SqlConnection connection, SqlDataReader reader, int column)
        //pass in connection, reader, which statistic you want to measure
        {
            //initialise string
            string query = null;

            //use if else to make a decision on which stat to return from db
            //cant pass a column name as a parameter using @
            if (column == 1)
            {
                query = @"SELECT Age FROM PlayerData";
            }
            else if (column == 2)
            {
                query = @"SELECT Height FROM PlayerData";
            }
            else if (column == 3)
            {
                query = @"SELECT RunningDistance FROM PlayerData";
            }
            else if (column == 4)
            {
                query = @"SELECT MaxSpeed FROM PlayerData";
            }


            List<double> test = new List<double>();

            try
            {
                connection.Open();

                SqlCommand arrayTest = new SqlCommand(query, connection);

                reader = arrayTest.ExecuteReader();
                while (reader.Read())
                {
                    //the data stored in the speed column is type decimal
                    if (column == 4)
                    {
                        //cast values to double 
                        double x = (double)reader.GetDecimal(0);
                        test.Add(x);
                    }
                    else
                    {
                        //all other values stored as int
                        //cast values to double
                        double x = (double)reader.GetInt32(0);
                        test.Add(x);
                    }

                }

                return test;

            }
            catch { }
            finally//now fully close the connection
            {
                if (reader != null)//if there is a reader that is open - close it
                {
                    reader.Close();
                }
                if (connection != null)//if there is a connection that is open - close it
                {
                    connection.Close();
                }
            }

            return test;
        }


    }//end class
}
