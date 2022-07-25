using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using View;

namespace Service
{
    public class DialogService
    {

        public void OpenDialog(object viewModel)
        {
            DialogWindowView window = new DialogWindowView();
            window.DataContext = viewModel;
            window.ShowDialog();
        }

    }
}
