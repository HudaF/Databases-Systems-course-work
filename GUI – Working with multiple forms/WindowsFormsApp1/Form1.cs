using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Users temp;
        public Form1(Users user, bool edit)
        {
            temp = user;
            InitializeComponent();
            textBox1.Text = user.Fname;
            textBox2.Text = user.Lname;
            comboBox1.Text = user.Country;
            comboBox2.Text = user.City;
            if (user.Gender == "Male")
            {
                Male.Checked = true;
            }
            if (user.Gender == "Female")
            {
                Female.Checked = true;
            }

            listBox1.Items.Clear();
            foreach (string i in user.Interests)
            {
                listBox1.Items.Add(i);
            }
            textBox6.Text = user.Education[0];
            textBox7.Text = user.Education[1];
            textBox3.Text = user.Education[2];
            textBox4.Text = user.Education[3];
            if (user.Education[4] == "College")
            {
                radioButton1.Checked = true;
            }
            if (user.Education[4] == "Graduate School")
            {
                radioButton2.Checked = true;
            }
            if (user.Education[4] == "Postgraduate School")
            {
                radioButton3.Checked = true;
            }
            textBox9.Text = user.Professional[0];
            textBox10.Text = user.Professional[1];

            if(user.Professional[2] == "True")
            {
                checkBox1.Checked = true;
            }
            if (user.Professional[2] == "False")
            {
                checkBox1.Checked = false;
            }

            DateTime enteredDate = DateTime.Parse(user.DOB);
            dateTimePicker3.Value = enteredDate;
            this.Enabled = edit;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox6.Clear();
            textBox7.Clear();
            textBox3.Clear();
            textBox4.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "India")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Mumbai");
                comboBox2.Items.Add("New Delhi");
                comboBox2.Items.Add("Bhopal");
                comboBox2.Items.Add("Lucknow");
            }
            else if (comboBox1.Text == "Afghanistan")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Kabul");
                comboBox2.Items.Add("Kunduz");
                comboBox2.Items.Add("Ghazni");
            }
            else if (comboBox1.Text == "China")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Bejing");
                comboBox2.Items.Add("Shanghai");
                comboBox2.Items.Add("Hong Kong");
            }
            else if (comboBox1.Text == "Pakistan")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Lahore");
                comboBox2.Items.Add("Karachi");
                comboBox2.Items.Add("Islamabad");
                comboBox2.Items.Add("Rawalpindi");
                comboBox2.Items.Add("Quetta");
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!(listBox1.Items.Contains(textBox8.Text)))
                listBox1.Items.Add(textBox8.Text);
            textBox8.Clear();
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1_Click(sender,e);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox9.Clear();
            textBox10.Clear();
            checkBox1.Checked = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button4_Click(sender, e);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter First Name","Error");
            }
            else if (textBox2.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter Last Name", "Error");
            }
            else if (dateTimePicker3.Value >= DateTime.Today)
            {
                MessageBox.Show("Please enter valid Birth Date", "Error");
            }
            temp.Fname = textBox1.Text;
            temp.Lname = textBox2.Text;
            temp.Country = comboBox1.Text;
            temp.City = comboBox2.Text;
            if (Male.Checked == true)
            {
                temp.Gender = "Male";
            }
            if (Female.Checked == true)
            {
                temp.Gender = "Female";
            }
            foreach (string i in listBox1.Items)
            {
                temp.Interests.Add(i);
            }
            temp.Education[0] = textBox6.Text;
            temp.Education[1] = textBox7.Text;
            temp.Education[2] = textBox3.Text;
            temp.Education[3] = textBox4.Text;
            if (radioButton1.Checked == true)
            {
                temp.Education[4] = "College";
            }
            if (radioButton2.Checked == true)
            {
                temp.Education[4] = "Graduate School";
            }
            if (radioButton3.Checked == true)
            {
                temp.Education[4] = "Postgraduate School";
            }
            temp.Professional[0] = textBox9.Text;
            temp.Professional[1] = textBox10.Text;
            if (radioButton1.Checked == true)
            {
                temp.Professional[2] = "true";
            }
            if (radioButton1.Checked == false)
            {
                temp.Professional[2] = "true";
            }
            temp.DOB = dateTimePicker3.Value.ToString();
            this.Close();


        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(13))
            {
                button3_Click(sender,e);
                e.Handled = true;
            }
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            button3.BackColor = Color.WhiteSmoke;
        }
        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = Color.LightGray;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
