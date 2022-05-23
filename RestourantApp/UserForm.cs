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
    public partial class UserForm : Form
    {
        private WaitressRepo waitressRepo = new WaitressRepo();
        private Waitress _Waitress;
        public UserForm()
        {
            InitializeComponent();
            RenderTablesList();
        }
        public void RenderTablesList()
        {
            _Waitress = waitressRepo.RetrieveWaitress(Global.id, Global.pinCode);

            int n = _Waitress.TableList.Count;

            Button[] btnTableNumber = new Button[n];

            for (int i = 0; i < n; i++)
            {
                btnTableNumber[i] = new Button();
                btnTableNumber[i].Text = $"Table {i + 1}";
                btnTableNumber[i].Width = 145;
                btnTableNumber[i].Height = 145;

                if (i < 5)
                {
                    btnTableNumber[i].Left = 100 + (165 * i);
                    btnTableNumber[i].Top = 100;
                }
                else
                {
                    btnTableNumber[i].Left = 100 + (165 * (i - 5));
                    btnTableNumber[i].Top = 265;
                }

                this.Controls.Add(btnTableNumber[i]);
            }
        }
    }
}
