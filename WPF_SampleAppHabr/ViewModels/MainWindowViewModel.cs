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
        public string SynchronizedText { get; set; } 
    }
}
