namespace WinFormsApp31
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int gun = Convert.ToInt32(DateTime.Now.DayOfWeek);
            switch (gun)
            {
                case 1:
                    MessageBox.Show("pazartesi");
                    break;
                case 2:
                    MessageBox.Show("sali");
                    break;
                case 3:
                    MessageBox.Show("carsamba");
                    break;
                case 4:
                    MessageBox.Show("persembe");
                    break;
                case 5:
                    MessageBox.Show("cuma");
                    break;
                case 6:
                    MessageBox.Show("cumartesi");
                    break;
                case 7:
                    MessageBox.Show("pazar");
                    break;
                default:
                    MessageBox.Show("hata olustu");
                    break;
            }
        }
    }
}
