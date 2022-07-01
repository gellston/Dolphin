using Common;
using System;
using System.Collections.ObjectModel;

namespace Service
{
    public class ProjectManageService
    {

        #region Private Property
        ObservableCollection<IProject> _ProjectCollection = null;
        #endregion

        public ProjectManageService()
        {

        }



        public ObservableCollection<IProject> ProjectCollection
        {
            get
            {
                _ProjectCollection ??= new ObservableCollection<IProject>();
                return _ProjectCollection;
            }
        }


    }
}
