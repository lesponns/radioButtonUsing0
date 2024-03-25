namespace radioButtonUsing0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                label2.Text = radioButton1.Text;
            }
            else if (radioButton2.Checked == true)
            {
                label2.Text = radioButton2.Text;
            }
            else if (radioButton3.Checked == true)
            {
                label2.Text = radioButton3.Text;
            }
            else
            {
                label2.Text = "Yüksek Lisans";
            }
        }
    }
}
