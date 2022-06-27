using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;

namespace Model
{
    public class Project : ObservableObject
    {

        #region Private Property
        private string _Name = "";
        private string _Type = "";
        #endregion


        public Project()
        {

        }


        public string Name
        {

            get => _Name;
            set => SetProperty(ref _Name, value);

        }
    }
}
