﻿using NAudio.Wave;
using NAudio.Wave.SampleProviders;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace Rorschach_Launcher
{
    public partial class OpenLogFileWindow : Form
    {
        private System.Media.SoundPlayer player;
        private IList<Row> data = new List<Row>();

        public OpenLogFileWindow()
        {
            InitializeComponent();
        }

        private void button_open_Click(object sender, EventArgs e)
        {

            if(IsValidInputs())
            {
                System.IO.StreamReader file = new StreamReader(logFile.Text);
                player = new System.Media.SoundPlayer(voice.Text);
                player.Load();
                string line;

                while ((line = file.ReadLine()) != null)
                {
                    string[] dataSlices = line.Split(';');
                    this.data.Add(new Row()
                    {
                        Image = ResizeImage(Image.FromFile(dataSlices[0]), 100, 100),
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

            } else
            {
                MessageBox.Show("You need to fill all of the input of this form!", "Error", MessageBoxButtons.OK);
            }

        }

        private bool IsValidInputs()
        {
            string logf = logFile.Text;
            string voicef = voice.Text;

            if(logf.Equals("") || voice.Equals(""))
            {
                return false;
            }

            return true;
        }

        private void PlayAudio(double whereFrom)
        {
            var file = new AudioFileReader(voice.Text);
            var trimmed = new OffsetSampleProvider(file);
            trimmed.SkipOver = TimeSpan.FromSeconds(whereFrom);
            trimmed.Take = TimeSpan.FromSeconds((double)timeToPlay.Value);
            var player = new WaveOutEvent();
            player.Init(trimmed);
            player.Play();
        }

        public static Bitmap ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }

        private void gridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 0)
            {
                string[] tmp = data[e.RowIndex].AudioTime.Split();
                double sec = double.Parse(tmp[2]);
                PlayAudio(sec);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select a log file!";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                logFile.Text = ofd.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select a voice file!";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                voice.Text = ofd.FileName;
            }
        }
    }
}
