using System;
using System.IO;

namespace Util
{
    public class FileSystem
    {


        public static void DeleteFolder(string path)
        {
            try
            {
                System.IO.DirectoryInfo di = new DirectoryInfo(path);

                foreach (FileInfo file in di.GetFiles())
                {
                    file.Delete();
                }
                foreach (DirectoryInfo dir in di.GetDirectories())
                {
                    dir.Delete(true);
                }

            }
            catch(Exception e)
            {
                throw new Exception("Folder delete failed", e);
            }

        }

        public static void CreateFolder(string path)
        {
            try
            {

                Directory.CreateDirectory(path);

            }catch(Exception e)
            {
                throw new Exception("Folder creation failed", e);
            }
        }

    }
}
