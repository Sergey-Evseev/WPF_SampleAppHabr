using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_SampleAppHabr.ViewModels
{
    //вьюмодель для баового класса, наследуется от базовой вьюмодели
    public class MainWindowViewModel : BaseViewModel
    {   //свойство на которое байндиться текст контролов
        //public string SynchronizedText { get; set; }

        //модификация текста  вьюмодели главного окна,
        //чтобы она отслеживала изменение свойства SynchronizedText
        //и вызывала событие PropertyChanged
        private string _synchronizedText; //скрытое поле для хранения текста

        public string SynchronizedText
        {
            get => _synchronizedText;
            set
            {
                _synchronizedText = value;
                OnPropertyChanged(nameof(SynchronizedText));
            }
        }
    }
}
