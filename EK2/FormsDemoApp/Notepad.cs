using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsDemoApp
{
    public partial class Notepad : Form
    {
        public Notepad()
        {
            InitializeComponent();
        }

        private bool _isEdited = false;
        private string _filePath = string.Empty;
        private System.Windows.Forms.Timer _timer = null;
        private System.Windows.Forms.Timer _statusTimer = null;
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var openDialog = new OpenFileDialog();
            openDialog.Filter = "C# code files (*.cs)|*.cs";

            DialogResult result = openDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                _filePath = openDialog.FileName;
                statusLabelFilePath.Text = _filePath;

                using (var reader = new StreamReader(_filePath))
                {
                    textBoxNotepad.Text = reader.ReadToEnd();
                    reader.Close();
                }

                _isEdited = false;
            }
        }

        private void textBoxNotepad_TextChanged(object sender, EventArgs e)
        {
            statulLabelSymbolsCount.Text = $"Кількість символів: {textBoxNotepad.Text.Length}";
            _isEdited = true;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_isEdited)
            {
                if (string.IsNullOrEmpty(_filePath))
                {
                    saveAsToolStripMenuItem_Click(null, null);
                }
                else
                {
                    saveFile();
                }
            }
        }

        void saveFile()
        {
            using (var writer = new StreamWriter(_filePath))
            {
                writer.Write(textBoxNotepad.Text);
                writer.Flush();
                writer.Close();
                _isEdited = false;

                MessageBox.Show("Saved");
            }

        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var saveDialog = new SaveFileDialog();
            saveDialog.Filter = "C# code files (*.cs)|*.cs";

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                _filePath = saveDialog.FileName;
                statusLabelFilePath.Text = _filePath;
                saveFile();
            }
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            fontDialog.ShowColor = true;

            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxNotepad.Font = fontDialog.Font;
                textBoxNotepad.ForeColor = fontDialog.Color;
            }
        }

        private void Notepad_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_isEdited)
            {
                var dialogResult = MessageBox.Show("Присутні незбережені зміни. Зберегти?", "Запитання",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    e.Cancel = true;
                    saveToolStripMenuItem_Click(null, null);
                }
            }
        }

        private void generateTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _timer = new System.Windows.Forms.Timer();
            _timer.Enabled = true;
            _timer.Interval = 500;
            _timer.Tick += _timer_Tick;
            _timer.Start();
        }

        private void _timer_Tick(object? sender, EventArgs e)
        {
            var r = new Random();
            textBoxNotepad.Text += r.Next().ToString() + " ";
        }

        private void stopTextGenerationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _timer.Enabled = false;
            _timer.Stop();
            _timer = null;
        }

        private void Notepad_Load(object sender, EventArgs e)
        {
            _statusTimer = new System.Windows.Forms.Timer();
            _statusTimer.Enabled = true;
            _statusTimer.Interval = 1000;
            _statusTimer.Tick += _statusTimer_Tick;
            _statusTimer.Start();
        }

        private void _statusTimer_Tick(object? sender, EventArgs e)
        {
            statusTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
