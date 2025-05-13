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
            this.Hide(); 
            carForm.Show();

        }

       
        private void Form1_Load(object sender, EventArgs e)
        {
            car_info.FlatStyle = FlatStyle.Flat;
            car_info.FlatAppearance.BorderSize = 0;
            car_info.BackColor = Color.FromArgb(150, Color.White); 
            car_info.Font = new Font("Segoe UI", 14);
            car_info.ForeColor = Color.Black;

           

            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.BackColor = Color.FromArgb(180, Color.DarkRed); // גוון עמוק יותר
            btnExit.ForeColor = Color.White;
            btnExit.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            btnExit.Text = "EXIT";
            btnExit.Cursor = Cursors.Hand;
            btnExit.Size = new Size(120, 40);


            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.BackColor = Color.FromArgb(180, Color.DarkRed); // גוון עמוק יותר
            btnExit.ForeColor = Color.White;
            btnExit.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            btnExit.Text = "EXIT";
            btnExit.Cursor = Cursors.Hand;
            btnExit.Size = new Size(120, 40);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
