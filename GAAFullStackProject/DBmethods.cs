using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;


namespace GAAFullStackProject
{
    class DBmethods
    {

    //insert player
        internal void insertPlayer(SqlConnection connection, SqlDataReader reader, Player p)
                                    //pass in connection, reader, player
        {
            try//encompass within a try/catch/finally block
            {
                connection.Open();//open connection to db

                //get parameters
                    String name = p.Name;
                    int height = p.Height;
                    int age = p.Age;

                //instantiate new sql command which takes a statement and a connection as parameters
                //pass the variable parameters into sql statement
                    SqlCommand command = new SqlCommand("INSERT INTO Player (Name, Height, Age) VALUES "
                        +"(@name, @height, @age)", connection);

                //two different ways of setting the parameter values
                    command.Parameters.Add("@name", SqlDbType.Text);
                    command.Parameters["@name"].Value = name;//the proper way
                    command.Parameters.AddWithValue("@height", height);
                    command.Parameters.AddWithValue("@age", age);//shortcut
  
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
                    string delete = @"DELETE FROM Player WHERE PlayerID = @id";
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
        internal void viewPlayers(SqlConnection connection, SqlDataReader reader)
                                    //pass in connection and reader
        {
            try
            {
                connection.Open();//open connection to db

                //new command
                SqlCommand command = new SqlCommand("SELECT * FROM Player", connection);
                
                Console.WriteLine("P ID\tName\t\tAge\tHeight\tDistance\tSpeed\n");//formatting heading for output
                
                reader = command.ExecuteReader();//excecute query as reader (reads from database)

                while (reader.Read())//while there is still data to read, write to console
                {

                    Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t\t{5}", reader[0], reader[1], reader[2], reader[3], reader[4], reader[5]);
                }

            }
            catch {  }
            
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

    //used to list players id and name for user selection
        internal void playersListIDName(SqlConnection connection, SqlDataReader reader)
                                        //pass in connection and reader
        {
             try
            {
                connection.Open();//open connection to db

                //select players id and name
                SqlCommand command = new SqlCommand("SELECT PlayerID, Name FROM Player", connection);
                
                 Console.WriteLine("PLayer ID\tName");//formatting heading for output
                
                 reader = command.ExecuteReader();//excecute the reader

                while (reader.Read())
                {
                    Console.WriteLine("{0}\t\t{1}", reader[0], reader[1]);//output
                }

            }
            catch {  }
            
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
        internal void updateHeight(SqlConnection connection,SqlDataReader reader,int player, int h)
                                    //pass in connection, reader, player id, height
        {
 	           try
            {
                connection.Open();

                //set variables
                    int id = player;
                    int height = h;
                
                //set sql string
                    string insert = @"UPDATE Player SET Height = @height WHERE PlayerID = @player";
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
                string insert = @"UPDATE Player SET Age = @age WHERE PlayerID = @player";
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
        internal void updateDistance(SqlConnection connection,SqlDataReader reader,int player,int d)
                                //pass in connection, reader, player id, age
        {
        	try
            {
                connection.Open();

                //set variables
                    int id = player;
                    int distance = d;
                
                //set string
                    string insert = @"UPDATE Player SET RunningDistance = @distance WHERE PlayerID = @player";
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
                string insert = @"UPDATE Player SET MaxSpeed = @speed WHERE PlayerID = @player";
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


    
        internal int returnCalculation(SqlConnection connection, SqlDataReader reader, string stat, string type)
        //pass in connection and reader
        {
            int result = 0;
            try
            {
                connection.Open();//open connection to db

                string statistic = stat;
                string calculation = type;

                string query = "SELECT @calc(@stat) FROM Player";

                SqlCommand cmd = new SqlCommand(query, connection);
                
                cmd.Parameters.Add("@calc", SqlDbType.VarChar);
                cmd.Parameters["@calc"].Value = calculation;

                //cmd.Parameters.Add("@stat", SqlDbType.VarChar);
                //cmd.Parameters["@stat"].Value = statistic;
                
                cmd.Parameters.AddWithValue("@stat", statistic);

                //reader = cmd.ExecuteScalar();

                result = (int) cmd.ExecuteScalar();

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
            return (int) result;
        }



    }//end class
}//end namespace

