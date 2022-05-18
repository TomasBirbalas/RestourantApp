using Repository.DataAccess;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestourantApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            ProductRepo productRepo = new ProductRepo();
            List<Product> productsList = new List<Product>();
            productsList = productRepo.RetrevieData();

            productsList.ForEach(product =>
            {
                textBox1.Text += $"{product.ToString()}\r\n";
            });
        }
    }
}
