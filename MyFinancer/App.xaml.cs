using MyFinancer.Stores;
using MyFinancer.ViewModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace MyFinancer
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            NavigationStore navigationStore = new NavigationStore();
            navigationStore.CurrentViewModel =new  AutorizationViewModel(navigationStore);

            MainWindow = new MainWindow()
            {
                DataContext = new ViewModelController(navigationStore)
            };
            MainWindow.Show();
            base.OnStartup(e);
        }
    }
}
