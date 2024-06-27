namespace Ch3WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {   // this variable keeps arguments for Talk method.
            int len = Talker.Talk(textBox1.Text, 
                                 (int)numericUpDown1.Value);
            MessageBox.Show("Msg length is " + len);
        }
    }
}