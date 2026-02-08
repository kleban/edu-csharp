namespace ControlsDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonClick_Click(object? sender, EventArgs e)
        {
            // x -> width
            // y -> height

            int x = 20;
            int y = 20;
            var width = (this.Width - 40) / 10;
            var height = 40;
            int letterNum = 65;
            int count = (int)numericUpDownPlaces.Value;

            while (count > 0)
            {
                int numberInRow = count >= 10 ? 10 : count;
                for (int i = 0; i < numberInRow; i++)
                {
                    var button = new Button
                    {
                        Location = new Point(x, y),
                        Size = new Size(width, height),
                        Text = $"¹{(char)letterNum}{i + 1}",
                        Tag = $"{(char)letterNum}{i + 1}",
                    };
                    button.Click += bookPlace;
                    x += width;
                    this.Controls.Add(button);
                }
                count -= numberInRow;
                x = 20;
                y = y + height;
                letterNum++;
            }
        }



        private void bookPlace(object? sender, EventArgs e)
        { 
            Button b = sender as Button;
           if (b != null)
            {
                string place = b.Tag.ToString();
                if (MessageBox.Show($"Do you want to book {place}?", "Booking", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    b.BackColor = Color.Red;
                    b.ForeColor = Color.White;
                   // b.Enabled = false;
                }
            }
        }
    }
}
