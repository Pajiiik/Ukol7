namespace _1610
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool condition = false;
        private void button1_Click(object sender, EventArgs e)
        {
            Form form2 = new Form();
            form2.Location = new Point(0,1000);
            form2.Size = new Size(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
            form2.Text = textBox3.Text;
            if (condition)
            {
                form2.FormBorderStyle = FormBorderStyle.Sizable;
            }
            else
            {
                form2.FormBorderStyle = FormBorderStyle.None;
            }

            form2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            condition = true;
        }
    }
}