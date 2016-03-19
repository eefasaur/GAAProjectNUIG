using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace GAAFullStackProject
{
    class Program
    {
        static void Main(string[] args)
        {



            //new instance of the methods class
                DBmethods dbm = new DBmethods();
            
            //set connection in a string
                string connString = "Server=lugh4.it.nuigalway.ie; database=msdb2355; uid=msdb2355A";
            
            //instantiate a new connection - pass in string
                SqlConnection connection = new SqlConnection(connString);
            
            //set a new data reader to null - may not be used
                SqlDataReader reader = null;

            //ask user what would they like to do with database today
            //options add, delete, update, view player(s)
                Console.Write("What would you like to do?\n1. Add a player\n2. Delete a player\n3."
                + "Update a player\n4. View all players\n5. Calculate Stats\n6.Exit\nEnter number: ");
            
            int choice = Convert.ToInt32(Console.ReadLine());
                
            //used switch statement to handle choice
            //no real benefit over an if else with only 4 options...just a bit tidier to write
            //take in user input as choice
                switch(choice)
                {
                    case 1://add player

                        Console.Write("How many players would you like to add? ");
                        int qty = Convert.ToInt32(Console.ReadLine());

                        for (int i = 0; i < qty; i++)
                        {
                            Player p = new Player();//new instance of player

                            Console.Write("Name: ");
                            p.Name = Console.ReadLine();//set name
                            
                            Console.Write("Age: ");
                            p.Age = Convert.ToInt32(Console.ReadLine());//set age
                            
                            Console.Write("Height: ");
                            p.Height = Convert.ToInt32(Console.ReadLine());//set height
                            
                            //pass all variables to the method in DBmethod class
                                dbm.insertPlayer(connection, reader, p);
                        }

                        break;

                    case 2://delete player
                        dbm.playersListIDName(connection, reader);//get list of players and ids from db

                        Console.Write("Select a player to delete.\nEnter number: ");
                        int delID = Convert.ToInt32(Console.ReadLine());

                        //pass in variables including player id to be deleted
                            dbm.deletePlayer(connection, reader, delID);
                        
                            break;

                    case 3://update player
                        
                        dbm.playersListIDName(connection, reader);//get list of players and ids from db
                    
                        Console.Write("Select a player to update.\nEnter number: ");
                        int player = Convert.ToInt32(Console.ReadLine());
                        
                        Console.Write("What would you like to update?\n1. Height\n2. Age\n3. Running Distance\n4. Max Speed\nEnter number: ");
                        int detail = Convert.ToInt32(Console.ReadLine());

                        //depending on user input a different update method will be called
                            if (detail == 1)//height update
                            {
                                Console.WriteLine("Please enter new height: ");
                                int h = Convert.ToInt32(Console.ReadLine());
                                
                                //pass connection, reader, id and new height into method
                                    dbm.updateHeight(connection, reader, player, h);
                            }
                            else if (detail == 2)//age update
                            {
                                Console.WriteLine("Please enter new age: ");
                                int a = Convert.ToInt32(Console.ReadLine());
                                
                                //pass connection, reader, id and new age into method
                                    dbm.updateAge(connection, reader, player, a);
                            }
                            else if (detail == 3)//distance update
                            {
                                Console.WriteLine("Please enter new running distance: ");
                                int d = Convert.ToInt32(Console.ReadLine());

                                //pass connection, reader, id and new age into method
                                dbm.updateDistance(connection, reader, player, d);
                            }
                            else  //(detail == 4)//speed update
                            {
                                Console.WriteLine("Please enter new maximum speed: ");
                                double s = Double.Parse(Console.ReadLine());

                                //pass connection, reader, id and new age into method
                                dbm.updateSpeed(connection, reader, player, s);
                            }

                        break;

                    case 4://view players
                        dbm.viewPlayers(connection, reader);//nice and simple ;)
                        break;

                    case 5://calulate stats
                        string stat, calc;
                        Console.Write("What column would you like to calculate?\n1. Age\n2. Height\n3. Running Distance\n4. Max Speed\nEnter number: ");
                        int col = Convert.ToInt32(Console.ReadLine());

                        if (col == 1)
                        {
                            stat = "Age";
                            //dbm.returnCalculation(connection, reader, "Age");
                            //Console.Write(dbm.returnCalculation(connection, reader, "Age"));

                        }
                        else if (col == 2)
                        {
                            stat = "Height";
                            //dbm.returnCalculation(connection, reader, "Height");
                            //Console.Write(dbm.returnArray(connection, reader, "Height").ToList());
                        }
                        else if (col == 3)
                        {
                            stat = "RunningDistance";
                            //dbm.returnCalculation(connection, reader, "RunningDistance");
                            //Console.Write(dbm.returnArray(connection, reader, "RunningDistance").ToList());
                        }
                        else //(stat == 1.4)
                        {
                            stat = "MaxSpeed";
                            //dbm.returnCalculation(connection, reader, "MaxSpeed");
                            //Console.Write(dbm.returnArray(connection, reader, "MaxSpeed").ToList());
                        }

                        Console.Write("What would you like returned\n1. Max\n2. Min\n3. Mean\nEnter number: ");
                        int type = Convert.ToInt32(Console.ReadLine());

                        if (type == 1)
                        {
                            calc = "MAX";
                        }
                        else if (type == 2)
                        {
                            calc = "MIN";
                        }
                        else //(type ==3)
                        {
                            calc = "MEAN";
                        }
                            
                        dbm.returnCalculation(connection, reader, stat, calc);

                        break;

                    case 6:
                        Console.Write("Press any key to Exit....");
                        break;
                }//end switch


            Console.ReadKey();

        }
    }
}

