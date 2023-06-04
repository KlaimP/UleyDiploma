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
using UleyDiploma.Data;

namespace UleyDiploma.Views.Products
{
    public partial class dailysalesView : UserControl
    {
        public dailysalesView()
        {
            InitializeComponent();
        }

        private void dailysalesView_Load(object sender, EventArgs e)
        {
            SortableBindingList<Data.DailySales> dailysales = new SortableBindingList<Data.DailySales>(API.RestUleyAPI.GetDailySales(DateTime.Now));

            dataGrid_dailysales.DataSource = dailysales;

            dateTimePicker_dailySales.Value = DateTime.Now;
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
            dateTimePicker_dailySales.Value =  dateTimePicker_dailySales.Value.AddDays(-1);
            SortableBindingList<Data.DailySales> dailysales = new SortableBindingList<Data.DailySales>(API.RestUleyAPI.GetDailySales(dateTimePicker_dailySales.Value));

            dataGrid_dailysales.DataSource = dailysales;
        }
    }
}
