using Common;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class ApplicationConfigService : ObservableObject, IApplicationConfigService
    {

        #region Private Property
        private IConfiguration _currentConfiguration = null;

        #endregion

        public ApplicationConfigService()
        {



            var temp = this.CommonApplicationDolphinPath;
            temp = this.CommonApplicationTempProjectPath;

        }


        
        #region Public Property


        public string CommonApplicationDataPath
        {
            get{
                string folder = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);

                return folder;
            }
        }


        public string CommonApplicationDolphinPath
        {
            get
            {
                string tempFolder = Path.Combine(this.CommonApplicationDataPath, "DolphinData") + Path.DirectorySeparatorChar;
                Directory.CreateDirectory(tempFolder);
                return tempFolder;
            }
        }

        public string CommonApplicationTempProjectPath
        {
            get
            {
                string tempFolder = Path.Combine(CommonApplicationDolphinPath, "TempProject") + Path.DirectorySeparatorChar;
                return tempFolder;
            }
        }

        public string CommonApplicationProjectPath
        {
            get
            {
                string tempFolder = Path.Combine(CommonApplicationDolphinPath, "Project") + Path.DirectorySeparatorChar;
                return tempFolder;
            }
        }



        public IConfiguration CurrentConfiguration
        {
            get => _currentConfiguration;
            set => SetProperty(ref _currentConfiguration, value);
        }
        #endregion

        #region Function
        public void SaveConfig()
        {

        }


        public void LoadConfig()
        {

        }
        #endregion

    }
}
