using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UleyDiploma.API;
using UleyDiploma.Forms;

namespace UleyDiploma
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btn_main_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(new Views.MainView() { Dock = DockStyle.Fill });
        }

        private void btn_products_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(new Views.ProductsView() { Dock = DockStyle.Fill });
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            RestUleyAPI.log("Started application");
            
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(new Views.MainView() { Dock = DockStyle.Fill });

            Forms.Authorization authorization = new Forms.Authorization();
            authorization.ShowDialog();
        }

        private void btn_orders_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(new Views.OrdersView() { Dock = DockStyle.Fill });
        }

        private void menu_createOrders_Click(object sender, EventArgs e)
        {

        }

        private void menuAddProviders_Click(object sender, EventArgs e)
        {
            AddProviders form = new AddProviders();

            form.Show();
        }
    }
}
