using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UleyDiploma.Data;

namespace UleyDiploma.Views.Orders
{
    public partial class OrdersRow : UserControl
    {
        OrdersCreate order;
        public OrdersRow(OrdersCreate order)
        {
            InitializeComponent();

            this.order = order;
        }

        private void OrdersRow_Load(object sender, EventArgs e)
        {
            lbl_productaName.Text = order.name;
            lbl_price.Text += order.price.ToString();
            lbl_upc.Text += order.upc.ToString();
            panel.Text += order.quantity.ToString();
            lbl_providers.Text += order.inn;
        }
    }
}
