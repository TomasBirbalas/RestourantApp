using BusinessLogic.Services;
using Repository.DataAccess;
using Repository.Deserializer;
using Repository.Models;
using Repository.Serializer;
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

        private DataSerializer dataSerializer = new DataSerializer();
        private JSONdeserializer jsonDeserializer = new JSONdeserializer();

        WaitressServices _WaitressServices = new WaitressServices();
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
                btnTableNumber[i].Text = $"Table {_Waitress.TableList[i].Id}";
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

        private void btnGetNewTable_Click(object sender, EventArgs e)
        {
            int personCounter;
            _Waitress = waitressRepo.RetrieveWaitress(Global.id, Global.pinCode);

            if (int.TryParse(inputPersonCount.Text, out personCounter))
            {
                Table table = _WaitressServices.GetNewTable(_Waitress, personCounter);

                MessageBox.Show($"Available table is {table.Id}");


                DialogResult res = MessageBox.Show($"Do you want to Book Table {table.Id}", "Book new Table", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (res == DialogResult.OK)
                {
                    _WaitressServices.BookTable(ref table);
                    List<Client> clientList = jsonDeserializer.DeserializeClient(@"..\..\..\..\DataFiles\clientJSON.json");
                    clientList.Add(new Client(personCounter, table.Id));
                    dataSerializer.SerializeData(@"..\..\..\..\DataFiles\clientJSON.json", clientList);
                }
                if (res == DialogResult.Cancel)
                {
                    MessageBox.Show("You have clicked Cancel Button");
                }
            }
        }
    }
}
