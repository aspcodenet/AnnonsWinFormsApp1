namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private int n = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            n++;
            //Det har gått en sekund vad gör vi nu?
            label1.Text = "Rad 0 Stefans bla bla";
            label2.Text = "Rad 1 " + n.ToString();
            label3.Text = "Rad 2 Stefans bla bla";
        }
    }
}