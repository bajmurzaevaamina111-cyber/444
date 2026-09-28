namespace WinFormsApp21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string ad, soyad, topla;
            ad = "Zeynep";
            soyad = "sare";
            topla = ad + " " + soyad;
            MessageBox.Show(topla);
        }
    }
}
