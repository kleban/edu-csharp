using System.Diagnostics;

namespace WinDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DriveInfo[] drives = DriveInfo.GetDrives();
            comboBoxDrives.Items.AddRange(drives);
            comboBoxDrives.SelectedIndex = 0;
        }

        private void comboBoxDrives_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedDrive = comboBoxDrives.SelectedItem.ToString();
            updateFilesList(selectedDrive);
        }

        void updateFilesList(string diretory_path)
        {
            listBoxObjects.Items.Clear();
            var directoryInfo = new DirectoryInfo(diretory_path);

            foreach (var dir in directoryInfo.GetDirectories())
            {
                listBoxObjects.Items.Add(dir);
            }
            listBoxObjects.Items.Add("-------------");
            foreach (var file in directoryInfo.GetFiles())
            {
                listBoxObjects.Items.Add(file);
            }
        }


        private void listBoxObjects_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            if (listBoxObjects.SelectedItem is FileInfo)
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = listBoxObjects.SelectedItem.ToString(),
                    UseShellExecute = true
                });
            }

            if (listBoxObjects.SelectedItem is DirectoryInfo)
            {
                var dir = listBoxObjects.SelectedItem as DirectoryInfo;
                updateFilesList(dir.FullName);
            }
        }

        private void buttonCreateDir_Click(object sender, EventArgs e)
        {
            if(listBoxObjects.SelectedIndex != -1 && listBoxObjects.SelectedItem is DirectoryInfo)
            {
                var dir = listBoxObjects.SelectedItem as DirectoryInfo;

                for (int i = 0; i < 10; i++)
                {
                    var newDirPath = Path.Combine(dir.FullName, $"New_Folder_{new Random(i).Next()}");
                    DirectoryInfo newDir = new DirectoryInfo(newDirPath);
                    newDir.Create();
                }
                //Directory.CreateDirectory(newDirPath);

                updateFilesList(dir.FullName);
            }
        }
    }
}
