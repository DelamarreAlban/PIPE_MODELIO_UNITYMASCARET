using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unity_Modelio_Mascaret_MODEL_PIPE
{
    class PipeFile
    {
        string folder;
        public string Folder
        {
            get {return folder;}
            set{folder = value;}
        }

        string file;
        public string File
        {
            get{return file; }
            set{file = value; }
        }

        string extension;
        public string Extension
        {
            get{ return extension;}
            set{ extension = value;}
        }

        public string Filepath
        {
            get { return folder +@"\" + file + extension; }
        }

        private DateTime modificationDate;
        public DateTime ModificationDate
        {
            get {return modificationDate; }
            set{ modificationDate = value; }
        }

        public bool uploaded()
        {
            if(DateTime.Compare(modificationDate, System.IO.File.GetLastWriteTime(Filepath)) < 0)
            {
                Console.WriteLine("NEW MODIFICATION !");
                modificationDate = System.IO.File.GetLastWriteTime(Filepath);
                Console.WriteLine(modificationDate.ToString("dd/MM/yy HH:mm:ss"));
                return true;
            }
            return false;
        }


        public string read()
        {
            //Check if file is open elsewhere !!!!!
            return System.IO.File.ReadAllText(Filepath);
        }

        public void write(string content)
        {
            System.IO.File.WriteAllText(Filepath, "");
            System.IO.File.WriteAllText(Filepath, content);
        }

    }
}
