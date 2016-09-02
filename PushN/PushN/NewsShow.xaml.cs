using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Threading.Tasks;
using System.Net.Http;
using System.Net;
using Newtonsoft.Json;



using Xamarin.Forms;

namespace PushN
{
    public partial class NewsShow : ContentPage
    {
        static string baseUrl = "http://namespace.azurewebsites.net/api/";
        public NewsShow()
        {
            InitializeComponent();
            bb.Clicked += async (s, e) =>
            {
                MainListView.ItemsSource = null;
                List<Entities.News> asdf = await GetNewsListAsync("GetSpeciality");
                MainListView.ItemsSource = asdf;
            };
        }
        protected override void OnAppearing()
        {
            Device.BeginInvokeOnMainThread(async () => {
                string apiUrl = "GetSpeciality";
                var result = await GetNewsListAsync(apiUrl);
                MainListView.ItemsSource = result;

            });
            base.OnAppearing();
        }

        public static async Task<List<Entities.News>> GetNewsListAsync(string apiUrl)
        {

            string urls = baseUrl + apiUrl;
            HttpClient webclient = new HttpClient();
            string asad = await webclient.GetStringAsync(urls);

            List<Entities.News> ress = new List<Entities.News>();
            dynamic deserializedDynamic = JsonConvert.DeserializeObject<List<Entities.News>>(asad);

            //int coder = deserializedDynamic.Code;
            ress = deserializedDynamic;
            //ress = deserializedDynamic.Result;


            // string res1 = ress[0].Title;
            //string full = res1.Salutation + res1.FirstName + res1.MiddleName + res1.LastName;
            //string sss = ress[0].FirstName;
            //int coder = deserializedDynamic.Code;

            return ress;
        }

    }
}
