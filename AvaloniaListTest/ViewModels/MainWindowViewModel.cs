using AvaloniaListTest.Views;
using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace AvaloniaListTest.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { this.RaiseAndSetIfChanged(ref name, value); }
        }

        public ObservableCollection<string> Collection { get; }

        private int selectedIndex;
        public int SelectedIndex
        {
            get { return selectedIndex; }
            set { this.RaiseAndSetIfChanged(ref selectedIndex, value); }
        }

        public MainWindowViewModel()
        {
            Name = "Default";
            Collection = new ObservableCollection<string>();
            Collection.Add("Element 1");
            Collection.Add("Element 2");
            Collection.Add("Element 3");
        }

        public void Pick()
        {
            if (SelectedIndex == -1)
                return;
            MainWindowViewModel dc = new MainWindowViewModel();
            dc.Name = Collection[SelectedIndex];
            MainWindow window = new MainWindow
            {
                DataContext = dc,
            };
            window.Show();
        }
    }
}
