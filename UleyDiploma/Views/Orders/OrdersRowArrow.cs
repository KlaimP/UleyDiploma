using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UleyDiploma.Views.Orders
{
    public partial class OrdersRowArrow : UserControl
    {
        OrdersView order;
        public OrdersRowArrow(OrdersView order)
        {
            InitializeComponent();
            this.order = order;
        }

        private void btn_orderLeft_Click(object sender, EventArgs e)
        {
            order.btn_orderLeft_Click();
        }

        private void btn_orderRight_Click(object sender, EventArgs e)
        {
            order.btn_orderRight_Click();
        }
    }
}
