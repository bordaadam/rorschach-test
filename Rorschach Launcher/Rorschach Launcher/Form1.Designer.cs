namespace Rorschach_Launcher
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
            this.components = new System.ComponentModel.Container();
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
            this.label_patient = new System.Windows.Forms.Label();
            this.textBox_patient = new System.Windows.Forms.TextBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_frame)).BeginInit();
            this.SuspendLayout();
            // 
            // button_selectDirectory
            // 
            this.button_selectDirectory.Location = new System.Drawing.Point(150, 138);
            this.button_selectDirectory.Name = "button_selectDirectory";
            this.button_selectDirectory.Size = new System.Drawing.Size(62, 25);
            this.button_selectDirectory.TabIndex = 0;
            this.button_selectDirectory.Text = "Browse...";
            this.button_selectDirectory.UseVisualStyleBackColor = true;
            this.button_selectDirectory.Click += new System.EventHandler(this.button_selectDirectory_Click);
            // 
            // textBox_folder
            // 
            this.textBox_folder.Location = new System.Drawing.Point(150, 112);
            this.textBox_folder.Name = "textBox_folder";
            this.textBox_folder.ReadOnly = true;
            this.textBox_folder.Size = new System.Drawing.Size(486, 20);
            this.textBox_folder.TabIndex = 1;
            this.toolTip.SetToolTip(this.textBox_folder, "The path of the images folder");
            // 
            // label_folderPath
            // 
            this.label_folderPath.AutoSize = true;
            this.label_folderPath.Location = new System.Drawing.Point(34, 112);
            this.label_folderPath.Name = "label_folderPath";
            this.label_folderPath.Size = new System.Drawing.Size(76, 13);
            this.label_folderPath.TabIndex = 2;
            this.label_folderPath.Text = "Images Folder:";
            // 
            // button_launch
            // 
            this.button_launch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_launch.Location = new System.Drawing.Point(327, 364);
            this.button_launch.Name = "button_launch";
            this.button_launch.Size = new System.Drawing.Size(106, 50);
            this.button_launch.TabIndex = 3;
            this.button_launch.Text = "Launch!";
            this.button_launch.UseVisualStyleBackColor = true;
            this.button_launch.Click += new System.EventHandler(this.button_launch_Click);
            // 
            // numericUpDown_frame
            // 
            this.numericUpDown_frame.Location = new System.Drawing.Point(214, 327);
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
            this.toolTip.SetToolTip(this.numericUpDown_frame, "Displaying duration in frames");
            this.numericUpDown_frame.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 334);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Displaying duration in frames:";
            // 
            // textBox_exe
            // 
            this.textBox_exe.Location = new System.Drawing.Point(150, 187);
            this.textBox_exe.Name = "textBox_exe";
            this.textBox_exe.ReadOnly = true;
            this.textBox_exe.Size = new System.Drawing.Size(486, 20);
            this.textBox_exe.TabIndex = 6;
            this.toolTip.SetToolTip(this.textBox_exe, "The file of the Unity program");
            // 
            // label_exe
            // 
            this.label_exe.AutoSize = true;
            this.label_exe.Location = new System.Drawing.Point(34, 187);
            this.label_exe.Name = "label_exe";
            this.label_exe.Size = new System.Drawing.Size(110, 13);
            this.label_exe.TabIndex = 7;
            this.label_exe.Text = ".exe of Unity program:";
            // 
            // button_exe
            // 
            this.button_exe.Location = new System.Drawing.Point(150, 213);
            this.button_exe.Name = "button_exe";
            this.button_exe.Size = new System.Drawing.Size(62, 25);
            this.button_exe.TabIndex = 8;
            this.button_exe.Text = "Browse...";
            this.button_exe.UseVisualStyleBackColor = true;
            this.button_exe.Click += new System.EventHandler(this.button_exe_Click);
            // 
            // textBox_folderToLog
            // 
            this.textBox_folderToLog.Location = new System.Drawing.Point(150, 261);
            this.textBox_folderToLog.Name = "textBox_folderToLog";
            this.textBox_folderToLog.ReadOnly = true;
            this.textBox_folderToLog.Size = new System.Drawing.Size(486, 20);
            this.textBox_folderToLog.TabIndex = 9;
            this.toolTip.SetToolTip(this.textBox_folderToLog, "The path of the folder to log into");
            // 
            // button_folderToLog
            // 
            this.button_folderToLog.Location = new System.Drawing.Point(150, 285);
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
            this.label_folderToLog.Location = new System.Drawing.Point(34, 264);
            this.label_folderToLog.Name = "label_folderToLog";
            this.label_folderToLog.Size = new System.Drawing.Size(69, 13);
            this.label_folderToLog.TabIndex = 11;
            this.label_folderToLog.Text = "Folder to Log";
            // 
            // textBox_nameOfFile
            // 
            this.textBox_nameOfFile.Location = new System.Drawing.Point(300, 290);
            this.textBox_nameOfFile.Name = "textBox_nameOfFile";
            this.textBox_nameOfFile.Size = new System.Drawing.Size(133, 20);
            this.textBox_nameOfFile.TabIndex = 12;
            this.toolTip.SetToolTip(this.textBox_nameOfFile, "The name of the log file");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(228, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Name of file:";
            // 
            // label_patient
            // 
            this.label_patient.AutoSize = true;
            this.label_patient.Location = new System.Drawing.Point(34, 49);
            this.label_patient.Name = "label_patient";
            this.label_patient.Size = new System.Drawing.Size(43, 13);
            this.label_patient.TabIndex = 14;
            this.label_patient.Text = "Patient:";
            // 
            // textBox_patient
            // 
            this.textBox_patient.Location = new System.Drawing.Point(150, 49);
            this.textBox_patient.Name = "textBox_patient";
            this.textBox_patient.Size = new System.Drawing.Size(486, 20);
            this.textBox_patient.TabIndex = 15;
            this.toolTip.SetToolTip(this.textBox_patient, "Some info about the patient");
            // 
            // toolTip
            // 
            this.toolTip.AutoPopDelay = 5000;
            this.toolTip.InitialDelay = 1;
            this.toolTip.IsBalloon = true;
            this.toolTip.ReshowDelay = 0;
            this.toolTip.ShowAlways = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox_patient);
            this.Controls.Add(this.label_patient);
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
        private System.Windows.Forms.Label label_patient;
        private System.Windows.Forms.TextBox textBox_patient;
        private System.Windows.Forms.ToolTip toolTip;
    }
}

