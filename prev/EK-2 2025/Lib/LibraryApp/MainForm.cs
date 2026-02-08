using LibraryApp.Models;

namespace LibraryApp
{
    public partial class MainForm : Form
    {
        private LibraryManager libraryManager;
        public MainForm()
        {
            InitializeComponent();
            libraryManager = new LibraryManager();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            numericUpDownYear.Maximum = DateTime.Now.Year;
            updateGenreList();
            updateBooksList();
        }

        void updateBooksList()
        {
            listBoxBooks.Items.Clear();
            listBoxBooks.Items.AddRange(libraryManager.GetBooks().ToArray());
        }
        void updateGenreList()
        {
            listBoxGenres.Items.Clear();
            listBoxGenres.Items.AddRange(libraryManager.GetGenres().ToArray());

            comboBoxGenres.Items.Clear();
            comboBoxGenres.Items.AddRange(libraryManager.GetGenres().ToArray());
            comboBoxGenres.SelectedIndex = 0;
        }

        private void buttonGenreCancel_Click(object sender, EventArgs e)
        {
            textBoxGenreName.Clear();
        }

        private void buttonGenreSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxGenreName.Text))
            {
                MessageBox.Show("Please enter a genre name.");
            }
            else
            {
                if (libraryManager.IsGenreExists(textBoxGenreName.Text))
                {
                    MessageBox.Show("This genre already exists.");
                    return;
                }

                Genre newGenre = new Genre { Name = textBoxGenreName.Text };
                libraryManager.AddGenre(newGenre);
                updateGenreList();
                textBoxGenreName.Clear();
            }
        }

        private void listBoxGenres_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonGenreDelete.Enabled = listBoxGenres.SelectedIndex != -1;
        }

        private void buttonGenreDelete_Click(object sender, EventArgs e)
        {
            if (listBoxGenres.SelectedIndex >= 0)
            {
                Genre selectedGenre = listBoxGenres.SelectedItem as Genre;
                if (libraryManager.CheckBooksInGenre(selectedGenre))
                {
                    MessageBox.Show("Cannot delete this genre as it is associated with books.");
                    return;
                }

                libraryManager.RemoveGenre(selectedGenre);
                updateGenreList();
            }
            else
            {
                MessageBox.Show("Please select a genre to delete.");
            }
        }

        private void listBoxBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonBookDelete.Enabled = listBoxBooks.SelectedIndex != -1;

            if (listBoxBooks.SelectedIndex >= 0)
            {
                editedBook = listBoxBooks.SelectedItem as Book;
                textBoxBookTitle.Text = editedBook.Title;
                textBoxBookAuthors.Text = editedBook.Author;
                numericUpDownYear.Value = editedBook.Year;
                comboBoxGenres.SelectedItem = editedBook.Genre;
                checkBoxMode.Checked = true;
            }
        }

        private Book editedBook = null;

        private void buttonBookDelete_Click(object sender, EventArgs e)
        {
            if (listBoxBooks.SelectedIndex >= 0)
            {
                var book = listBoxBooks.SelectedItem as Book;

                DialogResult res = MessageBox.Show($"Are you sure you want to delete {book}?", "Delete Book", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (res == DialogResult.Yes)
                {
                    libraryManager.RemoveBook(book.ISBN);
                    buttonBookDelete.Enabled = false;
                    updateBooksList();
                    buttonBookClear_Click(null, null);
                }
            }
        }

        private void checkBoxMode_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxMode.Text = checkBoxMode.Checked ? "Edit Mode" : "Create Mode";
        }

        private void buttonBookClear_Click(object sender, EventArgs e)
        {
            textBoxBookAuthors.Clear();
            textBoxBookTitle.Clear();
            numericUpDownYear.Value = DateTime.Now.Year;
            comboBoxGenres.SelectedIndex = 0;
            checkBoxMode.Checked = false;
            editedBook = null;
            buttonBookDelete.Enabled = false;
        }

        private void buttonBookSave_Click(object sender, EventArgs e)
        {
            bool inEditMode = checkBoxMode.Checked;

            if (string.IsNullOrEmpty(textBoxBookTitle.Text) || string.IsNullOrEmpty(textBoxBookAuthors.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            if (inEditMode)
            {
                editedBook.Title = textBoxBookTitle.Text;
                editedBook.Author = textBoxBookAuthors.Text;
                editedBook.Year = (int)numericUpDownYear.Value;
                editedBook.Genre = comboBoxGenres.SelectedItem as Genre;
                libraryManager.UpdateBook(editedBook);
            }
            else
            {
                Book newBook = new Book
                {
                    Title = textBoxBookTitle.Text,
                    Author = textBoxBookAuthors.Text,
                    Year = (int)numericUpDownYear.Value,
                    Genre = comboBoxGenres.SelectedItem as Genre
                };
                libraryManager.AddBook(newBook);
            }

            updateBooksList();
            buttonBookClear_Click(null, null);
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            var title = textBoxBookSearchTitle.Text;
            var bks = libraryManager.Search(title);
            if (bks.Count == 0)
            {
                MessageBox.Show("No books found.");
            }
            else
            {
                _dg.DataSource = bks;
            }
        }
    }
}
