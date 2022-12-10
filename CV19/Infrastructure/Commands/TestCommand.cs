using CV19.Infrastructure.Commands.Base;
using CV19.Views.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace CV19.Infrastructure.Commands
{
    internal class TestCommand : Command
    {

        /*
          при загрузке окна он проверит возвращаемое значение CanExecute,
          и если он вернет true, то он включит элемент управления кнопки,
          и метод Execute готов к использованию, 
          в противном случае элемент управления кнопки отключен.
         */

        public override bool CanExecute(object? parameter)
        {
            return true;
        }


        // CommandParameter отправляется как для событий CanExecute, так и для событий Execute.

        public override void Execute(object? parameter)
        {
            //MessageBox.Show("Логика команды");

            MessageBox.Show(CanExecute(null).ToString());

            new Window1(parameter).Show();

            Application.Current.MainWindow.Close();

        }
    }
}
