using Common;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;

namespace Model
{
    public class Project : ObservableObject, IProject
    {

        #region Private Property
        private string _Name = "";
        private string _ProjectType = "";
        private string _Uid = "";
        #endregion


        public Project()
        {

        }


        public string Name
        {

            get => _Name;
            set => SetProperty(ref _Name, value);

        }

        public string ProjectType
        {
            get => _ProjectType;
            set => SetProperty(ref _ProjectType, value);
        }

        public string Uid
        {
            get => _Uid;
            set => SetProperty(ref _Uid, value);
        }
    }
}
