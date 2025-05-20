using ConfrencePlanner.Models;

namespace ConfrencePlanner
{
    public partial class Form1 : Form
    {
        private ConferenceManager _cm;
        public Form1()
        {
            InitializeComponent();
            _cm = new ConferenceManager();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            updateSpeakersGrid();
            updateReportsGrid();
        }

        private void updateSpeakersGrid()
        {
            _dgSpeakers.Rows.Clear();
            _dgSpeakers.Columns.Clear();
            _dgSpeakers.Columns.Add("FullName", "Full Name");
            _dgSpeakers.Columns.Add("Position", "Position");
            _dgSpeakers.Columns.Add("Org", "Organization");
            _dgSpeakers.Columns.Add("Email", "Email");
            foreach (var s in _cm.Speakers)
            {
                var row = new DataGridViewRow();
                row.CreateCells(_dgSpeakers);
                row.Cells[0].Value = s.FullName;
                row.Cells[1].Value = s.Position.Name;
                row.Cells[2].Value = s.Org;
                row.Cells[3].Value = s.Email;
                _dgSpeakers.Rows.Add(row);
            }
        }

        void updateReportsGrid()
        {
            _dgReports.Rows.Clear();
            _dgReports.Columns.Clear();
            _dgReports.Columns.Add("Title", "Title");
            _dgReports.Columns.Add("Speaker", "Speaker");
            _dgReports.Columns.Add("Date_and_Time", Text = "Date and Time");
            _dgReports.Columns.Add("Duration", Text = "Duration (min)");
            foreach (var r in _cm.Reports)
            {
                var row = new DataGridViewRow();
                row.CreateCells(_dgReports);
                row.Cells[0].Value = r.Title;
                row.Cells[1].Value = r.Speaker.FullName;
                row.Cells[2].Value = r.DateAndTime.ToString("dd.MM.yyyy HH:mm");
                row.Cells[3].Value = r.DurationMin;
                _dgReports.Rows.Add(row);
            }
        }

        private void buttonAddSpeaker_Click(object sender, EventArgs e)
        {
           var form = new AddNewSpeackerForm(_cm.Positions);
            var result = form.ShowDialog();
            if(result == DialogResult.OK)
            {
                _cm.AddSpeaker(form.Speaker);
                updateSpeakersGrid();
            }
        }
    }
}
