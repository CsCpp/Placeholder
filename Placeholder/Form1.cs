namespace Placeholder
{
    public partial class Form1 : Form
    {
        private string placeholderText = "¬ведите логин";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Gray;
            textBox1.Text = placeholderText;
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == placeholderText)
            {
                textBox1.Text = string.Empty;
                textBox1.ForeColor = Color.Black;

            }

        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if(textBox1.Text == string.Empty) 
            {
                textBox1.ForeColor = Color.Gray;
                textBox1.Text = placeholderText;
            }
        }
    }
}
