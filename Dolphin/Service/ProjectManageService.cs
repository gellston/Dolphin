using Common;
using Model;
using Newtonsoft.Json;
using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;

namespace Service
{
    public class ProjectManageService : IProjectManageService
    {

        #region Private Property
        private ObservableCollection<IProject> _ProjectCollection;
        private ObservableCollection<IProjectType> _ProjectTypeCollection;
        private readonly IApplicationConfigService applicationConfigService;
        private IProjectType _SeletedPorjectType;
        #endregion

        public ProjectManageService(IApplicationConfigService _applicationConfigService)
        {
            this.applicationConfigService = _applicationConfigService;

        }




        public ObservableCollection<IProject> ProjectCollection
        {
            get
            {
                _ProjectCollection ??= new ObservableCollection<IProject>();
                return _ProjectCollection;
            }
        }


        public ObservableCollection<IProjectType> ProjectTypeCollection
        {
            get
            {
                _ProjectTypeCollection ??= new ObservableCollection<IProjectType>();
                return _ProjectTypeCollection;
            }
        }


        //public IProjectType SelectedProjectType
        //{
        //    get => _SeletedPorjectType;
        //    set => Set
        //}



        public void CreateProject(string name, IProjectType projectType)
        {

            if(name.Length == 0)
            {
                throw new Exception("Invalid project name");
            }




            if(this.ProjectCollection.Where(x => x.Name == name).Count() > 0)
            {
                throw new Exception("Project name exists");
            }





            //Unique id selection
            string uid = "";
            while (true)
            {
                uid = Guid.NewGuid().ToString();
                if (this.ProjectCollection.Where(x => x.Uid == uid).Count() == 0)
                    break;
            }

            


            IProject project = null;
            switch (projectType.TypeName)
            {
                case "Classification":
                    project = new ClassificationProject()
                    {
                        Name = name,
                        Uid = uid,
                        ProjectType = "Classification"
                    };
                    break;
                case "Segmentation":
                    project = new SegmentationProject()
                    {
                        Name = name,
                        Uid = uid,
                        ProjectType = "Segmentation"
                    };
                    break;

                case "ObjectDetection":
                    throw new Exception("Its not implemented yet");

                default:
                    throw new Exception("Project type is not exists");
            }


            var projectPath = this.applicationConfigService.CommonApplicationTempProjectPath;
            var projectFolderPath = projectPath + uid + Path.DirectorySeparatorChar;


            var sourceImagePath = projectFolderPath + "SourceImage" + Path.DirectorySeparatorChar;
            var labelInfoPath = projectFolderPath + "LabelInfo" + Path.DirectorySeparatorChar;


            try
            {
                Util.FileSystem.DeleteFolder(projectFolderPath);
            }
            catch(Exception e)
            {
                throw new Exception("Temp folder delete failed", e);
            }


            try
            {
                Util.FileSystem.CreateFolder(projectPath);
                Util.FileSystem.CreateFolder(sourceImagePath);
                Util.FileSystem.CreateFolder(labelInfoPath); 
            }
            catch(Exception e)
            {
                throw new Exception("Temp folder creation failed", e);
            }
            
            

            var proejctConfigPath = projectFolderPath + project.Name + ".json";

            try
            {
                var jsonContent = JsonConvert.SerializeObject(project);
                File.WriteAllText(proejctConfigPath, jsonContent);
            }
            catch(Exception e)
            {
                throw new Exception("Json Serialization failed", e);
            }


            this.ProjectCollection.Add(project);

        }
    }
}
