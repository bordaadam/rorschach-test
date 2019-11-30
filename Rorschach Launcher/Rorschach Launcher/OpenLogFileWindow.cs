using NAudio.Wave;
using NAudio.Wave.SampleProviders;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rorschach_Launcher
{
    public partial class OpenLogFileWindow : Form
    {
        private string filePath;
        private string _audioPath;
        private System.Media.SoundPlayer player;

        private IList<Row> data = new List<Row>();
        public OpenLogFileWindow()
        {
            InitializeComponent();
        }

        private void button_open_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select a log file!";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                filePath = ofd.FileName;
            }

            System.IO.StreamReader file = new System.IO.StreamReader(filePath);
            string line;
            int counter = 1;

            while ((line = file.ReadLine()) != null)
            {
                
                if (counter <= 2)
                {
                    if(counter == 1)
                    {
                        counter++;
                        continue;
                        //TODO: páciens infó!
                    } else if(counter == 2)
                    {
                        _audioPath = line;
                        player = new System.Media.SoundPlayer(_audioPath);
                        player.Load();
                        counter++;
                        continue;
                    }
                }


                string[] dataSlices = line.Split(';');
                this.data.Add(new Row()
                {
                    Image = dataSlices[0],
                    Start = dataSlices[1],
                    End = dataSlices[2],
                    Frame = dataSlices[3],
                    AudioTime = dataSlices[4]
                }) ;
                

            }

            gridView.DataSource = this.data;
            DataGridViewButtonColumn button = new DataGridViewButtonColumn();
            button.HeaderText = "Audio";
            button.Text = "Play!";
            button.UseColumnTextForButtonValue = true;
            gridView.Columns.Add(button);

            gridView.Visible = true;
        }

        private void PlayAudio(double whereFrom)
        {
            var file = new AudioFileReader(_audioPath);
            var trimmed = new OffsetSampleProvider(file);
            trimmed.SkipOver = TimeSpan.FromSeconds(whereFrom);
            trimmed.Take = TimeSpan.FromSeconds(5);

            var player = new WaveOutEvent();
            player.Init(trimmed);
            player.Play();

        }

        private void gridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Console.WriteLine(e.RowIndex + ";" + e.ColumnIndex);
            if(e.ColumnIndex == 0) // Gombok oszlopa...... Valamiért a nullás oszlop az??
            {
                // Eltelt idő: 4
                string[] tmp = data[e.RowIndex].AudioTime.Split();
                double sec = double.Parse(tmp[2]);
                Console.WriteLine("Ennyi időnél fogja lejátszani: " + sec);
                PlayAudio(sec);
            }
        }
    }
}
