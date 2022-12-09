using CV19.ViewModels.BaseVIewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

    }
}
