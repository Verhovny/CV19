using CV19;
using CV19.ViewModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;


namespace CV19
{

    public partial class App : Application
    {

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            CV19.MainWindow mv = new CV19.MainWindow();
           
            //MainWindowViewModel vm = new MainWindowViewModel();
            //mv.DataContext = vm;

            mv.Show();
        }




    }
}
