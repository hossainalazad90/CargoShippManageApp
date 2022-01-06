namespace cargoshipWFAApp
{
    partial class FillBoatForm
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.NewBoatButton = new System.Windows.Forms.Button();
            this.MotoCycletrackBar = new System.Windows.Forms.TrackBar();
            this.TruckTrackBar = new System.Windows.Forms.TrackBar();
            this.CarTrackBar = new System.Windows.Forms.TrackBar();
            this.TrainCarTrackBar = new System.Windows.Forms.TrackBar();
            this.CargoShipPictureBox = new System.Windows.Forms.PictureBox();
            this.cargoBodyLabel = new System.Windows.Forms.Label();
            this.CarLabel = new System.Windows.Forms.Label();
            this.TrainCarLabel = new System.Windows.Forms.Label();
            this.TruckLabel = new System.Windows.Forms.Label();
            this.MotorcycleLabel = new System.Windows.Forms.Label();
            this.CargoBodytextBox = new System.Windows.Forms.TextBox();
            this.CargoColorPanel = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.MotoCycletrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TruckTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrainCarTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CargoShipPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // NewBoatButton
            // 
            this.NewBoatButton.Location = new System.Drawing.Point(65, 482);
            this.NewBoatButton.Name = "NewBoatButton";
            this.NewBoatButton.Size = new System.Drawing.Size(106, 35);
            this.NewBoatButton.TabIndex = 0;
            this.NewBoatButton.Text = "New Boat";
            this.NewBoatButton.UseVisualStyleBackColor = true;
            // 
            // MotoCycletrackBar
            // 
            this.MotoCycletrackBar.Location = new System.Drawing.Point(53, 339);
            this.MotoCycletrackBar.Maximum = 60;
            this.MotoCycletrackBar.Name = "MotoCycletrackBar";
            this.MotoCycletrackBar.Size = new System.Drawing.Size(380, 45);
            this.MotoCycletrackBar.TabIndex = 1;
            this.MotoCycletrackBar.Scroll += new System.EventHandler(this.MotoCycletrackBar_Scroll);
            // 
            // TruckTrackBar
            // 
            this.TruckTrackBar.Location = new System.Drawing.Point(439, 338);
            this.TruckTrackBar.Maximum = 20;
            this.TruckTrackBar.Name = "TruckTrackBar";
            this.TruckTrackBar.Size = new System.Drawing.Size(382, 45);
            this.TruckTrackBar.TabIndex = 1;
            this.TruckTrackBar.Scroll += new System.EventHandler(this.TruckTrackBar_Scroll);
            // 
            // CarTrackBar
            // 
            this.CarTrackBar.Location = new System.Drawing.Point(53, 412);
            this.CarTrackBar.Maximum = 30;
            this.CarTrackBar.Name = "CarTrackBar";
            this.CarTrackBar.Size = new System.Drawing.Size(380, 45);
            this.CarTrackBar.TabIndex = 1;
            this.CarTrackBar.Scroll += new System.EventHandler(this.CarTrackBar_Scroll);
            // 
            // TrainCarTrackBar
            // 
            this.TrainCarTrackBar.Location = new System.Drawing.Point(439, 411);
            this.TrainCarTrackBar.Maximum = 30;
            this.TrainCarTrackBar.Name = "TrainCarTrackBar";
            this.TrainCarTrackBar.Size = new System.Drawing.Size(382, 45);
            this.TrainCarTrackBar.TabIndex = 1;
            this.TrainCarTrackBar.Scroll += new System.EventHandler(this.TrainCarTrackBar_Scroll);
            // 
            // CargoShipPictureBox
            // 
            this.CargoShipPictureBox.Image = global::cargoshipWFAApp.Properties.Resources.cargoship;
            this.CargoShipPictureBox.Location = new System.Drawing.Point(65, 12);
            this.CargoShipPictureBox.Name = "CargoShipPictureBox";
            this.CargoShipPictureBox.Size = new System.Drawing.Size(772, 311);
            this.CargoShipPictureBox.TabIndex = 2;
            this.CargoShipPictureBox.TabStop = false;
            
            // 
            // cargoBodyLabel
            // 
            this.cargoBodyLabel.AutoSize = true;
            this.cargoBodyLabel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.cargoBodyLabel.Location = new System.Drawing.Point(272, 249);
            this.cargoBodyLabel.Name = "cargoBodyLabel";
            this.cargoBodyLabel.Size = new System.Drawing.Size(0, 13);
            this.cargoBodyLabel.TabIndex = 3;
            // 
            // CarLabel
            // 
            this.CarLabel.AutoSize = true;
            this.CarLabel.Location = new System.Drawing.Point(131, 429);
            this.CarLabel.Name = "CarLabel";
            this.CarLabel.Size = new System.Drawing.Size(28, 13);
            this.CarLabel.TabIndex = 6;
            this.CarLabel.Text = "Cars";
            // 
            // TrainCarLabel
            // 
            this.TrainCarLabel.AutoSize = true;
            this.TrainCarLabel.Location = new System.Drawing.Point(590, 429);
            this.TrainCarLabel.Name = "TrainCarLabel";
            this.TrainCarLabel.Size = new System.Drawing.Size(50, 13);
            this.TrainCarLabel.TabIndex = 7;
            this.TrainCarLabel.Text = "Train Car";
            // 
            // TruckLabel
            // 
            this.TruckLabel.AutoSize = true;
            this.TruckLabel.Location = new System.Drawing.Point(587, 356);
            this.TruckLabel.Name = "TruckLabel";
            this.TruckLabel.Size = new System.Drawing.Size(40, 13);
            this.TruckLabel.TabIndex = 5;
            this.TruckLabel.Text = "Trucks";
            // 
            // MotorcycleLabel
            // 
            this.MotorcycleLabel.AutoSize = true;
            this.MotorcycleLabel.Location = new System.Drawing.Point(128, 358);
            this.MotorcycleLabel.Name = "MotorcycleLabel";
            this.MotorcycleLabel.Size = new System.Drawing.Size(63, 13);
            this.MotorcycleLabel.TabIndex = 4;
            this.MotorcycleLabel.Text = "Motor Cycle";
            // 
            // CargoBodytextBox
            // 
            this.CargoBodytextBox.Location = new System.Drawing.Point(322, 249);
            this.CargoBodytextBox.Name = "CargoBodytextBox";
            this.CargoBodytextBox.Size = new System.Drawing.Size(232, 20);
            this.CargoBodytextBox.TabIndex = 8;
            // 
            // CargoColorPanel
            // 
            this.CargoColorPanel.Location = new System.Drawing.Point(212, 73);
            this.CargoColorPanel.Name = "CargoColorPanel";
            this.CargoColorPanel.Size = new System.Drawing.Size(500, 150);
            this.CargoColorPanel.TabIndex = 9;
            // 
            // FillBoatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(884, 535);
            this.Controls.Add(this.CargoColorPanel);
            this.Controls.Add(this.CargoBodytextBox);
            this.Controls.Add(this.TrainCarLabel);
            this.Controls.Add(this.CarLabel);
            this.Controls.Add(this.TruckLabel);
            this.Controls.Add(this.MotorcycleLabel);
            this.Controls.Add(this.cargoBodyLabel);
            this.Controls.Add(this.CargoShipPictureBox);
            this.Controls.Add(this.TrainCarTrackBar);
            this.Controls.Add(this.CarTrackBar);
            this.Controls.Add(this.TruckTrackBar);
            this.Controls.Add(this.MotoCycletrackBar);
            this.Controls.Add(this.NewBoatButton);
            this.Name = "FillBoatForm";
            this.Text = "Fill The Boat";
            this.Load += new System.EventHandler(this.FillBoatForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MotoCycletrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TruckTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrainCarTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CargoShipPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NewBoatButton;
        private System.Windows.Forms.TrackBar MotoCycletrackBar;
        private System.Windows.Forms.TrackBar TruckTrackBar;
        private System.Windows.Forms.TrackBar CarTrackBar;
        private System.Windows.Forms.TrackBar TrainCarTrackBar;
        private System.Windows.Forms.PictureBox CargoShipPictureBox;
        private System.Windows.Forms.Label cargoBodyLabel;
        private System.Windows.Forms.Label CarLabel;
        private System.Windows.Forms.Label TrainCarLabel;
        private System.Windows.Forms.Label TruckLabel;
        private System.Windows.Forms.Label MotorcycleLabel;
        private System.Windows.Forms.TextBox CargoBodytextBox;
        private System.Windows.Forms.Panel CargoColorPanel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

