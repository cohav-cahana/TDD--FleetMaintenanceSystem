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
using System.Text.RegularExpressions;

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

            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
      "fleet.csv");

            if (File.Exists(filePath))
            {
                manager.LoadFromFile(filePath);
            }

            btnAddCar.FlatStyle = FlatStyle.Flat;
            btnAddCar.FlatAppearance.BorderSize = 0;
            btnAddCar.BackColor = Color.FromArgb(150, Color.White); // חצי שקוף
            btnAddCar.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            btnAddCar.ForeColor = Color.Black;
            btnAddCar.Cursor = Cursors.Hand;

            btnFillRandom.FlatStyle = FlatStyle.Flat;
            btnFillRandom.FlatAppearance.BorderSize = 0;
            btnFillRandom.BackColor = Color.FromArgb(150, Color.White); // חצי שקוף
            btnFillRandom.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            btnFillRandom.ForeColor = Color.Black;
            btnFillRandom.Cursor = Cursors.Hand;


            btnShowReport.FlatStyle = FlatStyle.Flat;
            btnShowReport.FlatAppearance.BorderSize = 0;
            btnShowReport.BackColor = Color.FromArgb(150, Color.White); 
            btnShowReport.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            btnShowReport.ForeColor = Color.Black;
            btnShowReport.Cursor = Cursors.Hand;

            exit.FlatStyle = FlatStyle.Flat;
            exit.FlatAppearance.BorderSize = 0;
            exit.BackColor = Color.FromArgb(180, Color.DarkRed); 
            exit.ForeColor = Color.White;
            exit.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            exit.Text = "EXIT";
            exit.Cursor = Cursors.Hand;
            exit.Size = new Size(120, 40);

            label1.ForeColor = Color.FromArgb(30, 30, 30);
            label1.ForeColor = Color.Gold;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            label1.ForeColor = Color.White;

            label2.ForeColor = Color.FromArgb(30, 30, 30);
            label2.ForeColor = Color.Gold;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            label2.ForeColor = Color.White;

            label3.ForeColor = Color.FromArgb(30, 30, 30);
            label3.ForeColor = Color.Gold;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            label3.ForeColor = Color.White;

            label4.ForeColor = Color.FromArgb(30, 30, 30);
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            label4.ForeColor = Color.White;

            label5.ForeColor = Color.FromArgb(30, 30, 30);
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            label5.ForeColor = Color.White;

            label6.ForeColor = Color.FromArgb(30, 30, 30);
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            label6.ForeColor = Color.White;


            txtCarNumber.Font = new Font("Segoe UI", 10);
            txtCarNumber.ForeColor = Color.Black;
            txtCarNumber.BackColor = Color.White;
            txtCarNumber.BackColor = Color.FromArgb(240, 240, 240);
            txtCarNumber.BorderStyle = BorderStyle.FixedSingle;
            txtCarNumber.Height = 30;
            txtCarNumber.Margin = new Padding(10);
            txtCarNumber.TextAlign = HorizontalAlignment.Left;

            txtModel.Font = new Font("Segoe UI", 10);
            txtModel.ForeColor = Color.Black;
            txtModel.BackColor = Color.White;
            txtModel.BackColor = Color.FromArgb(240, 240, 240);
            txtModel.BorderStyle = BorderStyle.FixedSingle;
            txtModel.Height = 30;
            txtModel.Margin = new Padding(10);
            txtModel.TextAlign = HorizontalAlignment.Left;

            txtCompany.Font = new Font("Segoe UI", 10);
            txtCompany.ForeColor = Color.Black;
            txtCompany.BackColor = Color.White;
            txtCompany.BackColor = Color.FromArgb(240, 240, 240);
            txtCompany.BorderStyle = BorderStyle.FixedSingle;
            txtCompany.Height = 30;
            txtCompany.Margin = new Padding(10);
            txtCompany.TextAlign = HorizontalAlignment.Left;

            cmbType.FlatStyle = FlatStyle.Flat; 
            cmbType.BackColor = Color.FromArgb(240, 240, 240);
            cmbType.ForeColor = Color.Black;
            cmbType.Font = new Font("Segoe UI", 10); 
            cmbType.Height = 30; 
            cmbType.Margin = new Padding(10); 
            cmbType.DropDownStyle = ComboBoxStyle.DropDownList;

            cmbYear.FlatStyle = FlatStyle.Flat;
            cmbYear.BackColor = Color.FromArgb(240, 240, 240);
            cmbYear.ForeColor = Color.Black;
            cmbYear.Font = new Font("Segoe UI", 10);
            cmbYear.Height = 30;
            cmbYear.Margin = new Padding(10);
            cmbYear.DropDownStyle = ComboBoxStyle.DropDownList;

            cmbStatus.FlatStyle = FlatStyle.Flat;
            cmbStatus.BackColor = Color.FromArgb(240, 240, 240);
            cmbStatus.ForeColor = Color.Black;
            cmbStatus.Font = new Font("Segoe UI", 10);
            cmbStatus.Height = 30;
            cmbStatus.Margin = new Padding(10);
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;

            listBox1.DrawMode = DrawMode.OwnerDrawFixed;
            listBox1.DrawItem += (s, args) =>
            {
                if (args.Index < 0) return;

                args.DrawBackground();

                string itemText = listBox1.Items[args.Index].ToString();

                Brush textBrush = Brushes.Black;
                Font itemFont = new Font("Segoe UI", 10, FontStyle.Regular);

                if (itemText.Contains("Needs Repair"))
                {
                    textBrush = Brushes.DarkRed;
                }
                else if (itemText.Contains("Total number") ||
                         itemText.Contains("Average manufacturing") ||
                         itemText.Contains("Number of vehicles"))
                {
                    textBrush = Brushes.Navy;
                    itemFont = new Font("Segoe UI", 10, FontStyle.Bold);
                }
                else if (itemText.Contains("---"))
                {
                    textBrush = Brushes.Gray;
                    itemFont = new Font("Segoe UI", 10, FontStyle.Bold);
                }

                args.Graphics.DrawString(itemText, itemFont, textBrush, args.Bounds);
                args.DrawFocusRectangle();
            };
         

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
                if (string.IsNullOrWhiteSpace(txtModel.Text) || string.IsNullOrWhiteSpace(txtCompany.Text))
                {
                    MessageBox.Show("נא לא להשאיר שדה ריק.");
                    return;
                }
                if (!Regex.IsMatch(txtCompany.Text, @"^[a-zA-Zא-ת\s]+$"))
                {
                    MessageBox.Show("נא להזין רק אותיות בשם היצרן.");
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
            listBox1.Items.Clear(); 

            var sortedVehicles = manager.SortByYearDescending(); 

            if (sortedVehicles.Count == 0)
            {
                MessageBox.Show("אין רכבים להצגה בדוח.");
                return;
            }

            listBox1.Visible = true; 

            foreach (var v in sortedVehicles)
            {
                listBox1.Items.Add($"{v.ID} | {v.Model} | {v.Manufacturer} | {v.Year} | {v.Type} | {v.MaintenanceStatus}");
            }

            listBox1.Items.Add("--------------------------------------------------");

            int total = sortedVehicles.Count;

            double average = manager.CalculateAverageYear();

            int needRepairCount = sortedVehicles.Count(v => v.MaintenanceStatus == "Needs Repair");

            listBox1.Items.Add($"Total number of vehicles: {total}");
            listBox1.Items.Add($"Average manufacturing year: {average:F2}");
            listBox1.Items.Add($"Number of vehicles requiring maintenance: {needRepairCount}");
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

