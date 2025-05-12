using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TDD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public FleetManager manager = new FleetManager(); 
        private void car_info_Click(object sender, EventArgs e)
        {
            CarForm carForm = new CarForm(manager);
            carForm.Show();

        }

        private void btn_all_cars_Click(object sender, EventArgs e)
        {
            List<Vehicle> vehicles = manager.GetAllVehicles();

            if (vehicles.Count == 0)
            {
                MessageBox.Show("No vehicles found.");
                return;
            }
            string message = "Vehicles in current manager:\n";
            foreach (var v in manager.GetAllVehicles())
            {
                message += $"ID: {v.ID}, Model: {v.Model}, Year: {v.Year}\n";
            }

            MessageBox.Show(message);

        }
       
    }
}
