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
            fbd.RootFolder = Environment.SpecialFolder.MyDocuments;
            if(fbd.ShowDialog() == DialogResult.OK)
            {
                Console.WriteLine(fbd.SelectedPath);
                textBox.Text = fbd.SelectedPath;
            }
        }

        private void button_launch_Click(object sender, EventArgs e)
        {
            // Values to send to Unity
            string folderPath = textBox.Text;
            string frame = numericUpDown_frame.Value.ToString();

            // TODO: send
            ProcessStartInfo info = new ProcessStartInfo();
            info.FileName = "Rorschach_VR";
            info.Arguments = "elso masodik harmadik??";
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
    }
}
