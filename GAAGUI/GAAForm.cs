using GAAFormGui.PlayerDataTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GAAFormGui
{
    public partial class GAAGUI : Form
    {
        //create instance of DBMethod
        DBmethod db = new DBmethod();

        //set connection in a string
        static string connString = "Server=lugh4.it.nuigalway.ie; database=msdb2355; uid=msdb2355A";

        //instantiate a new connection - pass in string
        SqlConnection connection = new SqlConnection(connString);

        //set a new data reader to null - may not be used
        SqlDataReader reader = null;

        public GAAGUI()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //causing problem on load
            // TODO: This line of code loads data into the 'playerDataTable.PlayerData' table. You can move, or remove it, as needed.
            //this.playerDataTableAdapter.Fill(this.playerDataTable.PlayerData);
            

        }

        /// <summary>
        /// changed from DBMethods using SqlDataAdapter & SqlCommandBuilder instead of SqlCommand
        /// removed the Console.WriteLine
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            DataSet ds = db.viewPlayers(connection, reader);


            ViewPlayers.ReadOnly = true;
            ViewPlayers.DataSource = ds.Tables[0];

            
        }


        private void ViewPlayers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// this should update the database with whatever parameters are inputted 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {

            Player p = new Player();

            p.Name = (string)nameTextBox.Text;
            p.Age = Convert.ToInt32(ageTextBox.Text);
            p.Height = Convert.ToInt32(heightTextBox.Text);
            p.Distance = Convert.ToInt32(runningDistanceTextBox.Text);
            p.Speed = Convert.ToDouble(maxSpeedTextBox.Text);

            try
            {
                db.insertPlayer(connection, reader, p);

                MessageBox.Show("Update Successful");
            }catch(Exception ex){
                MessageBox.Show("Error: " + ex);
            }


        }

        private void button5_Click_1(object sender, EventArgs e)
        {

            DataSet set = db.viewPlayers(connection, reader);

      
        }
    }
}
