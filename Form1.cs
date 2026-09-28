namespace WinFormsApp23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte scor1, scor2;
            scor1 = 1;
            scor2 = 4;
            if(scor1>scor2)
            {
                MessageBox.Show("1.Takim kazandi");
            }
        }
    }
}
