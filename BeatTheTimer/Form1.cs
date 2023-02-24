namespace BeatTheTimer
{
    public partial class Form1 : Form
    {
        public int count = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            Color color = btn.BackColor;
            AssignColor(color);
        }

        private void AssignColor(Color color)
        {
            switch (count)
            {
                case 1:
                    pictureBox1.BackColor = color;
                    break;
                case 2:
                    pictureBox2.BackColor = color;
                    break;
                case 3:
                    pictureBox3.BackColor = color;
                    break;
                case 4:
                    pictureBox4.BackColor = color;
                    break;
                case 5:
                    pictureBox5.BackColor = color;
                    break;
                case 6:
                    pictureBox6.BackColor = color;
                    break;
                case 7:
                    pictureBox7.BackColor = color;
                    break;
                case 8:
                    pictureBox8.BackColor = color;
                    break;
                case 9:
                    pictureBox9.BackColor = color;
                    break;
                case 10:
                    pictureBox10.BackColor = color;
                    break;
                case 11:
                    pictureBox11.BackColor = color;
                    break;
                case 12:
                    pictureBox12.BackColor = color;
                    break;
                case 13:
                    pictureBox13.BackColor = color;
                    break;
                case 14:
                    pictureBox14.BackColor = color;
                    break;
                case 15:
                    pictureBox15.BackColor = color;
                    break;
                case 16:
                    pictureBox16.BackColor = color;
                    break;
                case 17:
                    pictureBox17.BackColor = color;
                    break;
                case 18:
                    pictureBox18.BackColor = color;
                    break;
                case 19:
                    pictureBox19.BackColor = color;
                    break;
                case 20:
                    pictureBox20.BackColor = color;
                    break;
            }

            count++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            Color color = btn.BackColor;
            AssignColor(color);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            Color color = btn.BackColor;
            AssignColor(color);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            Color color = btn.BackColor;
            AssignColor(color);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            Color color = btn.BackColor;
            AssignColor(color);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            Color color = btn.BackColor;
            AssignColor(color);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            Color color = btn.BackColor;
            AssignColor(color);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            Color color = btn.BackColor;
            AssignColor(color);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            Color color = btn.BackColor;
            AssignColor(color);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            Color color = btn.BackColor;
            AssignColor(color);
        }
    }
}