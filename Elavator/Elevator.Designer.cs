/// <summary>
/// Sutharshan kumaravel
/// 1404884
/// Assignment 1: Control an Elevator - A C# Project
/// 10th December 2015 
/// <summary>
namespace Elavator
{
    partial class Lift
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// This is method which has all components that is needed for elevator application form.
        /// Required method for Designer support
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lift));
            this.Down = new System.Windows.Forms.Button();
            this.Up = new System.Windows.Forms.Button();
            this.btnF1 = new System.Windows.Forms.Button();
            this.btnF0 = new System.Windows.Forms.Button();
            this.btnLog = new System.Windows.Forms.Button();
            this.controlPanel = new System.Windows.Forms.Panel();
            this.openLight = new System.Windows.Forms.Button();
            this.open = new System.Windows.Forms.Button();
            this.btnF0s = new System.Windows.Forms.Button();
            this.btnF1s = new System.Windows.Forms.Button();
            this.GBox = new System.Windows.Forms.PictureBox();
            this.FBox = new System.Windows.Forms.PictureBox();
            this.GoUp = new System.Windows.Forms.Timer(this.components);
            this.GoDown = new System.Windows.Forms.Timer(this.components);
            this.Door1 = new System.Windows.Forms.Panel();
            this.OpenDoor = new System.Windows.Forms.Timer(this.components);
            this.Door3 = new System.Windows.Forms.Panel();
            this.CloseDoor = new System.Windows.Forms.Timer(this.components);
            this.Door2 = new System.Windows.Forms.Panel();
            this.Door4 = new System.Windows.Forms.Panel();
            this.backLift = new System.Windows.Forms.PictureBox();
            this.Elevator = new System.Windows.Forms.PictureBox();
            this.G2 = new System.Windows.Forms.PictureBox();
            this.F1 = new System.Windows.Forms.PictureBox();
            this.G1 = new System.Windows.Forms.PictureBox();
            this.F2 = new System.Windows.Forms.PictureBox();
            this.downS = new System.Windows.Forms.Button();
            this.upS = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.arrowUp = new System.Windows.Forms.PictureBox();
            this.arrowDown = new System.Windows.Forms.PictureBox();
            this.Hidden = new System.Windows.Forms.Button();
            this.controlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backLift)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Elevator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.G2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.F1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.G1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.F2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrowUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrowDown)).BeginInit();
            this.SuspendLayout();
            // 
            // Down
            // 
            this.Down.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Down.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Down.Image = ((System.Drawing.Image)(resources.GetObject("Down.Image")));
            this.Down.Location = new System.Drawing.Point(362, 159);
            this.Down.Name = "Down";
            this.Down.Size = new System.Drawing.Size(24, 29);
            this.Down.TabIndex = 0;
            this.Down.UseVisualStyleBackColor = false;
            this.Down.Click += new System.EventHandler(this.down_Click);
            // 
            // Up
            // 
            this.Up.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Up.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Up.Image = ((System.Drawing.Image)(resources.GetObject("Up.Image")));
            this.Up.Location = new System.Drawing.Point(362, 545);
            this.Up.Name = "Up";
            this.Up.Size = new System.Drawing.Size(24, 29);
            this.Up.TabIndex = 1;
            this.Up.UseVisualStyleBackColor = false;
            this.Up.Click += new System.EventHandler(this.up_Click);
            // 
            // btnF1
            // 
            this.btnF1.BackColor = System.Drawing.Color.Black;
            this.btnF1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnF1.Image = ((System.Drawing.Image)(resources.GetObject("btnF1.Image")));
            this.btnF1.Location = new System.Drawing.Point(17, 93);
            this.btnF1.Name = "btnF1";
            this.btnF1.Size = new System.Drawing.Size(38, 45);
            this.btnF1.TabIndex = 2;
            this.btnF1.UseVisualStyleBackColor = false;
            this.btnF1.Click += new System.EventHandler(this.Floor1_Click);
            // 
            // btnF0
            // 
            this.btnF0.BackColor = System.Drawing.Color.Black;
            this.btnF0.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnF0.Image = ((System.Drawing.Image)(resources.GetObject("btnF0.Image")));
            this.btnF0.Location = new System.Drawing.Point(17, 145);
            this.btnF0.Name = "btnF0";
            this.btnF0.Size = new System.Drawing.Size(37, 45);
            this.btnF0.TabIndex = 3;
            this.btnF0.UseVisualStyleBackColor = false;
            this.btnF0.Click += new System.EventHandler(this.Floor0_Click);
            // 
            // btnLog
            // 
            this.btnLog.Image = ((System.Drawing.Image)(resources.GetObject("btnLog.Image")));
            this.btnLog.Location = new System.Drawing.Point(603, 633);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(54, 98);
            this.btnLog.TabIndex = 7;
            this.btnLog.UseVisualStyleBackColor = true;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // controlPanel
            // 
            this.controlPanel.Controls.Add(this.openLight);
            this.controlPanel.Controls.Add(this.open);
            this.controlPanel.Controls.Add(this.btnF0s);
            this.controlPanel.Controls.Add(this.btnF1s);
            this.controlPanel.Controls.Add(this.btnF0);
            this.controlPanel.Controls.Add(this.btnF1);
            this.controlPanel.Controls.Add(this.GBox);
            this.controlPanel.Controls.Add(this.FBox);
            this.controlPanel.Location = new System.Drawing.Point(516, 421);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(81, 259);
            this.controlPanel.TabIndex = 8;
            // 
            // openLight
            // 
            this.openLight.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.openLight.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.openLight.Image = ((System.Drawing.Image)(resources.GetObject("openLight.Image")));
            this.openLight.Location = new System.Drawing.Point(13, 202);
            this.openLight.Name = "openLight";
            this.openLight.Size = new System.Drawing.Size(45, 32);
            this.openLight.TabIndex = 28;
            this.openLight.UseVisualStyleBackColor = false;
            this.openLight.Visible = false;
            // 
            // open
            // 
            this.open.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.open.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.open.Image = ((System.Drawing.Image)(resources.GetObject("open.Image")));
            this.open.Location = new System.Drawing.Point(13, 202);
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(45, 32);
            this.open.TabIndex = 26;
            this.open.UseVisualStyleBackColor = false;
            this.open.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnF0s
            // 
            this.btnF0s.BackColor = System.Drawing.Color.Black;
            this.btnF0s.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnF0s.Image = ((System.Drawing.Image)(resources.GetObject("btnF0s.Image")));
            this.btnF0s.Location = new System.Drawing.Point(13, 145);
            this.btnF0s.Name = "btnF0s";
            this.btnF0s.Size = new System.Drawing.Size(41, 45);
            this.btnF0s.TabIndex = 26;
            this.btnF0s.UseVisualStyleBackColor = false;
            this.btnF0s.Visible = false;
            // 
            // btnF1s
            // 
            this.btnF1s.BackColor = System.Drawing.Color.Black;
            this.btnF1s.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnF1s.Image = ((System.Drawing.Image)(resources.GetObject("btnF1s.Image")));
            this.btnF1s.Location = new System.Drawing.Point(17, 93);
            this.btnF1s.Name = "btnF1s";
            this.btnF1s.Size = new System.Drawing.Size(37, 46);
            this.btnF1s.TabIndex = 27;
            this.btnF1s.UseVisualStyleBackColor = false;
            this.btnF1s.Visible = false;
            // 
            // GBox
            // 
            this.GBox.Image = ((System.Drawing.Image)(resources.GetObject("GBox.Image")));
            this.GBox.Location = new System.Drawing.Point(3, 30);
            this.GBox.Name = "GBox";
            this.GBox.Size = new System.Drawing.Size(72, 229);
            this.GBox.TabIndex = 24;
            this.GBox.TabStop = false;
            // 
            // FBox
            // 
            this.FBox.Image = ((System.Drawing.Image)(resources.GetObject("FBox.Image")));
            this.FBox.Location = new System.Drawing.Point(3, 30);
            this.FBox.Name = "FBox";
            this.FBox.Size = new System.Drawing.Size(69, 229);
            this.FBox.TabIndex = 25;
            this.FBox.TabStop = false;
            // 
            // GoUp
            // 
            this.GoUp.Tick += new System.EventHandler(this.GoUp_Tick_1);
            // 
            // GoDown
            // 
            this.GoDown.Tick += new System.EventHandler(this.GoDown_Tick);
            // 
            // Door1
            // 
            this.Door1.BackColor = System.Drawing.Color.Chartreuse;
            this.Door1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Door1.BackgroundImage")));
            this.Door1.Location = new System.Drawing.Point(188, 470);
            this.Door1.Name = "Door1";
            this.Door1.Size = new System.Drawing.Size(64, 210);
            this.Door1.TabIndex = 12;
            // 
            // OpenDoor
            // 
            this.OpenDoor.Tick += new System.EventHandler(this.OpenDoor_Tick);
            // 
            // Door3
            // 
            this.Door3.BackColor = System.Drawing.Color.Chartreuse;
            this.Door3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Door3.BackgroundImage")));
            this.Door3.Location = new System.Drawing.Point(187, 96);
            this.Door3.Name = "Door3";
            this.Door3.Size = new System.Drawing.Size(65, 211);
            this.Door3.TabIndex = 13;
            // 
            // CloseDoor
            // 
            this.CloseDoor.Tick += new System.EventHandler(this.CloseDoor_Tick);
            // 
            // Door2
            // 
            this.Door2.BackColor = System.Drawing.Color.Chartreuse;
            this.Door2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Door2.BackgroundImage")));
            this.Door2.Location = new System.Drawing.Point(253, 470);
            this.Door2.Name = "Door2";
            this.Door2.Size = new System.Drawing.Size(65, 210);
            this.Door2.TabIndex = 13;
            // 
            // Door4
            // 
            this.Door4.BackColor = System.Drawing.Color.Chartreuse;
            this.Door4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Door4.BackgroundImage")));
            this.Door4.Location = new System.Drawing.Point(252, 96);
            this.Door4.Name = "Door4";
            this.Door4.Size = new System.Drawing.Size(65, 211);
            this.Door4.TabIndex = 14;
            // 
            // backLift
            // 
            this.backLift.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backLift.BackgroundImage")));
            this.backLift.Location = new System.Drawing.Point(-2, -22);
            this.backLift.Name = "backLift";
            this.backLift.Size = new System.Drawing.Size(512, 768);
            this.backLift.TabIndex = 15;
            this.backLift.TabStop = false;
            // 
            // Elevator
            // 
            this.Elevator.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Elevator.BackgroundImage")));
            this.Elevator.Location = new System.Drawing.Point(187, 470);
            this.Elevator.Name = "Elevator";
            this.Elevator.Size = new System.Drawing.Size(131, 210);
            this.Elevator.TabIndex = 16;
            this.Elevator.TabStop = false;
            // 
            // G2
            // 
            this.G2.BackColor = System.Drawing.Color.Transparent;
            this.G2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("G2.BackgroundImage")));
            this.G2.Location = new System.Drawing.Point(225, 65);
            this.G2.Name = "G2";
            this.G2.Size = new System.Drawing.Size(48, 20);
            this.G2.TabIndex = 17;
            this.G2.TabStop = false;
            // 
            // F1
            // 
            this.F1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("F1.BackgroundImage")));
            this.F1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.F1.Location = new System.Drawing.Point(224, 440);
            this.F1.Name = "F1";
            this.F1.Size = new System.Drawing.Size(48, 21);
            this.F1.TabIndex = 19;
            this.F1.TabStop = false;
            // 
            // G1
            // 
            this.G1.BackColor = System.Drawing.Color.Transparent;
            this.G1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("G1.BackgroundImage")));
            this.G1.Location = new System.Drawing.Point(224, 439);
            this.G1.Name = "G1";
            this.G1.Size = new System.Drawing.Size(48, 20);
            this.G1.TabIndex = 20;
            this.G1.TabStop = false;
            // 
            // F2
            // 
            this.F2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("F2.BackgroundImage")));
            this.F2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.F2.Location = new System.Drawing.Point(225, 64);
            this.F2.Name = "F2";
            this.F2.Size = new System.Drawing.Size(48, 21);
            this.F2.TabIndex = 21;
            this.F2.TabStop = false;
            // 
            // downS
            // 
            this.downS.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.downS.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.downS.Image = ((System.Drawing.Image)(resources.GetObject("downS.Image")));
            this.downS.Location = new System.Drawing.Point(360, 159);
            this.downS.Name = "downS";
            this.downS.Size = new System.Drawing.Size(28, 29);
            this.downS.TabIndex = 22;
            this.downS.UseVisualStyleBackColor = false;
            this.downS.Visible = false;
            // 
            // upS
            // 
            this.upS.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.upS.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.upS.Image = ((System.Drawing.Image)(resources.GetObject("upS.Image")));
            this.upS.Location = new System.Drawing.Point(360, 545);
            this.upS.Name = "upS";
            this.upS.Size = new System.Drawing.Size(28, 29);
            this.upS.TabIndex = 23;
            this.upS.UseVisualStyleBackColor = false;
            this.upS.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, 307);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(357, 163);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // arrowUp
            // 
            this.arrowUp.BackColor = System.Drawing.Color.Transparent;
            this.arrowUp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("arrowUp.BackgroundImage")));
            this.arrowUp.Location = new System.Drawing.Point(223, 439);
            this.arrowUp.Name = "arrowUp";
            this.arrowUp.Size = new System.Drawing.Size(50, 22);
            this.arrowUp.TabIndex = 26;
            this.arrowUp.TabStop = false;
            this.arrowUp.Visible = false;
            // 
            // arrowDown
            // 
            this.arrowDown.BackColor = System.Drawing.Color.Transparent;
            this.arrowDown.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("arrowDown.BackgroundImage")));
            this.arrowDown.Location = new System.Drawing.Point(225, 64);
            this.arrowDown.Name = "arrowDown";
            this.arrowDown.Size = new System.Drawing.Size(50, 22);
            this.arrowDown.TabIndex = 27;
            this.arrowDown.TabStop = false;
            this.arrowDown.Visible = false;
            // 
            // Hidden
            // 
            this.Hidden.Location = new System.Drawing.Point(581, 12);
            this.Hidden.Name = "Hidden";
            this.Hidden.Size = new System.Drawing.Size(85, 23);
            this.Hidden.TabIndex = 28;
            this.Hidden.Text = "Hide/Unhide";
            this.Hidden.UseVisualStyleBackColor = true;
            this.Hidden.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Lift
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 733);
            this.Controls.Add(this.Hidden);
            this.Controls.Add(this.arrowDown);
            this.Controls.Add(this.arrowUp);
            this.Controls.Add(this.G1);
            this.Controls.Add(this.F1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Door3);
            this.Controls.Add(this.Door4);
            this.Controls.Add(this.Door1);
            this.Controls.Add(this.Door2);
            this.Controls.Add(this.Elevator);
            this.Controls.Add(this.upS);
            this.Controls.Add(this.downS);
            this.Controls.Add(this.G2);
            this.Controls.Add(this.F2);
            this.Controls.Add(this.Up);
            this.Controls.Add(this.Down);
            this.Controls.Add(this.controlPanel);
            this.Controls.Add(this.btnLog);
            this.Controls.Add(this.backLift);
            this.Name = "Lift";
            this.Text = "Elevator";
            this.Load += new System.EventHandler(this.L_Load);
            this.controlPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backLift)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Elevator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.G2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.F1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.G1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.F2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrowUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrowDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Down;
        private System.Windows.Forms.Button Up;
        private System.Windows.Forms.Button btnF1;
        private System.Windows.Forms.Button btnF0;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.Panel controlPanel;
        private System.Windows.Forms.Timer GoUp;
        private System.Windows.Forms.Timer GoDown;
        private System.Windows.Forms.Panel Door1;
        private System.Windows.Forms.Timer OpenDoor;
        private System.Windows.Forms.Panel Door3;
        private System.Windows.Forms.Timer CloseDoor;
        private System.Windows.Forms.Panel Door2;
        private System.Windows.Forms.Panel Door4;
        private System.Windows.Forms.PictureBox backLift;
        private System.Windows.Forms.PictureBox Elevator;
        private System.Windows.Forms.PictureBox G2;
        private System.Windows.Forms.PictureBox F1;
        private System.Windows.Forms.PictureBox G1;
        private System.Windows.Forms.PictureBox F2;
        private System.Windows.Forms.Button downS;
        private System.Windows.Forms.Button upS;
        private System.Windows.Forms.PictureBox GBox;
        private System.Windows.Forms.PictureBox FBox;
        private System.Windows.Forms.Button btnF0s;
        private System.Windows.Forms.Button btnF1s;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button open;
        private System.Windows.Forms.Button openLight;
        private System.Windows.Forms.PictureBox arrowUp;
        private System.Windows.Forms.PictureBox arrowDown;
        private System.Windows.Forms.Button Hidden;
    }
}

