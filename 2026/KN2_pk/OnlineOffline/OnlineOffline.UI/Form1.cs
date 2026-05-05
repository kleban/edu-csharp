using OnlineOffline.Core;

namespace OnlineOffline.UI
{
    public partial class Form1 : Form
    {
        private readonly LearningContext _context;
        private readonly ResultsRepository _repository;
        public Form1()
        {
            InitializeComponent();
            _context = new LearningContext();
            _repository = new ResultsRepository(_context);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.AddRange(_repository.GetAll().ToArray());
        }
    }
}
