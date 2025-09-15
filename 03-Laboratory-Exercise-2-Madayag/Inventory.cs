using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

            string[] ListOfProductCategory = new string[]
            {
                "Beverages",
                "Bread/Bakery",
                "Canned/Jarred Goods",
                "Dairy",
                "Frozen Goods",
                "Meat",
                "Personal Care",
                "Other"
            };
            foreach (string ProductCategory in ListOfProductCategory)
            {
                CategoryCB.Items.Add(ProductCategory);
            }
        }

        private string _ProductName;
        private string _Category;
        private string _MfgDate;
        private string _ExpDate;
        private string _Description;
        private int _Quantity;
        private double _SellPrice;

        public string Product_Name(string name)
        {
            if (!Regex.IsMatch(name, @"^[a-zA-Z]+$"))
                //Exception here
                throw new Exception("Invalid Name Format");
                return name;
        }
        public int Quantity(string qty)
        {
            if (!Regex.IsMatch(qty, @"^[0-9]"))
                //Exception here
                throw new Exception("Invalid Number Format");
            return Convert.ToInt32(qty);
        }
        public double SellingPrice(string price)
        {
            if (!Regex.IsMatch(price.ToString(), @"^(\d*\.)?\d+$"))
                //Exception here
                throw new Exception("Invalid Currency Format");
            return Convert.ToDouble(price);
        }

        BindingSource showProductList = new BindingSource();

        private void Inventory_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#F3F3F3");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void AddProductButton_Click(object sender, EventArgs e)
        {
            _ProductName = Product_Name(ProductNameText.Text);
            _Category = CategoryCB.Text;
            _MfgDate = MfgDatePicker.Value.ToString("yyyy-MM-dd");
            _ExpDate = ExpDatePicker.Value.ToString("yyyy-MM-dd");
            _Description = DescriptionRichText.Text;
            _Quantity = Quantity(QuantityText.Text);
            _SellPrice = SellingPrice(SellPriceText.Text);
            showProductList.Add(new ProductClass(_ProductName, _Category, _MfgDate,
            _ExpDate, _SellPrice, _Quantity, _Description));
            ViewProductListGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ViewProductListGrid.DataSource = showProductList;
        }
    }
}
