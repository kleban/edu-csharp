using System.IO;

namespace FileSearchApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            var directory = new DirectoryInfo(this.Text);
            SearchInDirectory(directory, _treeView.Nodes.Add(directory.Name));            
        }

        void SearchInDirectory(DirectoryInfo dir, TreeNode node)
        {
            foreach(var f in dir.GetFiles(textBoxMask.Text))
            {
                listBoxFiles.Items.Add(f.FullName);
            }

            foreach (var d in dir.GetDirectories())
            {
               var nodeInternal = node.Nodes.Add(d.Name);
               SearchInDirectory(d, nodeInternal);
            }
        }
    }
}
