using Common;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Dolphin.ViewModel
{
    public class MainWindowViewModel : ObservableObject
    {

        #region Private Property
        private IProject _CurrentProject = null;
        private ObservableCollection<IProject> _ProjectCollection = null;
        private readonly IProjectManageService projectManageService = null;

        #endregion


        public MainWindowViewModel(IProjectManageService _projectManageService)
        {

            this.projectManageService = _projectManageService;

            this.ProjectCollection = this.projectManageService.ProjectCollection;
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



        public ICommand CreateNewProject
        {
            get => new RelayCommand(() =>
            {
                try
                {

                    

                }catch(Exception e)
                {

                }
            });
        }
    }
}
