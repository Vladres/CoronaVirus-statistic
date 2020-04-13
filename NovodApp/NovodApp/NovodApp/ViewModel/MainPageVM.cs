using Newtonsoft.Json;
using NovodApp.Model;
using NovodApp.View;
using System.ComponentModel;
using Xamarin.Forms;

namespace NovodApp.ViewModel
{
    public class MainPageVM : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        RestService _restService;
        public INavigation Navigation { get; set; }
        public Item item { get; set; }

        [JsonProperty("cases")]
        public string Cases
        {
            get { return item.cases; }
            set { item.cases = value; OnPropertyChanged("Cases"); }
        }

        [JsonProperty("deaths")]
        public string Deaths
        {
            get { return item.deaths; }
            set { item.deaths = value; OnPropertyChanged("Deaths"); }
        }

        [JsonProperty("recovered")]
        public string Recovered
        {
            get { return item.recovered; }
            set { item.recovered = value; OnPropertyChanged("Recovered"); }
        }
        [System.Obsolete]
        public MainPageVM(INavigation navigation)
        {
            _restService = new RestService();
            item = new Item();
            this.Cases = Cases;
            this.Deaths = Deaths;
            this.Recovered = Recovered;
            Navigation = navigation;
            SearchClick = new Command( () =>  Navigation.PushAsync(new SearchPage(), true));
            MainClick = new Command( () =>  Navigation.PushAsync(new MainPage(),true));
            AboutClick = new Command<string>((url) => Device.OpenUri(new System.Uri(url)));
        }
        [System.Obsolete]
        public MainPageVM(string ex , INavigation navigation)
        {
            _restService = new RestService();
            item = new Item();
            this.Cases = ex;
            this.Deaths = Deaths;
            this.Recovered = Recovered;
            Navigation = navigation;
            SearchClick = new Command(() => Navigation.PushAsync(new SearchPage(), true));
            MainClick = new Command(() => Navigation.PushAsync(new MainPage(), true));
            AboutClick = new Command<string>((url) => Device.OpenUri(new System.Uri(url)));
        }

        [System.Obsolete]
        public MainPageVM()
        {
            item = new Item();
            this.Cases = "";
            this.Deaths = "";
            this.Recovered = "";
            SearchClick = new Command(() => Navigation.PushAsync(new SearchPage(), true));
            AboutClick = new Command<string>((url) => Device.OpenUri(new System.Uri(url)));
        }

        public Command SearchClick { protected set; get; }
        public Command MainClick { protected set; get; }
        public Command AboutClick { protected set; get; }
        public void OnPropertyChanged(string prop = "")
              => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
    }
}
