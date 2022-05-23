using BusinessLogic.Services;
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
        Waitress _Waitress;
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

            WaitressRepo waitressRepo = new WaitressRepo();
            Waitress waitress = waitressRepo.RetrieveWaitress(1, 1234);

            inputUserId.Text += $"{waitress.Name} {waitress.Surname}";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            WaitressRepo waitressRepo = new WaitressRepo();

            int id;
            int pinCode;
            if (int.TryParse(inputUserId.Text, out id) && int.TryParse(inputUserPinCode.Text, out pinCode))
            {
                _Waitress = waitressRepo.RetrieveWaitress(id, pinCode);

                MessageBox.Show($"You have successfully logged in.\r\n{_Waitress.Name} {_Waitress.Surname}");

                textBoxFullName.Text = $"{_Waitress.Name} {_Waitress.Surname}";

                Global.id = id;
                Global.pinCode = pinCode;

                UserForm userForm = new UserForm();

                openChildForm(userForm);
            }
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelMain.Controls.Add(childForm);
            panelMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
    }
}
