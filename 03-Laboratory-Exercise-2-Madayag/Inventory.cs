using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_Laboratory_Exercise_2_Madayag
{
    public partial class Inventory : Form
    {
        public Inventory()
        {
            InitializeComponent();

            AddProductButton.BackColor = ColorTranslator.FromHtml("#3A5A40");
            AddProductButton.ForeColor = ColorTranslator.FromHtml("#DFE6DA");

            label2.ForeColor = ColorTranslator.FromHtml("#000907");
            label1.ForeColor = ColorTranslator.FromHtml("#363636");
            label3.ForeColor = ColorTranslator.FromHtml("#363636");
            label4.ForeColor = ColorTranslator.FromHtml("#363636");
            label5.ForeColor = ColorTranslator.FromHtml("#363636");
            label6.ForeColor = ColorTranslator.FromHtml("#363636");
            label7.ForeColor = ColorTranslator.FromHtml("#363636");
            label8.ForeColor = ColorTranslator.FromHtml("#363636");
        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#F3F3F3");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
  
    }
}
