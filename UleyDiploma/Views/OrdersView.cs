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
using UleyDiploma.Data;

namespace UleyDiploma.Views
{
    public partial class OrdersView : UserControl
    {

        int page = 0;

        public OrdersView()
        {
            InitializeComponent();
        }

        private void OrdersView_Load(object sender, EventArgs e)
        {

        }

        public void btn_orderLeft_Click()
        {
            page--;
            if (page < 0)
                page = 0;
            OrderRow();
        }

        public void btn_orderRight_Click()
        {
            page++;
            OrderRow();

        }

        private void tableLayoutPanel1_Resize(object sender, EventArgs e)
        {
            page = 0;
            OrderRow();

        }

        void OrderRow()
        {
            int maxRow = (tablePanel_orders.Size.Height / 85)-1;

            tablePanel_orders.Controls.Clear();

            List<OrdersCreate> orders =  RestUleyAPI.GetTemporaryOrder();

            tablePanel_orders.Controls.Add(new Views.Orders.OrdersRowArrow(this) { Dock = DockStyle.Fill });
            //try
            //{
                for (int i = 0; i < maxRow; i++)
                {
                if (i + (page * maxRow) > orders.Count-1)
                {
                    page--;
                    break;
                }
                if(i==0)

                    tablePanel_orders.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 85F));
                    tablePanel_orders.Controls.Add(new Views.Orders.OrdersRow(orders[i + (page*maxRow)]) { Dock = DockStyle.Fill }, 0, 0);
 
                }
            //}
            //catch(ArgumentOutOfRangeException ex)
            //{

            //    return;
            //}
        }

    }
}
