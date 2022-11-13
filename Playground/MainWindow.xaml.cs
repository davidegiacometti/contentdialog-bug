// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

using System;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

namespace Playground
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            page.DataContext = new MainViewModel();
        }

        private async void openDialog_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new ContentDialog
            {
                XamlRoot = page.XamlRoot,
                Title = "Dialog from code behind",
                PrimaryButtonText = "Ok",
            };

            await dialog.ShowAsync();
        }

        private async void openDialogAlt_Click(object sender, RoutedEventArgs e)
        {
            await dialog.ShowAsync();
        }
    }
}
