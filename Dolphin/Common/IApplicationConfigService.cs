using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public interface IApplicationConfigService
    {
        public IConfiguration CurrentConfiguration { get; set; }

        public void SaveConfig();

        public void LoadConfig();

        public string CommonApplicationDataPath { get; }

        public string CommonApplicationDolphinPath { get; }
        
        public string CommonApplicationTempProjectPath { get; }
    }
}
