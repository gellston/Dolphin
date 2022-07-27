using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Common
{
    public interface IProjectSelectionViewModel
    {

        public ICommand CloseCommand { get; }

        public ICommand OpenProjectCommand { get; }


        public IProjectType SelectedProjectType { get; set; }


        public ObservableCollection<IProjectType> ProjectTypeCollection { get; set; }


        public string ProjectName { get; set; }


    }
}
