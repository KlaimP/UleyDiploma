using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UleyDiploma.Views
{
    public partial class ProductsView : UserControl
    {
        public ProductsView()
        {
            InitializeComponent();
        }

        private void btn_allProducts_Click(object sender, EventArgs e)
        {
            products_panel.Controls.Clear();
            products_panel.Controls.Add(new Views.Products.selectProductsView() { Dock = DockStyle.Fill });
        }

        private void btn_addProducts_Click(object sender, EventArgs e)
        {
            products_panel.Controls.Clear();
            products_panel.Controls.Add(new Views.Products.addProductsView() { Dock = DockStyle.Fill });
        }

        private void ProductsView_Load(object sender, EventArgs e)
        {
            products_panel.Controls.Clear();
            products_panel.Controls.Add(new Views.Products.selectProductsView() { Dock = DockStyle.Fill });
        }

        private void btn_dailysales_Click(object sender, EventArgs e)
        {
            products_panel.Controls.Clear();
            products_panel.Controls.Add(new Views.Products.dailysalesView() { Dock = DockStyle.Fill });
        }
    }
}
