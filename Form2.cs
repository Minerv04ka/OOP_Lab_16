using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Lab_16
{
    public partial class Form2 : Form
    {
        public Town TheTown;
        public Form2(Town t)
        {
            TheTown = t;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TheTown.Name = tbName.Text.Trim();
            TheTown.Country = tbCountry.Text.Trim();
            TheTown.Region = tbRegion.Text.Trim();
            TheTown.Population = int.Parse(tbPopulation.Text.Trim());
            TheTown.YearIncome = double.Parse(tbIncome.Text.Trim());
            TheTown.Area = double.Parse(tbArea.Text.Trim());
            TheTown.HasPort = cbHasPort.Checked;
            TheTown.HasAirport = cbHasAirport.Checked;

            if (TheTown != null)
            {
                DialogResult = DialogResult.OK;
            } else
            {
                MessageBox.Show("Enter correct values");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (TheTown != null)
            {
                tbName.Text = TheTown.Name;
                tbCountry.Text = TheTown.Country;
                tbRegion.Text = TheTown.Region;
                tbPopulation.Text = TheTown.Population.ToString();
                tbIncome.Text = TheTown.YearIncome.ToString("0.00");
                tbArea.Text = TheTown.Area.ToString("0.000");
                cbHasPort.Checked = TheTown.HasPort;
                cbHasAirport.Checked = TheTown.HasAirport;
            }
        }
    }
}
