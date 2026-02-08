using Library.Models;

namespace Library
{
    public partial class MainWindow : Form
    {
        private LibraryManager _manager;
        public MainWindow()
        {
            InitializeComponent();
            _manager = new LibraryManager();
        }
        private void buttonClean_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            numericUpDown1.Value = 0;
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Please enter a title.");
                return;
            }
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Please enter an author.");
                return;
            }
            if (numericUpDown1.Value <= 0)
            {
                MessageBox.Show("Please enter a valid number of pages.");
                return;
            }
            _manager.AddBook(textBox1.Text, textBox2.Text, (int)numericUpDown1.Value);
            updateList();
            buttonClean_Click(null, null);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            updateList();
        }

        void updateList()
        {
            listBoxBooks.Items.Clear();
            foreach (var book in _manager.GetBooks())
            {
                listBoxBooks.Items.Add(book);
            }
        }

        private void listBoxBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonDelete.Enabled = listBoxBooks.SelectedIndex != -1;

           

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            Book selectedBook = listBoxBooks.SelectedItem as Book;

            DialogResult result = MessageBox.Show($" Ви справді баєте видалити {selectedBook}?",
                 "Видалення книги",
                 MessageBoxButtons.OKCancel,
                 MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                _manager.DeleteBook(selectedBook.ISBN);
                updateList();
            }
        }
    }
}
