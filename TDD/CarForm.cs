using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),"fleet.csv");

            if (File.Exists(filePath))
            {
                manager.LoadFromFile(filePath);
            }
        }

        
            private void btnAddCar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtCarNumber.Text, out int id))
                {
                    MessageBox.Show("מספר רכב לא חוקי. הזיני רק מספרים.");
                    return;
                }

                if (cmbYear.SelectedItem == null || cmbType.SelectedItem == null || cmbStatus.SelectedItem == null)
                {
                    MessageBox.Show("יש לבחור שנה, סוג רכב וסטטוס.");
                    return;
                }

                if (manager.GetAllVehicles().Any(car => car.ID == id))
                {
                    MessageBox.Show("רכב עם מספר זה כבר קיים!");
                    return;
                }

                Vehicle newVehicle = new Vehicle
                {
                    ID = id,
                    Model = txtModel.Text,
                    Manufacturer = txtCompany.Text,
                    Year = (int)cmbYear.SelectedItem,
                    Type = cmbType.SelectedItem.ToString(),
                    MaintenanceStatus = cmbStatus.SelectedItem.ToString()
                };

                manager.AddVehicle(newVehicle);

                string filePath = Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                    "fleet.csv");
                manager.SaveToFile(filePath);

                MessageBox.Show("הרכב נוסף ונשמר לקובץ!");

                txtCarNumber.Text = "";
                txtModel.Text = "";
                txtCompany.Text = "";
                cmbYear.SelectedIndex = -1;
                cmbType.SelectedIndex = -1;
                cmbStatus.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("אירעה שגיאה: " + ex.Message);
            }
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

        private void btnShowReport_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear(); // ניקוי רשימה קודמת

            var sortedVehicles = manager.SortByYearDescending(); // מיון לפי שנה

            if (sortedVehicles.Count == 0)
            {
                MessageBox.Show("אין רכבים להצגה בדוח.");
                return;
            }

            listBox1.Visible = true; // במקרה שהרשימה מוסתרת

            if (sortedVehicles.Count == 0)
            {
                MessageBox.Show("אין רכבים להצגה בדוח.");
                return;
            }

            // הצגת כל הרכבים
            foreach (var v in sortedVehicles)
            {
                listBox1.Items.Add($"{v.ID} | {v.Model} | {v.Manufacturer} | {v.Year} | {v.Type} | {v.MaintenanceStatus}");
            }

            listBox1.Items.Add("--------------------------------------------------");

            // סך הרכבים
            int total = sortedVehicles.Count;

            // ממוצע שנת ייצור
            double average = manager.CalculateAverageYear();

            // ספירת רכבים בסטטוס "Needs Repair"
            int needRepairCount = sortedVehicles.Count(v => v.MaintenanceStatus == "Needs Repair");

            listBox1.Items.Add($"סה\"כ רכבים: {total}");
            listBox1.Items.Add($"ממוצע שנות ייצור: {average:F2}");
            listBox1.Items.Add($"רכבים שדורשים תיקון: {needRepairCount}");
        }
    }
}

