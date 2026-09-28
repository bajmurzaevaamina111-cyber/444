namespace WinFormsApp26
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int say;
            say = Convert.ToInt32(textBox1.Text);
            if (say % 2 == 0)
            {
                MessageBox.Show("bu bir çift sayýdýr");
            }
            if (say % 2 == 1)
            {
                MessageBox.Show("Bu bir tek say");
            }
        }
    }
}
