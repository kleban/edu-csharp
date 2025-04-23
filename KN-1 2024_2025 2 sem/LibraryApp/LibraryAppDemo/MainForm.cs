using LibraryAppDemo.Models;

namespace LibraryAppDemo
{
    public partial class MainForm : Form
    {
        private Library library;
        public MainForm()
        {
            InitializeComponent();
            library = new Library();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            updateBooksList();
        }

        private void updateBooksList()
        {
            listBoxBooks.Items.Clear();
            listBoxBooks.Items.AddRange(library.GetBooks());
        }

        private void listBoxBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonDeleteBook.Enabled = listBoxBooks.SelectedIndex != -1;
        }

        private void buttonDeleteBook_Click(object sender, EventArgs e)
        {
            Book b = listBoxBooks.SelectedItem as Book;
            if (b != null)
            {
                library.Remove(b.ISBN);
                updateBooksList();
                buttonDeleteBook.Enabled = false;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            //check
            if (string.IsNullOrEmpty(textBoxTitle.Text))
            {
                MessageBox.Show("¬вед≥ть назву книги.");
                return;
            }

            if (string.IsNullOrEmpty(textBoxAuthors.Text))
            {
                MessageBox.Show("¬вед≥ть автор≥в книги.");
                return;
            }

            if (string.IsNullOrEmpty(textBoxISBN.Text))
            {
                MessageBox.Show("¬вед≥ть ISBN книги.");
                return;
            }

            if (string.IsNullOrEmpty(textBoxYear.Text))
            {
                MessageBox.Show("¬вед≥ть р≥к виданн€ книги.");
                return;
            }

            Book b = new Book
            {
                Title = textBoxTitle.Text,
                Author = textBoxAuthors.Text,
                ISBN = textBoxISBN.Text,
                Year = int.Parse(textBoxYear.Text)
            };

            library.Add(b);
            updateBooksList();
        }
    }
}
