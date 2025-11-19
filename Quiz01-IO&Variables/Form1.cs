namespace Quiz01_IO_Variables
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void q2SExampleButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Go Jays!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("6");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("To output two decimal places use F2");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("4 items at 2.25 each with tax will be $10.17");
        }

        private void q01Button_Click(object sender, EventArgs e)
        {
            q1OutputLabel.Text = "Go Bears!";
        }

        private void q02Button_Click(object sender, EventArgs e)
        {
            q2OutputLabel.Text = "Go " + q2TextBox.Text;
        }

        private void q03Button_Click(object sender, EventArgs e)
        {
            try
            {
                int num1 = Convert.ToUInt16(num1Box.Text);
                int num2 = Convert.ToUInt16(num2Box.Text);

                q3OutputLabel.Text = Convert.ToString(num1 * num2);
            }
            catch
            {
                q3OutputLabel.Text = "Bad input try 1 and 2";
            }
        }

        private void q04Button_Click(object sender, EventArgs e)
        {
            try
            {
                int numOfItems = Convert.ToUInt16(noItemsBox.Text);
                int costOfItems = Convert.ToUInt16(costBox.Text);
                q4OutputLabel.Text = numOfItems + " Items costs " + costOfItems + " per item with Tax the total is " + (numOfItems * costOfItems * 1.13).ToString("F2");
            }
            catch
            {
                q4OutputLabel.Text = "Bad input try something else";
            }
        }
    }
}
