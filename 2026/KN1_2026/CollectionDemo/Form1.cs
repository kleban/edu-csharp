using CollectionDemo.Model;

namespace CollectionDemo
{
    public partial class Form1 : Form
    {
        private SubscriptionManager subscriptionManager;
        public Form1()
        {
            InitializeComponent();

            subscriptionManager = new SubscriptionManager();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            updateComboBox();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Random r = new Random();

            var subscription = new Subscription
            {
                Id = r.Next(0, 1000),
                Price = r.Next(100, 10000),
                Title = "Subscription_" + r.Next(100, 200)
            };

            subscriptionManager.Add(subscription);

            updateComboBox();
        }

        private void updateComboBox()
        {
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(subscriptionManager.GetSubscriptions().ToArray());
            comboBox1.SelectedIndex = 0;
        }
    }
}
