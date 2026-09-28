namespace WinFormsApp24
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte yas;
            yas = Convert.ToByte(textBox1.Text);
            if (yas>17)
            {
                MessageBox.Show("Adult");
            }
            else if(yas<18)
            {
                MessageBox.Show("Child");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
