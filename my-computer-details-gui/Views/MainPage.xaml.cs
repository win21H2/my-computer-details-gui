using System;

using my_computer_details_gui.ViewModels;

using Windows.UI.Xaml.Controls;

namespace my_computer_details_gui.Views
{
    public sealed partial class MainPage : Page
    {
        public MainViewModel ViewModel { get; } = new MainViewModel();

        public MainPage()
        {
            InitializeComponent();
        }
    }
}
