using ForbesRank.Domain;

namespace ForbesRank.FormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            _ctx = new ForbesConrext();
        }

        private ForbesConrext _ctx;

        private void Form1_Load(object sender, EventArgs e)
        {
            listBoxForbes.Items.AddRange(_ctx.People.ToArray());
        }
    }
}
