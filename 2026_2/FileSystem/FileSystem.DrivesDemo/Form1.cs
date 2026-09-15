using System.Security;

namespace FileSystem.DrivesDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private List<DriveInfo> drives = DriveInfo.GetDrives().ToList();
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxDrives.Items.AddRange(drives.Select(x => x.Name).ToArray());
            comboBoxDrives.SelectedIndex = 0;
        }

        void viewFiles()
        {
            DirectoryInfo dir = new DirectoryInfo(currentPath);
            listBoxFiles.Items.Clear();
            listBoxFiles.Items.AddRange(dir.GetFiles().Select(x => x.Name).ToArray());
        }

        void changeCurrentPath(string newvalue)
        {
            currentPath = newvalue;
            toolStripStatusLabelPath.Text = newvalue;
        }

        private void comboBoxDrives_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxDrives.SelectedIndex != -1)
            {
                DriveInfo drive = drives[comboBoxDrives.SelectedIndex];
                labelSize.Text = $"{Math.Round(drive.AvailableFreeSpace / Math.Pow(1024, 3), 0)}/{Math.Round(drive.TotalSize / Math.Pow(1024, 3), 0)} Gb";
                labelLabel.Text = drive.VolumeLabel;
                changeCurrentPath(drive.Name);
                viewDirs();
                viewFiles();
            }
        }

        private void viewDirs()
        {
            DirectoryInfo dir = new DirectoryInfo(currentPath);
            listBoxDirs.Items.Clear();
            listBoxDirs.Items.AddRange(dir.GetDirectories().Select(x => x.Name).ToArray());
        }

        private string currentPath = string.Empty;

        private void buttonMoveInside_Click(object sender, EventArgs e)
        {
            if (listBoxDirs.SelectedIndex != -1 && comboBoxDrives.SelectedIndex != -1)
            {
                changeCurrentPath(Path.Combine(currentPath, listBoxDirs.SelectedItem.ToString()));
                viewDirs();
                viewFiles();
            }
        }

        private void buttonMoveUp_Click(object sender, EventArgs e)
        {
            try
            {
                DirectoryInfo dir = new DirectoryInfo(currentPath);

                changeCurrentPath(dir.Parent.FullName);
                viewDirs();
                viewFiles();
            }
            catch (SecurityException se)
            {
                //
            }
            catch (NullReferenceException)
            {
                MessageBox.Show($"Не можна вийти за межі диска {drives[comboBoxDrives.SelectedIndex].Name}");
            }
            catch
            {

            }
            finally
            {

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var r = new Random();
            string name = $"folder_{r.Next(1000, 10000)}";
            var d = new DirectoryInfo(currentPath);
            d.CreateSubdirectory(name);

            MessageBox.Show("Done!");

            //Directory.CreateDirectory(Path.Combine(currentPath, name));
        }
    }
}
