using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Refit;
using RefitSample.Services;
using Xamarin.Forms;
using Acr.UserDialogs;

using RefitSample.Models;

namespace RefitSample.Views
{
    public partial class MyPage : ContentPage
    {
        List<String> brands = new List<String>();
        List<MakeDown> makeDowns = new List<MakeDown>();

        IUserDialogs dialogs = UserDialogs.Instance;
        public MyPage()
        {
            InitializeComponent();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await CallApi();
        }

        async Task CallApi()
        {
            var apiResponse = RestService.For<IMakeUpApi>("http://makeup-api.herokuapp.com");
            var makeUps = await apiResponse.GetMakeUps();
            foreach (var item in makeUps)
            {
                string x = item.name +" - P"+ item.price.ToString();
                brands.Add(x);

                MakeDown a = new MakeDown();
                //a.brand = item.brand;
                //a.name = item.name;
                //a.price = item.price;

                makeDowns.Add(a);
            }
            ItemsListView.ItemsSource = brands;
            //ItemsListView.ItemsSource = brands;
            dialogs.Alert(makeDowns.ToString());
            //newList.ItemsSource = 
        }
        



    }
}
