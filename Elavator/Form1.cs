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
using System.Threading;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Elavator
{
    public partial class Lift : Form
    {// The boolean data type are defined
        bool drOpen = true; 
        bool drClose = true;
        bool close = false;
        bool lightOn = false;
        bool button;
        bool hide;
        // Delcared the OleDbConnection class and String data type
        OleDbConnection connection;
        String Sqlcommand;

        public Lift()
        {
            InitializeComponent();
        }
        //
        // This method is created to open the Database connection
        //
        public void Connection()
        { // Using the try and catch methods to create the data  connection 
            try
            {
                connection.Open(); // opens the data connection
                OleDbCommand com = new OleDbCommand(); // created the new instance of the OleDbCommand 
                com.Connection = connection; 
                com.CommandText = Sqlcommand;
                com.ExecuteNonQuery(); // it is used to execute the INSERT SQL query.
                connection.Close(); // closes the data connection
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex); // It show the expection on message box.
            }

        }
        //
        // This is Event Handler for the '1'  button which is inside the control panel.
        //
        private void Floor1_Click(object sender, EventArgs e)
        {
                button = true;
                drClose = true; // 'drClose' is assigned as true
                lightOn = true;
            close = false;
                CloseDoor.Start(); // It will call the CloseDoor Event Handler.
            
        }
        //
        // This is Event Handler for the 'G'  button which is inside the control panel.
        //
        private void Floor0_Click(object sender, EventArgs e)
        {
                button = true;
                drClose = false;
                lightOn = true;
                close= false;
                CloseDoor.Start();// It will call the CloseDoor Event Handler.
            
        }
        //
        // This is Event Handler for the request button which is located in the first floor.
        //
        private void down_Click(object sender, EventArgs e)
        {// If the vertical location of the Elevator is equal to y = 95, the 'OpenDoor' timer will start. Otherwise, 'CloseDoor' timer will start.
            if (Elevator.Top == 95)
            {
                drOpen = true;
                // This insert command will be saved into string data type (Sqlcommand).
                // Afterwards, it will call the connection method to execute the 'Sqlcommand' which is stored in the data type.
                Sqlcommand = "INSERT INTO Log ( [Action], [Date] ) values ('Door is opening in first Floor', ' " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "')";
                 
                Connection();
                OpenDoor.Start();// It will call the 'OpenDoor' Event Handler.
            }
            else
            {
                    drClose = true;
                    button = false;
                    close = false;
                    lightOn = false;
                // This insert command will be saved into string data type (Sqlcommand).
                // Afterwards, it will call the connection method to execute the 'Sqlcommand' which is stored in the data type.
                Sqlcommand = "INSERT INTO Log ( [Action], [Date] ) values ('Door is closing in first Floor', ' " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "')";

                Connection();
                
                CloseDoor.Start();// The 'CloseDoor' timer will start therefore, means it will call the 'CloseDoor' Event Handler.
            }


        }
        //
        // This is Event Handler for the request button which is located in the ground floor.
        //
        private void up_Click(object sender, EventArgs e)
        {
            // If the vertical location of the Elevator is equal to y = 469, the 'OpenDoor' timer will start. Otherwise, 'CloseDoor' timer will start.
            if (Elevator.Top == 469)
            {
                drOpen = false;
                // This insert command will be saved into string data type (Sqlcommand).
                // Afterwards, it will call the connection method to execute the 'Sqlcommand' which is stored in the data type.
                Sqlcommand = "INSERT INTO Log ( [Action], [Date] ) values ('Door is opening in ground Floor', ' " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "')";
                Connection();
                //Log Data = new Log();
                //Data.Log_Load(sender, e);
                close = true;
                OpenDoor.Start();// It will call the 'OpenDoor' Event Handler.
            }
            else
            { 
                
                drClose = false;
                button = false;
                lightOn = false;
                close = false;
                // This insert command will be saved into string data type (Sqlcommand).
                // Afterwards, it will call the connection method to execute the 'Sqlcommand' which is stored in the data type.
                Sqlcommand = "INSERT INTO Log ( [Action], [Date] ) values ('Door is closing in ground Floor', ' " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "')";

                Connection();
                CloseDoor.Start();// It will call the CloseDoor Event Handler.
            }
        }

        //
        // This Event Handler is for the 'GoUp' timer which is used to make the Elevator go up from the ground floor.
        //
        private void GoUp_Tick_1(object sender, EventArgs e)
        {
            GoDown.Stop(); // Before executing the 'GoUp' timer, the 'GoDown' timer will stop.
            //If the vertical location of the Elevator is less than or equal to y = 96, then the 'GoUp' timer will stop. 
            //Until the Elevator reaches y = 96, it continues increasing the vertical location from the ground floor (y = 469).
            if (Elevator.Top <= 96)
            {
                arrowUp.Visible = false;
                GoUp.Stop(); //'GoUp' timer will stop.
                downS.Visible = false; // First floor request button will become hidden.
                btnF1s.Visible = false;  // '1' button in the control panel will become hidden.

                G1.Visible = false;// G1' display screen will become hidden which means that the display sreen above the elevator doors will change into '1'.
                G2.Visible = false; // 'G2' display screen will become hidden which means that the display sreen above the elevator doors will change into '1'.

                GBox.Visible = false; // 'GBox' control panel display screen will become hidden.
                drOpen = true;
                lightOn = false;
                close = false;

                // This insert command will be saved into string data type (Sqlcommand).
                // Afterwards, it will call the connection method to execute the 'Sqlcommand' which is stored in the data type.
                Sqlcommand = "INSERT INTO Log ( [Action], [Date] ) values ('Elevator in First Floor', ' " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "')";
                Connection();

                OpenDoor.Start(); // It will call the 'OpenDoor' Event Handler.
            }
            else
            {
                Elevator.Top = Elevator.Top - 5;// The location of the Elevator will decrease by one which means the Elevator will go up from the ground floor.
                controlPanel.Top = controlPanel.Top - 5;// The location of the 'controlPanel' will decrease by one which means the controlPanel will go up from the ground floor.
                //If 'button' is aslo true, afterthat 'btnF1s' button will become visible.
                // If not, 'downS' will become visible.
                arrowUp.Visible = true;
                if (button == true)
                {
                    btnF1s.Visible = true;
                }
                else
                {
                    downS.Visible = true;
                }
            }
        }

        //
        // This Event Handler is for the 'GoDown' timer which is used to make the Elevator go down from the first floor.
        //
        private void GoDown_Tick(object sender, EventArgs e)
        {
            GoUp.Stop(); // Before executing the 'GoDown' timer, the 'GoUp' timer will stop.
            //If the vertical location of the Elevator is greater than or equal to y = 469, then the 'GoDown' timer will stop. 
            //Until the Elevator reaches y = 469, it continues decreasing the vertical location from the first floor (y = 96).

            if (Elevator.Top >= 469)
            {
                arrowDown.Visible = false;
                GoDown.Stop();// 'GoDown' timer will stop.
                upS.Visible = false; // Ground floor request button will become hidden.
                btnF0s.Visible = false; // 'G' button in the control panel will become hidden.
                G1.Visible = true; // 'G1' display screen will become visible which means that the display sreen above the elevator doors will change into 'G'.
                G2.Visible = true; // 'G2' display screen will become visible which means that the display sreen above the elevator doors will change into 'G'.
                GBox.Visible = true; // 'GBox' control panel display screen will become visible.
                drOpen = false;
                close = false;
                // This insert command will be saved into string data type (Sqlcommand).
                // Afterwards, it will call the connection method to execute the 'Sqlcommand' which is stored in the data type.
                Sqlcommand = "INSERT INTO Log ( [Action], [Date] ) values ('Elevator is in Ground Floor ', ' " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "')";
                Connection(); // It will call the connection method.

                OpenDoor.Start();
            }
            else
            {
                Elevator.Top = Elevator.Top + 5; // The location of the Elevator will increase by one which means the Elevator will go down from the first floor.
                controlPanel.Top = controlPanel.Top + 5; // The location of the 'controlPanel' will increase by one which means the controlPanel will go down from the first floor.
                arrowDown.Visible = true;
                // If 'button' is aslo true, afterthat 'btnF0s' button will become visible.
                // If not, 'upS' will become visible.
                if (button == true)
                {
                    btnF0s.Visible = true;
                }
                else
                {
                    upS.Visible = true;
                }
            }

        }

        //
        // This Event Handler is for the 'OpenDoor' timer which is used to make the Elevator door open.
        //
        private void OpenDoor_Tick(object sender, EventArgs e)
        {
            // If 'drOpen' is equal to true, then it will open the doors in first floor. Otherwise, it will open the doors in ground floor.
            if (drOpen == true)
            {
                {
                    //If the size width of the 'Door3' is less than or equal to 10, then the 'OpenDoor' timer will stop and the 'automaticCloseDoor' will start. 
                    //Until the width of 'Door3' reaches 10, it will continue reducing the width of 'Door3' & 'Door4'.
                    if (Door3.Width <= 10)
                    {
                        OpenDoor.Stop(); // The 'OpenDoor' timer will stop Which means it will stop reducing the width of 'Door3' & 'Door4'.

                        // This insert command will be saved into string data type (Sqlcommand).
                        // Afterwards, it will call the connection method to execute the 'Sqlcommand' which is stored in the data type.
                        Sqlcommand = "INSERT INTO Log ( [Action], [Date] ) values ('Door opened in First Floor', ' " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "')";
                        Connection();

                        drClose = false;
                        openLight.Visible = false;
                        automaticCloseDoor.Start(); // It call the 'automaticCloseDoor' Event Handler.
                       
                            //Thread.Sleep(3000);
                        //CloseDoor.Start();
                    }
                    else
                    {
                        Door3.Width--; // The width of 'Door3' will reduce by one.
                        Door4.Width--;  // The width of 'Door4' will reduce by one.
                        Door4.Left++;  // The horizontal location of 'Door4' will increase by one.
                        openLight.Visible = true;
                    }
                }
            }
            else
            {
                //If the size width of the 'Door1' is less than or equal to 10, then the 'OpenDoor' timer will stop and the 'automaticCloseDoor' will start. 
                //Until the width of 'Door1' reaches 10, it will continue reducing the width of 'Door1' & 'Door2'.
                if (Door1.Width <= 10)
                {
                    OpenDoor.Stop(); // The 'OpenDoor' timer will stop Which means it will stop reducing the width of 'Door1' & 'Door2'.
                    openLight.Visible = false; //The 'openLight'(Open door light) button will become hidden.

                    // This insert command will be saved into string data type (Sqlcommand).
                    // Afterwards, it will call the connection method to execute the 'Sqlcommand' which is stored in the data type.
                    Sqlcommand = "INSERT INTO Log ( [Action], [Date] ) values ('Door opened in Ground Floor', ' " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "')";
                        Connection();
                    drClose = true; 
                    automaticCloseDoor.Start();// It call the 'automaticCloseDoor' Event Handler.
                    //Thread.Sleep(2000);
                    //CloseDoor.Start();
                }
                else
                {
                    Door1.Width--; // The width of 'Door1' will reduce by one.
                    Door2.Width--; // The width of 'Door2' will reduce by one.
                    Door2.Left++;// The horizontal location of 'Door2' will increase by one.
                    openLight.Visible = true; // The 'openLight' (Open door light) button will become visible.
                }
            }

        }
        //
        // This Event Handler is for the 'CloseDoor' timer which is used to make the Elevator door close.
        //
        private void CloseDoor_Tick(object sender, EventArgs e)
        {
        openLight.Visible = false;
            //panel3.Location = new Point(panel3.Location.X + 1, panel3.Location.Y);
            // If 'drClose' is equal to true, then it will close the doors in ground floor. Otherwise, it will close the doors in first floor.
            if (drClose == true)
            {
                {
                    OpenDoor.Stop(); // Before executing the 'CloseDoor' action, 'OpenDoor' should stop
                    //If the size width of the 'Door1' is greater than or equal to 65, then the 'CloseDoor' timer will stop. 
                    //Until the width of 'Door1' reaches 65, it will continue increasing the width of 'Door1' & 'Door2'.
                    if (Door1.Width >= 65)
                    {
                        CloseDoor.Stop(); // The 'OpenDoor' timer will stop Which means it will stop increasing the width of 'Door1' & 'Door2'.
                        downS.Visible = false;
                        btnF1s.Visible = false;
                        lightOn = false;
                        // This insert command will be saved into string data type (Sqlcommand).
                        // Afterwards, it will call the connection method to execute the 'Sqlcommand' which is stored in the data type.
                        Sqlcommand = "INSERT INTO Log ( [Action], [Date] ) values ('Door is closed in Ground Floor', ' " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "')";
                        Connection();
                        Console.WriteLine(close);
                        // If the close is equal to false, then the 'GoDown' will start.
                        if (close == false) 
                        {
                            GoUp.Start();// It call the 'GoUp' Event Handler.
                        }
                        else
                        {
                            GoUp.Stop();
                        }
                    }
                    else
                    {
                        //  If 'LightOn' is equal to true,then if 'button' is aslo true, afterthat 'btnF1s' button will become visible.
                        // If not, 'downS' will become visible. Otherwise, 'downS' & 'btnF1s' will become hidden.
                        if (lightOn == true)
                        {
                            if (button == true)
                            {
                                btnF1s.Visible = true;
                            }
                            else
                            {
                                downS.Visible = true;
                            }
                                
                            
                        }
                        else
                        {
                            downS.Visible = false;
                            btnF1s.Visible = false;
                        }
                        Door1.Width++; //The width of 'Door1' will increase by one.
                        Door2.Width++; //The width of 'Door2' will increase by one.
                        Door2.Left--; // The horizontal location of 'Door2' will increase by one.



                    }
                }
            }
            else
            {
                OpenDoor.Stop();
                //If the size width of the 'Door3' is greater than or equal to 65, then the 'CloseDoor' timer will stop. 
                //Until the width of 'Door3' reaches 65, it will continue increasing the width of 'Door3' & 'Door4'.
                if (Door3.Width >= 65)
                {
                    CloseDoor.Stop();// The 'OpenDoor' timer will stop Which means it will stop increasing the width of 'Door3' & 'Door4'.
                    upS.Visible = false;
                    btnF0s.Visible = false;
                    // This insert command will be saved into string data type (Sqlcommand).
                    // Afterwards, it will call the connection method to execute the 'Sqlcommand' which is stored in the data type.
                    Sqlcommand = "INSERT INTO Log ( [Action], [Date] ) values ('Door is closed in First Floor', ' " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "')";
                    lightOn = false;
                    Connection();
                    Console.WriteLine(close);
                    // If the close is equal to false, then the 'GoDown' will start.
                    if (close == false)
                    {
                        GoDown.Start();// It call the 'GoDown' Event Handler.
                    }
                    else
                    {
                        GoUp.Stop();
                    }
                }
                else
                {//  If 'LightOn' is equal to true,then if 'button' is aslo true, afterthat 'btnF0s' button will become visible.
                 // If not, 'upS' will become visible. Otherwise, 'upS' & 'btnF0s' will become hidden.
                    if (lightOn == true)
                    {
                        if (button == true)
                        {
                            btnF0s.Visible = true;
                        }
                        else
                        {
                            upS.Visible = true;
                        }
                    }
                    else
                    {
                        upS.Visible = false;
                        btnF0s.Visible = false;
                    }

                    Door3.Width++; //The width of 'Door3' will increase by one.
                    Door4.Width++; //The width of 'Door4' will increase by one.
                    Door4.Left--; // The horizontal location of 'Door4' will increase by one.
                }
            }
        }
        //
        // This is an Event Handler for the form to load the current database name.
        //
        private void L_Load(object sender, EventArgs e)
        {
            connection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source= Elevator Log.mdb");
        }
        //
        // This is an Event Handler for the 'btnLog' button which opens the Elevator log information.
        //
        private void btnLog_Click(object sender, EventArgs e)
        {
            Log Data = new Log();
            Data.Show();
        }
        //
        // This Event Handler is for the 'automaticCloseDoor' timer which automatically waits a few seconds and 
        // then closes the doors if there is no response from the user. This is set to react on the first floor as well as the ground floor.
        //
        private void automaticCloseDoor_Tick(object sender, EventArgs e)
        {// If the vertical location of the 'Box' is greater than or equal to y = 70, then 'automaticCloseDoor' timer will stop and 
            //'CloseDoor' timer will start. Otherwise it will continuously increase the vertical location of the 'Box'.
            if (Box.Top >=70)
            {
                    close = true;
                automaticCloseDoor.Stop();
                lightOn = true;
                Box.Top = 37;
                CloseDoor.Start();// It will call the 'CloseDoor' Event handler.
            }
            else
            {
                Box.Top++; // The location of the 'Box' will increase by one.
                close = false;
            }
                
        }
        //
        // This is the Event Handler for the 'OpenDoor' button in the control panel.
        //
        private void button1_Click(object sender, EventArgs e)
        {
            CloseDoor.Stop(); // It will stop the 'CloseDoor' timer.

            // If the vertical location of the Elevator is greater then or equal to y = 469, the 'OpenDoor' timer will start. 
            // Also, if the vertical location of the Elevator is less then or equal to y = '96', then the CloseDoor' timer will start.

            if (Elevator.Top >= 469)
            {
                drOpen = false;
                close = true;
                OpenDoor.Start(); // It will call the 'OpenDoor' Event Handler.
            }
            else if (Elevator.Top <= 96)
            {
                drOpen = true;
                close = true;
                OpenDoor.Start(); // It will call the 'OpenDoor' Event Handler.

            }
        }
        //
        // This is the Event Handler for the hide buttton which hide/unhide all the doors to see if the lift moving or not.
        //
        private void button1_Click_1(object sender, EventArgs e)
        {//if the hide is equal to true, then it hide all the doors. Otherwise, it will unhide all the doors.
            if (hide == true)
            {
                Door1.Visible = false;
                Door2.Visible = false;
                Door3.Visible = false;
                Door4.Visible = false;
                hide = false;
            }
        else
            {
                Door1.Visible = true;
                Door2.Visible = true;
                Door3.Visible = true;
                Door4.Visible = true;
                hide = true;
            }
        }
    }
}

