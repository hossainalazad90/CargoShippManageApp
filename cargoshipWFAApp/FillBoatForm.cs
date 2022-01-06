using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cargoshipWFAApp
{
    public partial class FillBoatForm : Form
    {
        public FillBoatForm()
        {
            InitializeComponent();
        }
        int CarValue = 0;
        int MCycleValue = 0;
        int TrainCarValue = 0;
        int TruckValue = 0;
        int CarNo = 0;
        int MCycleNo = 0;
        int TrainCarNo = 0;
        int TruckNo = 0;
        int panelSize = 100;
        private void FillBoatForm_Load(object sender, EventArgs e)
        {
            CargoBodytextBox.Text = GetCapacityInfo();
            ProvideColor();
        }
        private void MotoCycletrackBar_Scroll(object sender, EventArgs e)
        {
            MCycleValue = MotoCycletrackBar.Value * 3;
            MCycleNo = MotoCycletrackBar.Value;
            MotorcycleLabel.Text = "Motor Cycle (" + MotoCycletrackBar.Value+") Units";
            CargoBodytextBox.Text = GetCapacityInfo();
            ProvideColor();
        }

        private  void NewBoatButton_Click(object sender, EventArgs e)
        {
            this.Refresh();
            this.Invalidate();
            Clear();


        }

        private void TruckTrackBar_Scroll(object sender, EventArgs e)
        {
            TruckValue = TruckTrackBar.Value * 11;
            TruckNo = TruckTrackBar.Value;
            TruckLabel.Text = "Truck (" + TruckTrackBar.Value+") Units";
            CargoBodytextBox.Text = GetCapacityInfo();
            ProvideColor();
        }

        private void CarTrackBar_Scroll(object sender, EventArgs e)
        {
            CarValue = CarTrackBar.Value * 5;
            CarNo = CarTrackBar.Value;
            CarLabel.Text = "Car (" + CarTrackBar.Value+") Units";
            CargoBodytextBox.Text = GetCapacityInfo();
            ProvideColor();
        }
        private void TrainCarTrackBar_Scroll(object sender, EventArgs e)
        {
            TrainCarValue = TrainCarTrackBar.Value * 17;
            TrainCarNo = TrainCarTrackBar.Value;
            TrainCarLabel.Text = "Train Car (" + TrainCarTrackBar.Value + ") Units";
            CargoBodytextBox.Text = GetCapacityInfo();
            ProvideColor();

        }
        
        internal string GetCapacityInfo()
        {  
            return  "Capacity ="+ panelSize + ", Current Load="+ GetCurrentLoad();
        }
        internal int GetCurrentLoad()
        {
            return MCycleNo + CarNo + TrainCarNo + TruckNo;
        }

        internal int GetCapacity()
        {
            return TrainCarTrackBar.Maximum + CarTrackBar.Maximum + TruckTrackBar.Maximum + MotoCycletrackBar.Maximum;
        }
        

        internal void ProvideColor()
        {
           
            if (panelSize == GetCurrentLoad())
            {
                CargoColorPanel.BackColor = Color.Green;
            }
            else if(GetCurrentLoad() > panelSize)
            {
                CargoColorPanel.BackColor = Color.Red;
            }
            else
            {
                CargoColorPanel.BackColor = Color.LightYellow;
            }

        }

        internal void Clear()
        {
            TrainCarTrackBar.Refresh();
            CarTrackBar.Refresh();
            TruckTrackBar.Refresh();
            MotoCycletrackBar.Refresh();
        }
    }
}
