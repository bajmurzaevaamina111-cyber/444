namespace WinFormsApp25
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte say1, say2;
            say1 = Convert.ToByte(textBox1.Text);
            say2 = Convert.ToByte(textBox2.Text);
            if (say1 > say2)
            {
                MessageBox.Show("1.say 2.saydan buyuktur");
            }
            if (say1 == say2)
            {
                MessageBox.Show("sayilar esittir");
            }
            if (say1 < say2)
            {
                MessageBox.Show("2.say 1.saydan buyuktur");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }
    }
}
