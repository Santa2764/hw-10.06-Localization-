namespace WinForms_14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Text = Eng.FormName;
            label1.Text = Eng.txt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Text = Uk.FormName;
            label1.Text = Uk.txt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Text = Fr.FormName;
            label1.Text = Fr.txt;
        }
    }
}