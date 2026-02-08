namespace DrivesDemo
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

            var drive1 = drives[0];

        }

        private DirectoryInfo currentDirrectory;

        private void comboBoxDrives_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxDrives.SelectedItem == null)
                return;

            currentDirrectory = new DirectoryInfo(comboBoxDrives.SelectedItem.ToString());

            updateListBox();

            labelCurrentDirectory.Text = currentDirrectory.FullName;

        }

        private void listBoxDirectories_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void listBoxDirectories_DoubleClick(object sender, EventArgs e)
        {
            if (comboBoxDrives.SelectedItem == null)
                return;

            var clickedDir = listBoxDirectories.SelectedItem.ToString();
            currentDirrectory = new DirectoryInfo(Path.Combine(currentDirrectory.FullName, clickedDir));
            labelCurrentDirectory.Text = currentDirrectory.FullName;
            updateListBox();
        }

        private void updateListBox()
        {
            listBoxDirectories.Items.Clear();
            listBoxDirectories.Items.AddRange(currentDirrectory.GetDirectories().Select(x => x.Name).ToArray());
            updateFilesListBox();
        }

        private void updateFilesListBox()
        {
            listBoxFiles.Items.Clear();
            listBoxFiles.Items.AddRange(currentDirrectory.GetFiles().Select(x => x.Name).ToArray());
        }

        private void buttonCreateDirectory_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(textBoxCreateDirectory.Text.Trim()))
            {
                MessageBox.Show("Directory name cannot be empty");
                return;
            }

            var newDirPath = Path.Combine(currentDirrectory.FullName, textBoxCreateDirectory.Text.Trim());
            //currentDirrectory.CreateSubdirectory(textBoxCreateDirectory.Text.Trim());   
            Directory.CreateDirectory(newDirPath);
            updateListBox();
        }
    }
}
