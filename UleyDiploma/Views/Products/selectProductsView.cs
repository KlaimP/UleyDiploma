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
            string url = "http://192.168.56.112:3000/rpc/get_products";

            var client = new RestClient(url);
            var request = new RestRequest();

            var response = client.Get(request);

            var result = JsonConvert.DeserializeObject<List<Data.Products>>(response.Content);

            SortableBindingList<Data.Products> products = new SortableBindingList<Data.Products>(result);

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
