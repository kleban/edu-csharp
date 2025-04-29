namespace OtherWindows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            ChildForm childForm = new ChildForm("����� ������ ���");
            var result = childForm.ShowDialog();

            if(result == DialogResult.OK)
            {
                string title = childForm.Title;
                MessageBox.Show($"³������: {title}");

                label1.Text = $"{childForm.Product.Title} - ${Math.Round(childForm.Product.Price)}";
            }
            else
            {
                MessageBox.Show("ĳ���� ������� ��� ����������.");
            }
        }
    }
}
