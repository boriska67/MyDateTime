using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MyDateTime
{
    public partial class frmDateTime : Form
    {
        public frmDateTime()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnShowDateTime_Click(object sender, EventArgs e)
        {
            lblTime.Text = string.Empty;
            lblTime.Text = Time();
            String output = Time();

            DateTime dt = DateTime.ParseExact(output, String.Format("yyyy-dd-MM HH:mm:ss"), null);
        }

        private void btnWriteDateTimeToFile_Click(object sender, EventArgs e)
        {
            string time = Time();

            using (SaveFileDialog save = new SaveFileDialog())
            {
                save.FileName = "test.txt";
                save.InitialDirectory = "c:\\test\\readwrite";
                save.Filter = "txt files (*.txt)|*.txt|log files (*.log)|*.log";
                save.OverwritePrompt = false;

                if (save.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter writer = new StreamWriter(save.OpenFile());

                    try
                    {
                        writer.WriteLine(time);
                        writer.Dispose();
                        writer.Close();

                        lblTime.Text = string.Empty;
                        lblTime.Text = "Success!";
                    }
                    catch (IOException z)
                    {
                        lblTime.Text = string.Empty;
                        lblTime.Text = z.ToString();// "Error! Unable to write into the files!";
                        writer.Dispose();
                        writer.Close();
                    }
                }
            }
        }

        private void btnReadDateTimeFRomFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialogDateTime = new OpenFileDialog())
            {
                string fileContent = string.Empty;
                string filePath = string.Empty;

                openFileDialogDateTime.InitialDirectory = "c:\\test\\readwrite";
                openFileDialogDateTime.RestoreDirectory = true;
                openFileDialogDateTime.Filter = "txt files (*.txt)|*.txt|log files (*.log)|*.log";
                openFileDialogDateTime.FilterIndex = 1;

                if (openFileDialogDateTime.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialogDateTime.FileName;
                    Stream fileStream = openFileDialogDateTime.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                    }

                    fileStream.Dispose();
                    fileStream.Close();
                }

                lblTime.Text = string.Empty;
                lblTime.Text = fileContent;
            } 
        }

        private string Time()
        {
            DateTime savedNow = DateTime.Now;
            return String.Format("{0:yyyy-dd-MM}", savedNow) + " " + 
                String.Format("{0:00}", DateTime.Parse(savedNow.ToLongTimeString()).TimeOfDay.Hours) + ":" + 
                String.Format("{0:00}", DateTime.Parse(savedNow.ToLongTimeString()).TimeOfDay.Minutes) + ":" + 
                String.Format("{0:00}", DateTime.Parse(savedNow.ToLongTimeString()).TimeOfDay.Seconds);
        }
    }
}
