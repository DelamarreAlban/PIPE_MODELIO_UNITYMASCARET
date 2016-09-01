using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unity_Modelio_Mascaret_MODEL_PIPE
{
    public partial class Unity_Modelio_Mascaret_MODEL_PIPE : Form
    {

        private PipeFile inputFile;
        private PipeFile outputFile;

        private DateTime lastmodification;

        public Unity_Modelio_Mascaret_MODEL_PIPE()
        {
            InitializeComponent();
        }

        private void setInputButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "xmi files (*.xmi)|*.xmi|All files (*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                inputFile = new PipeFile();
                string filepath = ofd.FileName;
                inputFile.Folder = Path.GetDirectoryName(filepath);
                inputFile.File = Path.GetFileNameWithoutExtension(filepath);
                inputFile.Extension = Path.GetExtension(filepath);

                Console.WriteLine("Input file path : " + filepath);
                inputfileTextBox.Text = filepath;
            }

        }

        private void setOutputButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                outputFile = new PipeFile();
                string filepath = ofd.FileName;
                outputFile.Folder = Path.GetDirectoryName(filepath);
                outputFile.File = Path.GetFileNameWithoutExtension(filepath);
                outputFile.Extension = Path.GetExtension(filepath);

                Console.WriteLine("output file path : " + filepath);
                outputfileTextBox.Text = filepath;
            }
        }

        private bool outputUpToDate()
        {
            if (inputFile.read().Equals(outputFile.read()))
                return true;
            return false;
        }

        private void updateOutput()
        {
            outputFile.write(inputFile.read());
            listen();
        }

        private void listen()
        {
            if (inputFile != null && outputFile != null)
            {
                while (outputUpToDate())
                {
                    if (inputFile.uploaded())
                    {
                        Console.WriteLine("*********************************************************");

                    }
                }
                updateOutput();
            }
        }

        private void startPipeButton_Click(object sender, EventArgs e)
        {
            listen();
        }



        private void stopPipeButton_Click(object sender, EventArgs e)
        {

        }
    }
}