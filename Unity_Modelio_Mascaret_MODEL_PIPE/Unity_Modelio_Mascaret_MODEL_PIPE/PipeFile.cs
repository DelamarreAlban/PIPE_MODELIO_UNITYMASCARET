using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unity_Modelio_Mascaret_MODEL_PIPE
{
    public class PipeFile
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
            get {return System.IO.File.GetLastWriteTime(Filepath);}
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

        protected virtual bool IsFileLocked(FileInfo file)
        {
            FileStream stream = null;

            try
            {
                stream = file.Open(FileMode.Open, FileAccess.Read, FileShare.None);
            }
            catch (IOException)
            {
                //the file is unavailable because it is:
                //still being written to
                //or being processed by another thread
                //or does not exist (has already been processed)
                if (stream != null)
                    stream.Close();
                return true;
            }
            if (stream != null)
                stream.Close();
            //file is not locked
            return false;
        }

        public string read()
        {
            FileInfo file = new FileInfo(Filepath);
            while(IsFileLocked(file))
            {
                //Nothing
            }
            return System.IO.File.ReadAllText(Filepath);
        }

        public void write(string content)
        {
            System.IO.File.WriteAllText(Filepath, "");
            System.IO.File.WriteAllText(Filepath, content);
        }

    }
}
