namespace ComponentsDemo1
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            var r = new Random();
            for (int i = 0; i < 10; i++)
            {
                checkedListBoxRandNumbers.Items.Add(r.Next(100));
            }
        }

        private void buttonSum_Click(object sender, EventArgs e)
        {

            if (checkedListBoxRandNumbers.CheckedItems.Count > 0)
            {
                int sum = 0;
                foreach (var item in checkedListBoxRandNumbers.CheckedItems)
                {
                    int number = (int)item;
                    sum += number;
                }
                labelSum.Text = $"{sum}";
            }
        }

        private void buttonCombineTime_Click(object sender, EventArgs e)
        {
            dateTimePicker.Value = new DateTime(datePicker.Value.Year,
                datePicker.Value.Month,
                datePicker.Value.Day,
                tmePicker.Value.Hour,
                tmePicker.Value.Minute, 0);
        }
    }
}
