using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace NovodApp.ViewModel
{
    class MainPageVM : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public INavigation Navigation { get; set; }
        public bool VisiblyEntry { get; set; }

        public ObservableCollection<ItemVM> items { get; set; }
        public MainPageVM(INavigation navigation)
        {
            Navigation = navigation;
            items = new ObservableCollection<ItemVM>();
            items.Add(new ItemVM("anonim.png", "Vlad1" , "vladres121@gmail.com" , "Ukraine"));
            items.Add(new ItemVM("anonim.png", "Vlad2", "vladres121@gmail.com", "Ukraine"));
            items.Add(new ItemVM("anonim.png", "Vlad3", "vladres121@gmail.com", "Ukraine"));
            items.Add(new ItemVM("anonim.png", "Vlad4", "vladres121@gmail.com", "Ukraine"));
            VisiblyEntry = false;
            SearchClick = new Command (() => { VisiblyEntry = !VisiblyEntry;OnPropertyChanged("VisiblyEntry"); });

        }
        public ICommand SearchClick { private set; get; }
        public void OnPropertyChanged(string prop = "")
              => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));

    }
}
