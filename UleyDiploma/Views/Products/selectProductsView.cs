using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Be.Timvw.Framework.ComponentModel;
using Newtonsoft.Json;
using RestSharp;
using RestSharp.Authenticators;

namespace UleyDiploma.Views.Products
{
    public partial class selectProductsView : UserControl
    {
        public selectProductsView()
        {
            InitializeComponent();
        }

        private void selectProductsView_Load(object sender, EventArgs e)
        {

            SortableBindingList<Data.Products> products = new SortableBindingList<Data.Products>(API.RestUleyAPI.GetProducts());

            dataProducts.DataSource = products;

            foreach (DataGridViewColumn column in dataProducts.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.Automatic;
            }
        }

        private void dataProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
