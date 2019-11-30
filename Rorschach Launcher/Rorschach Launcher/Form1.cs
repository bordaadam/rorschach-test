using Microsoft.Win32;
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
            LoadSettings();
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
            SaveSettings(patient, folderPath, frame, folderToLog, nameOfFile, exePath);

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

        private void SaveSettings(string patient, string folderPath, string frame, string folderToLog, string nameOfFile, string exePath)
        {
            RegistryKey key = Registry.CurrentUser.CreateSubKey(@"Rorschach\Settings");
            key.SetValue("patient", patient);
            key.SetValue("folderPath", folderPath);
            key.SetValue("frame", frame);
            key.SetValue("folderToLog", folderToLog);
            key.SetValue("nameOfFile", nameOfFile);
            key.SetValue("exePath", exePath);
        }

        private void LoadSettings()
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Rorschach\Settings");

            if(key != null)
            {
                textBox_patient.Text = key.GetValue("patient").ToString();
                textBox_folder.Text = key.GetValue("folderPath").ToString();
                textBox_exe.Text = key.GetValue("exePath").ToString();
                numericUpDown_frame.Value = int.Parse(key.GetValue("frame").ToString());
                textBox_folderToLog.Text = key.GetValue("folderToLog").ToString();
                textBox_nameOfFile.Text = key.GetValue("nameOfFile").ToString();

            }
        }

        private void openLogFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using(var w = new OpenLogFileWindow())
            {
                w.ShowDialog();
            }
        }
    }
}
