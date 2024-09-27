using DataReadWrite.Managers;

namespace DataReadWrite.MultyWindow
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                var file = new FileInfo(dialog.FileName);
                IBookReaderWriter manager = null;
                switch(file.Extension)
                {
                    case ".json":
                        manager = new JsonReaderWriter();
                        break;
                    case ".csv":
                        manager = new CsvReaderWriter();
                        break;
                }
                Form2 f = new Form2(manager, file.FullName);
                f.ShowDialog();

            }
        }
    }
}
