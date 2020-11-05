namespace MyDateTime
{
    partial class frmDateTime
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDateTime));
            this.btnShowDateTime = new System.Windows.Forms.Button();
            this.btnWriteDateTimeToFile = new System.Windows.Forms.Button();
            this.btnReadDateTimeFRomFile = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.openFileDialogDateTime = new System.Windows.Forms.OpenFileDialog();
            this.lblTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnShowDateTime
            // 
            this.btnShowDateTime.Location = new System.Drawing.Point(21, 29);
            this.btnShowDateTime.Name = "btnShowDateTime";
            this.btnShowDateTime.Size = new System.Drawing.Size(141, 26);
            this.btnShowDateTime.TabIndex = 0;
            this.btnShowDateTime.Text = "Show Date Time";
            this.btnShowDateTime.UseVisualStyleBackColor = true;
            this.btnShowDateTime.Click += new System.EventHandler(this.btnShowDateTime_Click);
            // 
            // btnWriteDateTimeToFile
            // 
            this.btnWriteDateTimeToFile.Location = new System.Drawing.Point(21, 85);
            this.btnWriteDateTimeToFile.Name = "btnWriteDateTimeToFile";
            this.btnWriteDateTimeToFile.Size = new System.Drawing.Size(141, 26);
            this.btnWriteDateTimeToFile.TabIndex = 1;
            this.btnWriteDateTimeToFile.Text = "Write Date Time to File";
            this.btnWriteDateTimeToFile.UseVisualStyleBackColor = true;
            this.btnWriteDateTimeToFile.Click += new System.EventHandler(this.btnWriteDateTimeToFile_Click);
            // 
            // btnReadDateTimeFRomFile
            // 
            this.btnReadDateTimeFRomFile.Location = new System.Drawing.Point(21, 145);
            this.btnReadDateTimeFRomFile.Name = "btnReadDateTimeFRomFile";
            this.btnReadDateTimeFRomFile.Size = new System.Drawing.Size(141, 26);
            this.btnReadDateTimeFRomFile.TabIndex = 2;
            this.btnReadDateTimeFRomFile.Text = "Read Date Time from File";
            this.btnReadDateTimeFRomFile.UseVisualStyleBackColor = true;
            this.btnReadDateTimeFRomFile.Click += new System.EventHandler(this.btnReadDateTimeFRomFile_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(268, 145);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(141, 26);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // openFileDialogDateTime
            // 
            this.openFileDialogDateTime.FileName = "openFileDialog1";
            // 
            // lblTime
            // 
            this.lblTime.Location = new System.Drawing.Point(265, 29);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(144, 26);
            this.lblTime.TabIndex = 4;
            // 
            // frmDateTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 194);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnReadDateTimeFRomFile);
            this.Controls.Add(this.btnWriteDateTimeToFile);
            this.Controls.Add(this.btnShowDateTime);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmDateTime";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Date Time";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnShowDateTime;
        private System.Windows.Forms.Button btnWriteDateTimeToFile;
        private System.Windows.Forms.Button btnReadDateTimeFRomFile;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.OpenFileDialog openFileDialogDateTime;
        private System.Windows.Forms.Label lblTime;
    }
}

