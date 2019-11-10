using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rorschach_Launcher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_selectDirectory_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "Choose a folder to read pictures from!";
            fbd.ShowNewFolderButton = false;
            fbd.RootFolder = Environment.SpecialFolder.MyComputer;
            if(fbd.ShowDialog() == DialogResult.OK)
            {
                Console.WriteLine(fbd.SelectedPath);
                textBox_folder.Text = fbd.SelectedPath;
            }
        }

        private void button_launch_Click(object sender, EventArgs e)
        {
            string exePath = textBox_exe.Text;

            // Values to send to Unity
            string patient = textBox_patient.Text;
            string folderPath = textBox_folder.Text;
            string frame = numericUpDown_frame.Value.ToString();
            string folderToLog = textBox_folderToLog.Text;
            string nameOfFile = textBox_nameOfFile.Text;

            if(!nameOfFile.Contains(".txt"))
            {
                nameOfFile += ".txt";
            }

            ProcessStartInfo info = new ProcessStartInfo();
            info.FileName = exePath;
            info.Arguments = folderPath + " " + frame + " " + folderToLog + " " + nameOfFile + " " + patient;
            try
            {
                Process.Start(info);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Something went wrong...");
                Console.WriteLine(ex.Message);
            }
        }

        private void button_exe_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select Rorschach_VR.exe";

            if(ofd.ShowDialog() == DialogResult.OK)
            {
                textBox_exe.Text = ofd.FileName;
            }
        }

        private void button_folderToLog_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "Choose a folder to log into!";
            fbd.ShowNewFolderButton = true;
            fbd.RootFolder = Environment.SpecialFolder.MyComputer;
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                Console.WriteLine(fbd.SelectedPath);
                textBox_folderToLog.Text = fbd.SelectedPath;
            }
        }
    }
}
