using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace FCrypt
{
    class FileSaver
    {
        /// <summary>
        /// This method writes string to a file
        /// </summary>
        /// <param name="path">Folder path</param>
        /// <param name="filename">File name</param>
        /// <param name="content">Content being written into a file</param>
        public void SaveContentInFile(string path, string filename, string content)
        {
            StreamWriter file = new StreamWriter(path+"\\"+filename);
            file.Write(content);
            file.Close();
        }
    }
}
