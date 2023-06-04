using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using UleyDiploma.Data;

namespace UleyDiploma.API
{
    internal class RestUleyAPI
    {
        static string url = "http://192.168.56.112:3000/rpc/";

        public static List<Products> GetProducts()
        {

            var client = new RestClient(url + "get_products");
            var request = new RestRequest();

            var response = client.Get(request);

            var result = JsonConvert.DeserializeObject<List<Data.Products>>(response.Content);

            return result;
        }

        public static List<Catalogs> GetCatalog()
        {

            var client = new RestClient(url + "get_catalogs");
            var request = new RestRequest();

            var response = client.Get(request);

            var result = JsonConvert.DeserializeObject<List<Data.Catalogs>>(response.Content);

            return result;
        }

        public static RestResponse AddProduct(Products prd)
        {
            try
            {
                var client = new RestClient(url + "add_product");
                var request = new RestRequest();

                request.AddParameter("i_upc", prd.upc);
                request.AddParameter("i_name", prd.name);
                request.AddParameter("i_price", prd.price);
                request.AddParameter("i_discount", prd.discount);
                request.AddParameter("i_catalog", prd.catalog);
                request.AddParameter("i_description", prd.description);
                request.AddParameter("i_quantity", prd.quantity);
                request.AddParameter("i_application_visible", prd.application_visible);
                request.AddParameter("i_preview", null);

                var response = client.Post(request);

                return response;
            }
            catch
            {
                DialogResult res = MessageBox.Show("Произошла ошибка. Проверьте правильность заполненных данных или возможно такой продукт уже имеется", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public static List<DailySales> GetDailySales(DateTime date)
        {

            var client = new RestClient(url + "get_dailysales");
            var request = new RestRequest();

            request.AddParameter("i_date", date.ToString("yyyy/MM/dd"));

            var response = client.Get(request);

            var result = JsonConvert.DeserializeObject<List<Data.DailySales>>(response.Content);

            return result;
        }
    }
}
