namespace CinemaApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 10 places, 7 rows
            int x = 10, y = 10;

            const int b_width = 35;
            const int b_height = 35;

            int place_number = 1;

            for (int i = 1; i <= 7; i++)
            {
                for(int j = 1; j <= 10; j++)
                {
                    Button btn = new Button();
                    btn.Text = (place_number++).ToString();
                    btn.Width = b_width;
                    btn.Height = b_height;
                    btn.Location = new Point(x, y);
                    btn.Click += Btn_Click;
                    x += b_width + 10;
                    panel.Controls.Add(btn);
                }

                y += 10 + b_height;
                x = 10;
            }


            
            
            
            
        }

        private void Btn_Click(object? sender, EventArgs e)
        {
            var btn = sender as Button;
            btn.BackColor = Color.Red;
            MessageBox.Show(btn.Text);
        }
    }
}
