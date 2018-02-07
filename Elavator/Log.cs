/// <summary>
/// Sutharshan kumaravel
/// 1404884
/// Assignment 1: Control an Elevator - A C# Project
/// 10th December 2015 
/// <summary>

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Elavator
{
    public partial class Log : Form
    {
        OleDbConnection connection;  // Delcared the OleDbConnection class and String data type
        public Log()
        {
            InitializeComponent();// this calls the InitializeComponent() method from partial class of the Log
        }
        //
        // This Event Handler is for the form which call 'show data' method.
        //
        public void Log_Load(object sender, EventArgs e)
        {
            showdata(); //calls the showdata method
        }
        //
        // This is method which load the database connection and show the table on datagridview component.
        //
        public void showdata()
        {
            try
            {
                connection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source= Elevator Log.mdb");  // created the new instance of the OleDbConnection
                connection.Open(); // opens the data connection
                DataSet dSet = new DataSet();// created the new instance of the Dataset which is container to carry the table 
                OleDbDataAdapter adapter = new OleDbDataAdapter("Select * from Log", connection); // created the new instance of the OleDbDataAdapter
                adapter.Fill(dSet, "Log"); //It fill the dataset with log table which is collected from the Elevator Log.mdb
                LogData.DataSource = dSet.Tables["Log"];
                connection.Close();// closes the data connection


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex); // It show the expection on message box.
            }
        }
        }
    }

