namespace ReadWriteText
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
            dialog.Filter = "Text file (*.txt)|*.txt";

            if (DialogResult.OK == dialog.ShowDialog())
            {
                var fileName = dialog.FileName;

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
            var dialog = new SaveFileDialog();
            dialog.Filter = "Text file (*.txt)|*.txt";

            if (DialogResult.OK == dialog.ShowDialog())
            {
                var fileName = dialog.FileName;

                StreamWriter writer = null;

                try
                {
                    writer = new StreamWriter(fileName);
                    writer.Write(textBoxEditor.Text);
                    MessageBox.Show("Saved!");
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
