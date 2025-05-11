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
        public CarForm()
        {
            InitializeComponent();
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
    }
}
