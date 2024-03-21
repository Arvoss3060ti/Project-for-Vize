namespace Project_for_Vize
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 nesne = new Form2();
            nesne.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 nesne = new Form3();
            nesne.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 nesne = new Form4();
            nesne.Show();
        }
    }
}
