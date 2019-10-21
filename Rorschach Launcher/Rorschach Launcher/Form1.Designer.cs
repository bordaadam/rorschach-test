﻿namespace Rorschach_Launcher
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_selectDirectory = new System.Windows.Forms.Button();
            this.textBox_folder = new System.Windows.Forms.TextBox();
            this.label_folderPath = new System.Windows.Forms.Label();
            this.button_launch = new System.Windows.Forms.Button();
            this.numericUpDown_frame = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_exe = new System.Windows.Forms.TextBox();
            this.label_exe = new System.Windows.Forms.Label();
            this.button_exe = new System.Windows.Forms.Button();
            this.textBox_folderToLog = new System.Windows.Forms.TextBox();
            this.button_folderToLog = new System.Windows.Forms.Button();
            this.label_folderToLog = new System.Windows.Forms.Label();
            this.textBox_nameOfFile = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_frame)).BeginInit();
            this.SuspendLayout();
            // 
            // button_selectDirectory
            // 
            this.button_selectDirectory.Location = new System.Drawing.Point(142, 66);
            this.button_selectDirectory.Name = "button_selectDirectory";
            this.button_selectDirectory.Size = new System.Drawing.Size(62, 25);
            this.button_selectDirectory.TabIndex = 0;
            this.button_selectDirectory.Text = "Browse...";
            this.button_selectDirectory.UseVisualStyleBackColor = true;
            this.button_selectDirectory.Click += new System.EventHandler(this.button_selectDirectory_Click);
            // 
            // textBox_folder
            // 
            this.textBox_folder.Location = new System.Drawing.Point(142, 40);
            this.textBox_folder.Name = "textBox_folder";
            this.textBox_folder.ReadOnly = true;
            this.textBox_folder.Size = new System.Drawing.Size(486, 20);
            this.textBox_folder.TabIndex = 1;
            // 
            // label_folderPath
            // 
            this.label_folderPath.AutoSize = true;
            this.label_folderPath.Location = new System.Drawing.Point(34, 40);
            this.label_folderPath.Name = "label_folderPath";
            this.label_folderPath.Size = new System.Drawing.Size(101, 13);
            this.label_folderPath.TabIndex = 2;
            this.label_folderPath.Text = "Images Folder Path:";
            // 
            // button_launch
            // 
            this.button_launch.Location = new System.Drawing.Point(339, 344);
            this.button_launch.Name = "button_launch";
            this.button_launch.Size = new System.Drawing.Size(106, 50);
            this.button_launch.TabIndex = 3;
            this.button_launch.Text = "Start!";
            this.button_launch.UseVisualStyleBackColor = true;
            this.button_launch.Click += new System.EventHandler(this.button_launch_Click);
            // 
            // numericUpDown_frame
            // 
            this.numericUpDown_frame.Location = new System.Drawing.Point(214, 281);
            this.numericUpDown_frame.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_frame.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_frame.Name = "numericUpDown_frame";
            this.numericUpDown_frame.Size = new System.Drawing.Size(52, 20);
            this.numericUpDown_frame.TabIndex = 4;
            this.numericUpDown_frame.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 288);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Displaying duration in frames:";
            // 
            // textBox_exe
            // 
            this.textBox_exe.Location = new System.Drawing.Point(142, 115);
            this.textBox_exe.Name = "textBox_exe";
            this.textBox_exe.ReadOnly = true;
            this.textBox_exe.Size = new System.Drawing.Size(486, 20);
            this.textBox_exe.TabIndex = 6;
            // 
            // label_exe
            // 
            this.label_exe.AutoSize = true;
            this.label_exe.Location = new System.Drawing.Point(34, 118);
            this.label_exe.Name = "label_exe";
            this.label_exe.Size = new System.Drawing.Size(101, 13);
            this.label_exe.TabIndex = 7;
            this.label_exe.Text = ".exe of the program:";
            // 
            // button_exe
            // 
            this.button_exe.Location = new System.Drawing.Point(142, 141);
            this.button_exe.Name = "button_exe";
            this.button_exe.Size = new System.Drawing.Size(62, 25);
            this.button_exe.TabIndex = 8;
            this.button_exe.Text = "Browse...";
            this.button_exe.UseVisualStyleBackColor = true;
            this.button_exe.Click += new System.EventHandler(this.button_exe_Click);
            // 
            // textBox_folderToLog
            // 
            this.textBox_folderToLog.Location = new System.Drawing.Point(142, 189);
            this.textBox_folderToLog.Name = "textBox_folderToLog";
            this.textBox_folderToLog.ReadOnly = true;
            this.textBox_folderToLog.Size = new System.Drawing.Size(486, 20);
            this.textBox_folderToLog.TabIndex = 9;
            // 
            // button_folderToLog
            // 
            this.button_folderToLog.Location = new System.Drawing.Point(142, 215);
            this.button_folderToLog.Name = "button_folderToLog";
            this.button_folderToLog.Size = new System.Drawing.Size(62, 25);
            this.button_folderToLog.TabIndex = 10;
            this.button_folderToLog.Text = "Browse...";
            this.button_folderToLog.UseVisualStyleBackColor = true;
            this.button_folderToLog.Click += new System.EventHandler(this.button_folderToLog_Click);
            // 
            // label_folderToLog
            // 
            this.label_folderToLog.AutoSize = true;
            this.label_folderToLog.Location = new System.Drawing.Point(34, 192);
            this.label_folderToLog.Name = "label_folderToLog";
            this.label_folderToLog.Size = new System.Drawing.Size(69, 13);
            this.label_folderToLog.TabIndex = 11;
            this.label_folderToLog.Text = "Folder to Log";
            // 
            // textBox_nameOfFile
            // 
            this.textBox_nameOfFile.Location = new System.Drawing.Point(283, 218);
            this.textBox_nameOfFile.Name = "textBox_nameOfFile";
            this.textBox_nameOfFile.Size = new System.Drawing.Size(133, 20);
            this.textBox_nameOfFile.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(211, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Name of file:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_nameOfFile);
            this.Controls.Add(this.label_folderToLog);
            this.Controls.Add(this.button_folderToLog);
            this.Controls.Add(this.textBox_folderToLog);
            this.Controls.Add(this.button_exe);
            this.Controls.Add(this.label_exe);
            this.Controls.Add(this.textBox_exe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown_frame);
            this.Controls.Add(this.button_launch);
            this.Controls.Add(this.label_folderPath);
            this.Controls.Add(this.textBox_folder);
            this.Controls.Add(this.button_selectDirectory);
            this.Name = "Form1";
            this.Text = "Launcher";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_frame)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_selectDirectory;
        private System.Windows.Forms.TextBox textBox_folder;
        private System.Windows.Forms.Label label_folderPath;
        private System.Windows.Forms.Button button_launch;
        private System.Windows.Forms.NumericUpDown numericUpDown_frame;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_exe;
        private System.Windows.Forms.Label label_exe;
        private System.Windows.Forms.Button button_exe;
        private System.Windows.Forms.TextBox textBox_folderToLog;
        private System.Windows.Forms.Button button_folderToLog;
        private System.Windows.Forms.Label label_folderToLog;
        private System.Windows.Forms.TextBox textBox_nameOfFile;
        private System.Windows.Forms.Label label2;
    }
}

