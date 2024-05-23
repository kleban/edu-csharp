using System.IO;

namespace ExplorerApp
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            DriveInfo[] drives = DriveInfo.GetDrives();
            comboBoxDrives.Items.AddRange(drives);
            comboBoxDrives.SelectedIndex = 0;
            //comboBoxDrives_SelectedIndexChanged(null, null);
        }

        void getDriveInfo(DriveInfo drive)
        {
            labelFree.Text = $"Вільно: {Math.Round(drive.AvailableFreeSpace / Math.Pow(2, 30))} gb";
            labelSize.Text = $"Всього: {Math.Round(drive.TotalSize / Math.Pow(2, 30))} gb";
            labelFormat.Text = $"Формат: {drive.DriveFormat}";
            labelRemoveble.Text = $"Змінний диск: {(drive.DriveType == DriveType.Removable ? "+" : "-")}";
        }

        private void comboBoxDrives_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxDrives.SelectedIndex != -1)
            {
                var drive = comboBoxDrives.SelectedItem as DriveInfo;
                getDriveInfo(drive);
                getDirectories(new DirectoryInfo(drive.Name));
            }
        }

        void getDirectories(DirectoryInfo dir)
        {
            listBoxFileSystemItems.Items.Clear();
            listBoxFileSystemItems.Items.AddRange(dir.GetDirectories().Select(x => x.Name).ToArray());
        }

        private void buttonChooseDirectory_Click(object sender, EventArgs e)
        {
            var fbd = new FolderBrowserDialog();

            if (DialogResult.OK == fbd.ShowDialog())
            {
                labelDirectoryToSave.Text = fbd.SelectedPath;

                //var directory = new DirectoryInfo(fbd.SelectedPath);
                //directory.CreateSubdirectory(textBoxDirectoryName.Text);

                var newFolderPath = Path.Combine(fbd.SelectedPath, textBoxDirectoryName.Text);
                var directory = new DirectoryInfo(newFolderPath);
                if (!directory.Exists)
                    directory.Create();

                //directory.GetDirectories();
                //directory.GetFiles();
                //directory.MoveTo("");


                //Directory.CreateDirectory(newFolderPath);

                //directory.Delete();
                //directory.Exists;

                MessageBox.Show("Done!");


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            var fbd = new FolderBrowserDialog();

            if (DialogResult.OK == fbd.ShowDialog())
            {
                var dir = new DirectoryInfo(fbd.SelectedPath);
                listBoxFiles.Items.Clear();
                listBoxFiles.Items.AddRange(dir.GetFiles("*.exe"));
            }
        }

        private void listBoxFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBoxFiles.SelectedIndex != -1)
            {
                var file = listBoxFiles.SelectedItem as FileInfo;
                labelFileExtension.Text = file.Extension;
                labelFileParent.Text = file.Directory.FullName;
                labelFileSize.Text = $"{Math.Round(file.Length / Math.Pow(2, 10))}";
            }

            FileInfo file = new FileInfo("path");

            //File
            /*file.Create();
            file.Delete();
            file.Exists;
            file.Extension;*/
          
        }
    }
}
