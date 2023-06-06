using Be.Timvw.Framework.ComponentModel;
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
    public partial class ProductsView : UserControl
    {
        public ProductsView()
        {
            InitializeComponent();
        }


        private void ProductsView_Load(object sender, EventArgs e)
        {

            SortableBindingList<Data.Products> products = new SortableBindingList<Data.Products>(API.RestUleyAPI.GetProducts());

            dataProducts.DataSource = products;



            List<Catalogs> catalogs = new List<Catalogs>(RestUleyAPI.GetCatalog());
            List<string> o_catalog = new List<string>();

            foreach (Catalogs ct in catalogs)
                o_catalog.Add(ct.catalog_name);

            comboBox_catalog.DataSource = o_catalog;
            numeric_upc.Controls.RemoveAt(0);



            SortableBindingList<Data.DailySales> dailysales = new SortableBindingList<Data.DailySales>(API.RestUleyAPI.GetDailySales(DateTime.Now));

            dataGrid_dailysales.DataSource = dailysales;

            dateTimePicker_dailySales.Value = DateTime.Now;
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
            if(ret != null)
            {
                DialogResult res = MessageBox.Show("Товар успешно добавлен в систему", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                numeric_upc.Value = 0;
                textBox_nameProducts.Text = "";
                numeric_price.Value = 1;
                numeric_discount.Value = 0;
                comboBox_catalog.SelectedIndex = 0;
                textBox_description.Text = "";
            }
        }

        private void btn_right_Click(object sender, EventArgs e)
        {
            dateTimePicker_dailySales.Value = dateTimePicker_dailySales.Value.AddDays(1);
            SortableBindingList<Data.DailySales> dailysales = new SortableBindingList<Data.DailySales>(API.RestUleyAPI.GetDailySales(dateTimePicker_dailySales.Value));

            dataGrid_dailysales.DataSource = dailysales;
        }

        private void dateTimePicker_dailySales_ValueChanged(object sender, EventArgs e)
        {
            SortableBindingList<Data.DailySales> dailysales = new SortableBindingList<Data.DailySales>(API.RestUleyAPI.GetDailySales(dateTimePicker_dailySales.Value));

            dataGrid_dailysales.DataSource = dailysales;
        }

        private void btn_left_Click(object sender, EventArgs e)
        {
            dateTimePicker_dailySales.Value = dateTimePicker_dailySales.Value.AddDays(-1);
            SortableBindingList<Data.DailySales> dailysales = new SortableBindingList<Data.DailySales>(API.RestUleyAPI.GetDailySales(dateTimePicker_dailySales.Value));

            dataGrid_dailysales.DataSource = dailysales;
        }

        private void tabControl_products_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabControl_products.SelectedTab == tp_all)
            {
                SortableBindingList<Data.Products> products = new SortableBindingList<Data.Products>(API.RestUleyAPI.GetProducts());

                dataProducts.DataSource = products;
            }
        }

        private void btn_findProducts_Click(object sender, EventArgs e)
        {

        }
    }
}
