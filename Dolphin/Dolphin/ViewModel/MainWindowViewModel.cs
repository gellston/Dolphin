using Common;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.DependencyInjection;
using Microsoft.Toolkit.Mvvm.Input;
using Microsoft.Toolkit.Mvvm.Messaging;
using Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Dolphin.ViewModel
{
    public class MainWindowViewModel : ObservableRecipient, IRecipient<PopupMessage>
    {

        #region Private Property
        private IProject _CurrentProject = null;
        private ObservableCollection<IProject> _ProjectCollection = null;
        private readonly IProjectManageService projectManageService = null;
        private bool _IsOpenPopup = false;
        private int _PopupWidth = 0;
        private int _PopupHeight = 0;
        private object _PopupContent = null;
        #endregion


        public MainWindowViewModel(IProjectManageService _projectManageService)
        {

            this.projectManageService = _projectManageService;

            this.ProjectCollection = this.projectManageService.ProjectCollection;


            this.IsActive = true;
        }



        #region Public Property

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

        public bool IsOpenPopup
        {
            get => _IsOpenPopup;
            set => SetProperty(ref _IsOpenPopup, value);
        }

        public int PopupWidth
        {
            get => _PopupWidth;
            set => SetProperty(ref _PopupWidth, value);
        }

        public int PopupHeight
        {
            get => _PopupHeight;
            set => SetProperty(ref _PopupHeight, value);
        }

        public object PopupContent
        {
            get => _PopupContent;
            set => SetProperty(ref _PopupContent, value);
        }
        #endregion




        #region Command
        public ICommand CreateNewProjectCommand
        {
            get => new RelayCommand(() =>
            {
                try
                {
                    var selectionViewModel = Ioc.Default.GetService<IProjectSelectionViewModel>();
                    Messenger.Send(new PopupMessage()
                    {
                        IsOpen = true,
                        Content = selectionViewModel,
                        Height = 480,
                        Width = 1024
                    });

                }
                catch (Exception e)
                {

                }
            });
        }

        public void Receive(PopupMessage message)
        {
            this.PopupWidth = message.Width;
            this.PopupHeight = message.Height;
            this.IsOpenPopup = message.IsOpen;
            this.PopupContent = message.Content;
        }
        #endregion


    }
}
