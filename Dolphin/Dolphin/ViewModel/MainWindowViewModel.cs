using Common;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolphin.ViewModel
{
    public class MainWindowViewModel : ObservableObject
    {

        #region Private Property
        private IProject _CurrentProject = null;
        private ObservableCollection<IProject> _ProjectCollection = null;
        #endregion


        public MainWindowViewModel()
        {

        }


        public IProject CurrentProject
        {
            get => _CurrentProject;
            set => SetProperty(ref _CurrentProject, value);
        }

        public ObservableCollection<IProject> ProjectCollection
        {
            get => _ProjectCollection;
            set => SetProperty(ref _ProjectCollection, value);
        }



    }
}
