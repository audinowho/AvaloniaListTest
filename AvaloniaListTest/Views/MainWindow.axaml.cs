using Avalonia;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace AvaloniaListTest.Views
{
    public class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

        public void lbxCollection_DoubleClick(object sender, RoutedEventArgs e)
        {
            ViewModels.MainWindowViewModel viewModel = (ViewModels.MainWindowViewModel)DataContext;
            if (viewModel == null)
                return;
            viewModel.Pick();
        }

        public void btnPick_Click(object sender, RoutedEventArgs e)
        {
            ViewModels.MainWindowViewModel viewModel = (ViewModels.MainWindowViewModel)DataContext;
            if (viewModel == null)
                return;
            viewModel.Pick();
        }
    }
}
