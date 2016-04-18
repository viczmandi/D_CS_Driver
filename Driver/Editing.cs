using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Driver
{
    public partial class Editing : Form
    {
        DriveInfo[] drives = DriveInfo.GetDrives();

        public Editing()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (DriveInfo drive in drives)
            {
                drivesComboBox.Items.Add(drive.Name + " - " + "(" + drive.DriveType + ")");
            }
        }

        private void drivesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (drivesComboBox.SelectedIndex > -1)
            {
                int selectedDrive = drivesComboBox.SelectedIndex;
                pathTextBox.Text = string.Empty;
                pathTextBox.Text += drives[selectedDrive].RootDirectory;

                DirectoryInfo[] dirs = drives[selectedDrive].RootDirectory.GetDirectories();
                foreach (DirectoryInfo dir in dirs)
                {
                    dirsListBox.Items.Add(dir);
                }
                FileInfo[] files = drives[selectedDrive].RootDirectory.GetFiles();
                foreach (FileInfo file in files)
                {
                    dirsListBox.Items.Add(file);
                }
            }
        }

        private void drivesListBox_Click(object sender, EventArgs e)
        {
            string selectedDirOrFile = dirsListBox.SelectedItem.ToString();
            string filePath = Path.GetFullPath(selectedDirOrFile);
            pathTextBox.Text = string.Empty;
            pathTextBox.Text += filePath;
        }
    }
}
