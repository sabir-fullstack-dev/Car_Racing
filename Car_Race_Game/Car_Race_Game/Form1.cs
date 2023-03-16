using System.Windows.Forms;

namespace Car_Race_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int fcarLeft, scarLeft, tcarLeft;

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int duringTime = Convert.ToInt32(label7.Text);
            duringTime++;
            label7.Text = duringTime.ToString();

            int firstCarW = pictureBox1.Width;
            int secondCarW = pictureBox2.Width;
            int thirdCarW = pictureBox3.Width;

            int borderLeftWidth = label5.Left;

            pictureBox1.Left = pictureBox1.Left + random.Next(5, 15);
            pictureBox2.Left = pictureBox2.Left + random.Next(5, 15);
            pictureBox3.Left = pictureBox3.Left + random.Next(5, 15);
            if (pictureBox1.Left > pictureBox2.Left + 5 && pictureBox1.Left > pictureBox3.Left + 5)
            {
                label6.Text = "Red Car goes ahead !!";
            }
            if (pictureBox2.Left > pictureBox1.Left + 5 && pictureBox2.Left > pictureBox3.Left + 5)
            {
                label6.Text = "Blue Car goes ahead !!";
            }
            if (pictureBox3.Left > pictureBox2.Left + 5 && pictureBox3.Left > pictureBox1.Left + 5)
            {
                label6.Text = "Yellow Car goes ahead !!";
            }

            if (firstCarW + pictureBox1.Left >= borderLeftWidth)
            {
                timer1.Enabled = false;
                label6.Text = "Red Car is Winner";
            }

            if (secondCarW + pictureBox2.Left >= borderLeftWidth)
            {
                timer1.Enabled = false;
                label6.Text = "Blue Car is Winner";
            }

            if (thirdCarW + pictureBox3.Left >= borderLeftWidth)
            {
                timer1.Enabled = false;
                label6.Text = "Yellow Car is Winner";
            }
        }

        Random random = new Random();

        private void Form1_Load(object sender, EventArgs e)
        {
            fcarLeft = pictureBox1.Left;
            scarLeft = pictureBox2.Left;
            tcarLeft = pictureBox3.Left;

        }
    }
}