using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolphin.ViewModel
{
    public class ViewModelLocator
    {


        public ViewModelLocator()
        {

        }



        public ObservableObject MainWindowViewModel
        {
            get => Ioc.Default.GetService<MainWindowViewModel>();
        }
        

    }
}
