using NovodApp.Model;
using System.ComponentModel;
using Newtonsoft.Json;
using Xamarin.Forms;
using NovodApp.View;

namespace NovodApp.ViewModel
{
    public class SearchVM : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public Item item { get; set; }
        public INavigation Navigation { get; set; }
        [JsonProperty("cases")]
        public string Cases
        {
            get { return item.cases; }
            set { item.cases = value; OnPropertyChanged("Cases"); }
        }

        [JsonProperty("country")]
        public string Country
        {
            get { return item.country; }
            set { item.country = value; OnPropertyChanged("Country"); }
        }

        [JsonProperty("deaths")]
        public string Deaths
        {
            get { return item.deaths; }
            set { item.deaths = value; OnPropertyChanged("Deaths"); }
        }

        [JsonProperty("todayCases")]
        public string TodayCases
        {
            get { return item.todayCases; }
            set { item.todayCases = value; OnPropertyChanged("Location"); }
        }

        [JsonProperty("recovered")]
        public string Recovered
        {
            get { return item.recovered; }
            set { item.recovered = value; OnPropertyChanged("Recovered"); }
        }

        [JsonProperty("active")]
        public string Active
        {
            get { return item.active; }
            set { item.active = value; OnPropertyChanged("Active"); }
        }
        [JsonProperty("critical")]
        public string Critical
        {
            get { return item.critical; }
            set { item.critical = value; OnPropertyChanged("Critical"); }
        }

        public SearchVM(string Cases , string Country, string Deaths, string TodayCases ,string Recovered , string Active,string Critical)
        {
            item = new Item();
            this.Cases = Cases;
            this.Country = Country;
            this.Deaths = Deaths;
            this.TodayCases = TodayCases;
            this.Recovered = Recovered;
            this.Active = Active;
            this.Critical = Critical;
        }

        public SearchVM(INavigation navigation)
        {
            item = new Item();
            this.Cases = "";
            this.Country = "";
            this.Deaths = "";
            this.TodayCases = "";
            this.Recovered = "";
            this.Active = "";
            this.Critical = "";
            Navigation = navigation;
        }

        public SearchVM()
        {
            item = new Item();
            this.Cases = "";
            this.Country = "";
            this.Deaths = "";
            this.TodayCases = "";
            this.Recovered = "";
            this.Active = "";
            this.Critical = "";
        }
        public SearchVM(string ex, INavigation Navigation)
        {
            item = new Item();
            this.Country = "sorry not found :(";
            this.Navigation = Navigation;
        }
       
        public Command AboutClick { protected set; get; }
        public void OnPropertyChanged(string prop = "")
              => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
    }
}
