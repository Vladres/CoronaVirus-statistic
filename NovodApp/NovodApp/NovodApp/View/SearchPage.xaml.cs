using NovodApp.ViewModel;
using System;
using System.ComponentModel;
using WebServiceTutorial;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NovodApp.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SearchPage : ContentPage
    {
        RestService _restService;

        public SearchPage()
        {
            InitializeComponent();
            _restService = new RestService();
            NavigationPage.SetHasNavigationBar(this, false);
            BindingContext = new SearchVM(Navigation);
        }
        async void OnGetInfo(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(_userEntry.Text))
            {
                SearchVM itemData = await _restService.GetInfoData(GenerateRequestUri(Constants.OpenMapEndpoint));
                if (itemData != null)
                    BindingContext = itemData;
                else
                    BindingContext = new SearchVM("Sorry not found", Navigation);
            }
        }
        string GenerateRequestUri(string endpoint)
        {
            string requestUri = endpoint;
            requestUri += $"countries/{_userEntry.Text}";
            return requestUri;
        }
    }
}