namespace CinemaApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int rows = 7;
            int cols = 5;

            int x = 10, y = 10;
            const int width = 40;
            const int height = 40;

            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            for(int i = 0; i < rows; i++)
            {
                for(int j = 0; j < cols; j++)
                {
                    Button btn = new Button();
                    btn.Text = $"{alphabet[j]}{i+1}";
                    btn.Location = new Point(x, y);
                    btn.Width = width;
                    btn.Height = height;
                    btn.BackColor = Color.White;
                    btn.Click += Btn_Click;
                    btn.Tag = "-";
                    x += 10 + width;
                    panel1.Controls.Add(btn);
                }
                y+= 10 + height;
                x = 10;
            }                        
        }

        private void Btn_Click(object? sender, EventArgs e)
        {
            Button btn = sender as Button;
            if(btn.Tag.ToString() == "-")
            {
                btn.Tag = "+";
                btn.BackColor = Color.Red;                
            } 
            else
            {
                btn.Tag = "-";
                btn.BackColor = Color.White;
                MessageBox.Show(btn.Text);
            }
            
            
        }
    }
}
