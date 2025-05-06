using CinemaApp.Helpers;
using CinemaApp.Models;

namespace CinemaApp
{
    public partial class MainForm : Form
    {
        Cinema cinema = new Cinema();
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            updateMoviesList();
            updateSessionsList();
            listBoxAgeRatings.Items.AddRange(CinemaHelper.AgeRatings.ToArray());
            listBoxGenres.Items.AddRange(CinemaHelper.Genres.ToArray());
            comboBoxMovieAgeRating.Items.AddRange(CinemaHelper.AgeRatings.ToArray());
            comboBoxMovieGenre.Items.AddRange(CinemaHelper.Genres.ToArray());
            comboBoxMovieAgeRating.SelectedIndex = 0;
            comboBoxMovieGenre.SelectedIndex = 0;

            comboBoxHall.Items.AddRange(cinema.GetHalls().ToArray());
            comboBoxHall.SelectedIndex = 0;
        }

        private void updateSessionsList()
        {
            listBoxSessions.Items.Clear();
            listBoxSessions.Items.AddRange(cinema.GetSessions().ToArray());
        }

        private void updateMoviesList()
        {
            listBoxMovies.Items.Clear();
            listBoxMovies.Items.AddRange(cinema.GetMovies().ToArray());
            comboBoxSessionMovie.Items.Clear();
            comboBoxSessionMovie.Items.AddRange(cinema.GetMovies().ToArray());
            comboBoxSessionMovie.SelectedIndex = 0;
        }

        private void changeEndTime(object sender, EventArgs e)
        {
            if (dateTimePickerStartTime.Value != null)
            {

                DateTime startTime = dateTimePickerStartTime.Value;
                DateTime startDate = dateTimePickerStartDate.Value;

                DateTime start = new DateTime(startDate.Year, startDate.Month, startDate.Day, startTime.Hour, startTime.Minute, 0);
                var movie = comboBoxSessionMovie.SelectedItem as Movie;
                DateTime endTime = start.AddMinutes(movie.Duration);
                dateTimePickerEndTime.Value = endTime;
            }
        }



        private void buttonMovieClean_Click(object sender, EventArgs e)
        {
            textBoxMovieTitle.Clear();
            numericMovieDuration.Value = 0;
            comboBoxMovieAgeRating.SelectedIndex = 0;
            comboBoxMovieGenre.SelectedIndex = 0;
        }

        private void buttonMovieSave_Click(object sender, EventArgs e)
        {
            string title = textBoxMovieTitle.Text;
            string genre = comboBoxMovieGenre.SelectedItem.ToString();
            int duration = (int)numericMovieDuration.Value;
            string ageRating = comboBoxMovieAgeRating.SelectedItem.ToString();

            if (string.IsNullOrEmpty(title))
            {
                MessageBox.Show("Please enter a movie title.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            Movie movie = new Movie
            {
                Title = title,
                Genre = genre,
                Duration = duration,
                AgeRating = ageRating
            };
            if (inMovieEditMode)
            {
                movie.Id = editMovie.Id;
                cinema.UpdateMovie(movie);
            }
            else
            {
                cinema.AddMovie(movie);
            }
            inMovieEditMode = false;
            checkBoxMovieInEditMode.Checked = inMovieEditMode;
            editMovie = null;

            updateMoviesList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBoxSessionMovie.SelectedIndex = 0;
            dateTimePickerStartTime.Value = DateTime.Now;
            dateTimePickerStartDate.Value = DateTime.Now;
            comboBoxHall.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime startTime = dateTimePickerStartTime.Value;
            DateTime startDate = dateTimePickerStartDate.Value;

            DateTime start = new DateTime(startDate.Year, startDate.Month, startDate.Day, startTime.Hour, startTime.Minute, 0);

            var result = cinema.AddSession(new Session
            {
                Hall = comboBoxHall.SelectedItem.ToString(),
                Movie = comboBoxSessionMovie.SelectedItem as Movie,
                StartTime = start
            });

            if (result)
            {
                updateSessionsList();
            }
            else
            {
                MessageBox.Show("Session time is not valid. Please choose another time.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private bool inMovieEditMode = false;
        private Movie editMovie = null;

        private void listBoxMovies_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonRemoveMovie.Enabled = listBoxMovies.SelectedIndex != -1;

            inMovieEditMode = true;
            editMovie = listBoxMovies.SelectedItem as Movie;

            if (editMovie is not null)
            {
                textBoxMovieTitle.Text = editMovie.Title;
                numericMovieDuration.Value = editMovie.Duration;
                comboBoxMovieGenre.SelectedItem = editMovie.Genre;
                comboBoxMovieAgeRating.SelectedItem = editMovie.AgeRating;
                checkBoxMovieInEditMode.Checked = inMovieEditMode;
            }
        }

        private void buttonRemoveMovie_Click(object sender, EventArgs e)
        {
            var movie = listBoxMovies.SelectedItem as Movie;

            if (movie is not null)
            {
                var result = cinema.RemoveMovie(movie);
                if (result)
                {
                    buttonRemoveMovie.Enabled = false;
                    updateMoviesList();
                } 
                else
                {
                    MessageBox.Show("Cannot remove movie. It has active sessions.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }

            inMovieEditMode = false;
            checkBoxMovieInEditMode.Checked = inMovieEditMode;
            editMovie = null;
        }
    }
}
