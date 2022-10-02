namespace assignment3_arturpushkov
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
            textBox1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double heightInM = (double)(numericUpDown2.Value / 100);
            double dmi = (double)(numericUpDown1.Value) / (heightInM * heightInM);
            string status;
            switch (dmi)
            {
                case < 18.5:
                    status = "Underweight";
                    break;
                case > 25:
                    status = "Overweight";
                    break;
                default: 
                    status = "Optimal";
                    break;
            }
            textBox1.Text = String.Format("{0:0.00}", dmi) + System.Environment.NewLine + "Status: " + status;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}