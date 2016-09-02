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

        Listener listener;
        Thread listenerThread;

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



        

        private void startListening()
        {
            if (inputFile != null && outputFile != null)
            {
                listener = new Listener(inputFile,outputFile);
                listenerThread = new Thread(listener.Listen);

                // Start the worker thread.
                listenerThread.Start();
            }
        }

        private void startPipeButton_Click(object sender, EventArgs e)
        {
            startListening();
        }

        private void stopPipeButton_Click(object sender, EventArgs e)
        {
            if(listener != null && listenerThread!= null)
            {
                listener.requestStopListening();
                Console.WriteLine(listenerThread.ThreadState);
            }
        }
    }


    public class Listener
    {
        private PipeFile _input;
        private PipeFile _output;

        public Listener(PipeFile input, PipeFile output)
        {
            this._input = input;
            this._output = output;
        }

        // This method will be called when the thread is started. 
        public void Listen()
        {
            Console.WriteLine("START LISTENING");
            while (!_stopListening)
            {
                if(_input.uploaded())
                {
                    if(!outputUpToDate())
                    {
                        Console.WriteLine("*********************************************************");
                        _stopListening = !_stopListening;
                    }
                }
                Thread.Sleep(1000);
            }
            updateOutput();
        }

        public void requestStopListening()
        {
            _stopListening = true;
            Console.WriteLine("Stop listening");
        }

        private bool outputUpToDate()
        {
            if (_input.ModificationDate.Equals(_output.ModificationDate))
                return true;
            return false;
        }

        private void updateOutput()
        {
            Console.WriteLine("Updating output");
            _output.write(_input.read());
            _stopListening = false;
            Listen();
        }

        private bool _stopListening = false;
    }
}