using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public interface IProjectManageService
    {
        public ObservableCollection<IProject> ProjectCollection{get;}

        public ObservableCollection<IProjectType> ProjectTypeCollection { get; }



        public void CreateProject(string name, IProjectType type);
    }
}
