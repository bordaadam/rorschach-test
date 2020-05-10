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
        string startingDate;


        Recorder recorder;
        public Form1()
        {
            InitializeComponent();
            LoadSettings();
            startingDate = DateTime.Now.ToString("HH:mm:ss.fff");
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
            if(ValidateForm())
            {
                string exePath = textBox_exe.Text;
                string folderPath = textBox_folder.Text;
                string frame = numericUpDown_frame.Value.ToString();
                string folderToLog = textBox_folderToLog.Text;
                string nameOfFile = textBox_nameOfFile.Text + "." + dropDown.SelectedItem.ToString();
                SaveSettings(folderPath, frame, folderToLog, nameOfFile, exePath);

                ProcessStartInfo info = new ProcessStartInfo();
                info.FileName = exePath;
                info.Arguments = folderPath + " " + frame + " " + folderToLog + " " + nameOfFile + " " + startingDate;
                try
                {
                    Process.Start(info);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error occurred during starting Unity process...", "Error", MessageBoxButtons.OK);
                    Console.WriteLine($"Something went wrong: {ex.Message}");

                }
            } else
            {
                MessageBox.Show("You need to fill all of the input of this form!", "Error", MessageBoxButtons.OK);
            }
        }

        private bool ValidateForm()
        {
            if(textBox_exe.TextLength > 0 && textBox_folder.TextLength > 0 && textBox_folderToLog.TextLength > 0 && textBox_nameOfFile.TextLength > 0)
            {
                return true;
            }

            return false;
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

        private void SaveSettings(string folderPath, string frame, string folderToLog, string nameOfFile, string exePath)
        {
            RegistryKey key = Registry.CurrentUser.CreateSubKey(@"Rorschach\Settings");
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(toggle.Checked)
            {
                toggle.Text = "STOP RECORDING!";
                toggle.ForeColor = Color.Red;
                string fileName = DateTime.Now.ToString("yyyy-MM-dd-HH-mm") + ".wav";
                recorder = new Recorder(0, textBox_folderToLog.Text, fileName);
                recorder.StartRecording();
                startingDate = DateTime.Now.ToString("HH:mm:ss.fff");

            } else
            {
                toggle.Text = "RECORD!";
                toggle.ForeColor = Color.Black;
                recorder.RecordEnd();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dropDown.SelectedItem = dropDown.Items[0];
        }

    }
}
