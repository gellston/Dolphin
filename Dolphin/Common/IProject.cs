using System;

namespace Common
{
    public interface IProject
    {
        public string Name { get; set; }

        public string ProjectType { get; set; }

        public string Uid { get; set; }
    }
}
