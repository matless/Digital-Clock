namespace Digital_Clock
{
    public partial class DigitalClock : Form
    {
        public DigitalClock()
        {
            InitializeComponent();
            redButton.FlatStyle = FlatStyle.Flat;
            blueButton.FlatStyle = FlatStyle.Flat;
            greenButton.FlatStyle = FlatStyle.Flat;
            yellowButton.FlatStyle = FlatStyle.Flat;
            pinkButton.FlatStyle = FlatStyle.Flat;
            styleButton1.FlatStyle = FlatStyle.Flat;
            stylebutton2.FlatStyle = FlatStyle.Flat;
            stylebutton3.FlatStyle = FlatStyle.Flat;
        }

        private void DigitalClock_Load(object sender, EventArgs e)
        {
            clockTimer.Start();


        }

        private void clockTimer_Tick(object sender, EventArgs e)
        {
            clockLabel.Text = DateTime.Now.ToString("G");
        }

        private void redButton_Click(object sender, EventArgs e)
        {
            clockLabel.ForeColor = Color.Red;

        }

        private void blueButton_Click(object sender, EventArgs e)
        {
            clockLabel.ForeColor = Color.Blue;

        }
        private void greenButton_Click(object sender, EventArgs e)
        {
            clockLabel.ForeColor = Color.Green;

        }
        private void yellowButton_Click(object sender, EventArgs e)
        {
            clockLabel.ForeColor = Color.Yellow;

        }

        private void pinkButton_Click(object sender, EventArgs e)
        {
            clockLabel.ForeColor = Color.Pink;


        }

        private void styleButton1_Click(object sender, EventArgs e)
        {
            clockLabel.Font = new Font("SimSun", 90, FontStyle.Italic);

        }

        private void stylebutton2_Click(object sender, EventArgs e)
        {
            clockLabel.Font = new Font("Ink Free", 90, FontStyle.Bold);


        }

        private void stylebutton3_Click(object sender, EventArgs e)
        {
            clockLabel.Font = new Font("Comic Sans", 90, FontStyle.Regular);


        }

        private void date_Click(object sender, EventArgs e)
        {

        }

    }   } 