namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public int RandomNummer
        {
            get; set;
        }

        public void SetRandomNummer()
        {
            Random Number = new Random();
            int Number1 = Number.Next(int.Parse(listBox1.Text));
            RandomNummer = Number1;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SetRandomNummer();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = RandomNummer.ToString();
            string User = textBox2.Text;
            string DatorTal = textBox1.Text;
            int User1 = int.Parse(User);
            int DatorTal1 = int.Parse(DatorTal);

            if (User1 > DatorTal1)
            {
                richTextBox1.Text = "Du gissar mindre än datorens tal";
            }
            else if (User1 < DatorTal1)
            {
                richTextBox1.Text = "Du gissar större än datoresn tall";
            }
            else if (User1 == DatorTal1)
            {
                richTextBox1.Text = "Du gissade rätt!";
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}