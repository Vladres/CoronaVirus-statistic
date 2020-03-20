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
        RestService _restService;

        public MainPage()
        {
            InitializeComponent();
            _restService = new RestService();
            BindingContext = new MainPageVM(Navigation);
        }
        async void OnGetButtonClicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(_userEntry.Text))
            {
                ItemVM itemData = await _restService.GetInfoData(GenerateRequestUri(Constants.OpenMapEndpoint));
                if (itemData != null)
                    BindingContext = itemData;
                else
                    BindingContext = new ItemVM("Sorry not found");
            }
        }

        string GenerateRequestUri(string endpoint)
        {
            string requestUri = endpoint;
            requestUri += $"{_userEntry.Text}";
            return requestUri;
        }

    }
}
