using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using System;
using System.Windows.Input;

namespace ViewModel
{
    public class ProjectSelectionViewModel : ObservableObject
    {

        private string _CurrentSelectedProjectName = "";

        public ProjectSelectionViewModel()
        {

        }


        public string CurrentSelectedProjectName
        {
            get => _CurrentSelectedProjectName;
            set => SetProperty(ref _CurrentSelectedProjectName, value);
        }

        public ICommand ChangeProjectCommand
        {
            get => new RelayCommand<string>((name) =>
            {
                this.CurrentSelectedProjectName = name;
            });
        }


        public 
    }
}
