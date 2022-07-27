using Common;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using Microsoft.Toolkit.Mvvm.Messaging;
using Model;
using System;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace ViewModel
{
    public class ProjectSelectionViewModel : ObservableRecipient, IProjectSelectionViewModel
    {


        #region Private Property
        private int _CurrentSelectedProjectIndex = -1;
        private readonly IProjectManageService projectManageService;
        private string _ProjectName;
        private IProjectType _SelectedProjectType;
        private ObservableCollection<IProjectType> _ProjectTypeCollection;
        #endregion

        public ProjectSelectionViewModel(IProjectManageService _projectManageService)
        {

            this.projectManageService = _projectManageService;



            this.ProjectTypeCollection = this.projectManageService.ProjectTypeCollection;


            this.IsActive = true;
        }


        #region Public Property
        //public int CurrentSelectedProjectIndex
        //{
        //    get => _CurrentSelectedProjectIndex;
        //    set => SetProperty(ref _CurrentSelectedProjectIndex, value);
        //}

        public string ProjectName
        {
            get => _ProjectName;
            set => SetProperty(ref _ProjectName, value);
        }

        public IProjectType SelectedProjectType
        {
            get => _SelectedProjectType;
            set => SetProperty(ref _SelectedProjectType, value);
        }

        #endregion

        #region Collection
        public ObservableCollection<IProjectType> ProjectTypeCollection
        {
            get => _ProjectTypeCollection;
            set => SetProperty(ref _ProjectTypeCollection, value);
        }
        #endregion


        #region Command

        public ICommand CreateProjectCommand
        {
            get => new RelayCommand(() =>
            {

                try
                {
                    this.projectManageService.CreateProject(this.ProjectName, this.SelectedProjectType);

                }catch(Exception e)
                {
                    Util.ToastMessageHelper.ShowSuccessMessage();
                }

                Messenger.Send(new PopupMessage()
                {
                    IsOpen = false
                });

            });
        }


        public ICommand OpenProjectCommand
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


        public ICommand CloseCommand
        {
            get => new RelayCommand(() =>
            {

                Messenger.Send(new PopupMessage()
                {
                    IsOpen = false
                });

            });
        }


        #endregion
    }
}
