using System.Reflection.Emit;

namespace TP_MODUL3_103022400030
{
    public partial class Form1 : Form
    {
        int angka = 0;
        int angka1 = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click_1(object sender, EventArgs e)
        {

        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            Label1.Text = Label1.Text + "1";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Label1.Text = Label1.Text + "2";
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Label1.Text = Label1.Text + "3";
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Label1.Text = Label1.Text + "4";
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Label1.Text = Label1.Text + "5";
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            Label1.Text = Label1.Text + "6";
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            Label1.Text = Label1.Text + "7";
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            Label1.Text = Label1.Text + "8";
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            Label1.Text = Label1.Text + "9";
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            angka = Convert.ToInt16(Label1.Text);
            Label1.Text = " ";
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            Label1.Text = Label1.Text + "0";
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            angka1 = Convert.ToInt16(Label1.Text);
            int equal = angka + angka1;
            Label1.Text = equal.ToString();
        }

    }
}
