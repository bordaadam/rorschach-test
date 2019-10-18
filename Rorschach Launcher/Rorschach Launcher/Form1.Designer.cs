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
            this.button_selectDirectory = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_selectDirectory
            // 
            this.button_selectDirectory.Location = new System.Drawing.Point(69, 70);
            this.button_selectDirectory.Name = "button_selectDirectory";
            this.button_selectDirectory.Size = new System.Drawing.Size(216, 32);
            this.button_selectDirectory.TabIndex = 0;
            this.button_selectDirectory.Text = "Select directory to read from";
            this.button_selectDirectory.UseVisualStyleBackColor = true;
            this.button_selectDirectory.Click += new System.EventHandler(this.button_selectDirectory_Click);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(69, 108);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(486, 20);
            this.textBox.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.button_selectDirectory);
            this.Name = "Form1";
            this.Text = "Launcher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_selectDirectory;
        private System.Windows.Forms.TextBox textBox;
    }
}

