namespace WinFormsHW2
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

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           

            Label label = new Label();
            Label label2 = new Label();

            List<CheckBox> info = new List<CheckBox>() { checkBox1, checkBox2, checkBox3 };
            foreach (CheckBox checkBox in info)
            {
                if (checkBox.Checked)
                {
                    label.Text += checkBox.Text + " ";
                }
            }
            List<RadioButton> radioButtons = new List<RadioButton>() { radioButton1, radioButton2, radioButton3 };
            foreach (RadioButton radioButton in radioButtons)
            {
                if (radioButton.Checked)
                {
                    label2.Text = radioButton.Text;
                }
            }
            if (dateTimePicker2.Value < dateTimePicker1.Value)
            {
                MessageBox.Show("The date of end trip can't be early than start of a trip", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dateTimePicker2.Value = dateTimePicker1.Value;
                return;
            }
            else if (string.IsNullOrEmpty(label1.Text) || string.IsNullOrEmpty(label2.Text) || string.IsNullOrEmpty(comboBox1.Text))
            {
                MessageBox.Show("Please enter all lines", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show($"Date start trip: {dateTimePicker1.Text} Date end trip: {dateTimePicker2.Text} \n Transport: {label2.Text}\n Place: {comboBox1.Text}\n Additional services: {label.Text}");
            }
        }
    }
}
