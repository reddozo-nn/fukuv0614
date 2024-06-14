namespace fukuv0614
{
    public partial class Form1 : Form
    {
        static Random random = new Random();
        
        int count = 0;
        int ans = random.Next(0, 51);
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            int yosou;

            yosou = int.Parse(textBox1.Text);
            count++;

            MessageBox.Show($"{count}âÒñ⁄ÇÃíßêÌ");

            if (ans == yosou)
            {
                MessageBox.Show("Bingo!!");
                count = 0;
                ans = random.Next(0, 51);
            }

            else if (ans < yosou)
            {
                MessageBox.Show("Less");
            }

            else
            {
                MessageBox.Show("Greater");
            }
        }
    }
}