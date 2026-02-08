namespace NotepadX
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            var open = new OpenFileDialog();
            open.Filter = "text files | *.txt";

            if (DialogResult.OK == open.ShowDialog())
            {
                var fileName = open.FileName;

                StreamReader reader = null;

                try
                {
                    reader = new StreamReader(fileName);
                    textBoxEditor.Text = reader.ReadToEnd();
                }
                catch
                {
                    throw;
                }
                finally
                {
                    if (reader is not null)
                        reader.Close();
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            var open = new SaveFileDialog();
            open.Filter = "text files | *.txt";

            if (DialogResult.OK == open.ShowDialog())
            {
                var fileName = open.FileName;

                using (StreamWriter w = new StreamWriter(fileName))
                {
                    w.Write(textBoxEditor.Text);                   
                } 

                StreamWriter writer = null;
                try
                {
                    writer = new StreamWriter(fileName);
                    writer.Write(textBoxEditor.Text);
                }
                catch
                {
                    throw;
                }
                finally
                {
                    if(writer is not null)
                    {
                        writer.Flush();
                        writer.Close();
                    }
                }
            }

        }
    }
}
