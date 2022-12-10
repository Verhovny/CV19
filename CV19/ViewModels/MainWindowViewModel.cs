using CV19.Infrastructure.Commands;
using CV19.ViewModels.BaseVIewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows.Input;

namespace CV19.ViewModels
{
    internal class MainWindowViewModel : ViewModel
    {


        // дизайнер WPF работает с бинарниками, поэтому каждый раз
        // как что-то поменяли в коде надо пересобрать проект

        /// <summary>
        /// Заголовок окна 
        /// </summary>
        #region Title
        private string _Title;

        public string Title
        {
            get => _Title;

            /*
            set
            {
                if(Equals(_Title,value)) return;
                _Title = value;
                OnPropertyChanged();

                Set(ref _Title, value);
            }
            */


            set => Set(ref _Title, value);
        }
        #endregion



        public List<string> Items { get; set; } = new List<string>() { "item1", "item2", "item3" };

        public string SelectedString { get; set; }


        public TestCommand MessageCommand1
        {
            get => new TestCommand();
            set => MessageCommand1 = value;
        }


        private TestCommand messageCommand;
        public TestCommand MessageCommand
        {
            get
            {
                if (messageCommand == null)
                    messageCommand = new TestCommand();
                return messageCommand;
            }
            set
            {
                messageCommand = value;
            }
        }



    }
}
