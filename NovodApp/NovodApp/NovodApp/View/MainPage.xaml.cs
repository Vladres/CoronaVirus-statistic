using NovodApp.ViewModel;
using System;
using System.ComponentModel;
using WebServiceTutorial;
using Xamarin.Forms;

namespace NovodApp
{
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        
        public MainPage() 
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            this.OnGetInfo();
        }

        async void OnGetInfo()
        {
            RestService _restService = new RestService();
            MainPageVM itemData = await _restService.GetInfo(Constants.OpenMapEndpoint + "all");
            if (itemData != null)
            {
                itemData.Navigation = Navigation;
                BindingContext = itemData;
            }
                
            else
                BindingContext = new MainPageVM("Sorry not found", Navigation);
        }

    }
}
