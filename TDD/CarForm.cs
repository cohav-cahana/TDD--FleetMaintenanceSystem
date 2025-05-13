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
    public partial class CarForm : Form
    {
        FleetManager manager;
        public CarForm(FleetManager fleetManager)
        {
            InitializeComponent();
            this.manager = fleetManager;
        }

        private void CarForm_Load(object sender, EventArgs e)
        {
            for (int year = 2025; year >= 2000; year--)
            {
                cmbYear.Items.Add(year);
            }

            cmbType.Items.AddRange(new string[] { "Bus", "Truck", "Van", "Private" });
            cmbStatus.Items.AddRange(new string[] { "Fixed", "Needs Repair" });

        }

        
            private void btnAddCar_Click(object sender, EventArgs e)
        {
            string id = txtCarNumber.Text;
            string model = txtModel.Text;
            string company = txtCompany.Text;
            int year = (int)cmbYear.SelectedItem;
            string type = cmbType.SelectedItem.ToString();
            string status = cmbStatus.SelectedItem.ToString();

            Vehicle newVehicle = new Vehicle
            {
                ID = int.Parse(id),
                Model = model,
                Manufacturer = company,
                Year = year,
                Type = type,
                MaintenanceStatus = status
            };

            manager.AddVehicle(newVehicle);

            MessageBox.Show("Vehicle added successfully!");
            txtCarNumber.Text = "";
            txtModel.Text = "";
            txtCompany.Text = "";
            cmbYear.SelectedIndex = -1;
            cmbType.SelectedIndex = -1;
            cmbStatus.SelectedIndex = -1;


        }

        private void btnFillRandom_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            txtCarNumber.Text = rnd.Next(10000, 99999).ToString();

            string[] models = { "ModelX", "Civic", "Corolla", "Focus", "i30" };
            txtModel.Text = models[rnd.Next(models.Length)];

            string[] companies = { "Toyota", "Honda", "Ford", "Hyundai", "Chevrolet" };
            txtCompany.Text = companies[rnd.Next(companies.Length)];

            cmbYear.SelectedIndex = rnd.Next(cmbYear.Items.Count);

            cmbType.SelectedIndex = rnd.Next(cmbType.Items.Count);

            cmbStatus.SelectedIndex = rnd.Next(cmbStatus.Items.Count);
        }
    }
}

