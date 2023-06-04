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

namespace UleyDiploma.Views.Products
{
    public partial class addProductsView : UserControl
    {
        public addProductsView()
        {
            InitializeComponent();
        }

        private void btn_add_product_Click(object sender, EventArgs e)
        {
            Data.Products prd = new Data.Products();

            prd.upc = Convert.ToInt64(numeric_upc.Value);
            prd.name = textBox_nameProducts.Text;
            prd.price = Convert.ToDouble(numeric_price.Value);
            prd.discount = Convert.ToInt32(numeric_discount.Value);
            prd.catalog = comboBox_catalog.Text;
            prd.description = textBox_description.Text;
            prd.preview = null;
            prd.application_visible = false;

            var ret = RestUleyAPI.AddProduct(prd);

        }

        private void addProductsView_Load(object sender, EventArgs e)
        {
            List<Catalogs> catalogs = new List<Catalogs>(RestUleyAPI.GetCatalog());
            List<string> o_catalog = new List<string>();

            foreach (Catalogs ct in catalogs) 
                o_catalog.Add(ct.catalog_name);

            comboBox_catalog.DataSource = o_catalog;
            numeric_upc.Controls.RemoveAt(0);
        }

        private void textBox_upc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;

        }
    }
}
