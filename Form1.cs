namespace StudentRegistrationApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp ";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(openFileDialog.FileName);

            }
        }
        private void DisplayStudent(string firstname, string middlename, string lastname, string gender, string dob, string program)
        {
            MessageBox.Show($"Student name: {firstname} {middlename} {lastname} \n" + $"Gender: {gender}\n" + $"Date of Birth: {dob}\n" + $"Program: {program}");
        }
        private void DisplayStudent(string firstname, string middlename, string lastname, string program)
        {
            MessageBox.Show($"Student name: {firstname} {middlename} {lastname}\n" + $"Program: {program}");
        }
        private void DisplayStudent(string firstname, string lastname)
        {
            MessageBox.Show($"Student name: {firstname} {lastname}");
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string lname = textBox1.Text;
            string fname = textBox2.Text;
            string mname = textBox3.Text;
            string gender = radioButton1.Checked ? "Male" : "Female";
            string dob = $"{comboBox1.Text}{comboBox2.Text}{comboBox3.Text}";
            string program = comboBox4.Text;

            DisplayStudent(fname, mname, lname, gender, dob, program);
            DisplayStudent(fname, mname, lname, program);
            DisplayStudent(fname, lname);


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
