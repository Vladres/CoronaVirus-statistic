using NovodApp.Model;
using System.ComponentModel;

namespace NovodApp.ViewModel
{
    class ItemVM : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public Item item { get; set; }

        public string ImageURl
        {
            get { return item.imageURl; }
            set { item.imageURl = value; OnPropertyChanged("ImageURl"); }
        }
        public string Login
        {
            get { return item.login; }
            set { item.login = value; OnPropertyChanged("Login"); }
        }
        public string Email
        {
            get { return item.email; }
            set { item.email = value; OnPropertyChanged("Email"); }
        }
        public string Location
        {
            get { return item.location; }
            set { item.location = value; OnPropertyChanged("Location"); }
        }
        public ItemVM(string ImageURl , string Login, string Email,string Location)
        {
            item = new Item();
            this.ImageURl = ImageURl;
            this.Login = Login;
            this.Email = Email;
            this.Location = Location;
        }
        public ItemVM()
        {
            item = new Item();
            this.ImageURl = "";
            this.Login = "";
            this.Email = "";
            this.Location = "";
        }
        public void OnPropertyChanged(string prop = "")
              => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
    }
}
