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
    public partial class Form2 : Form
    {
        Users user1 = new Users();
        Users user2 = new Users();
        Users user3 = new Users();
        Users user4 = new Users();
        Users user5 = new Users();
        Users user6 = new Users();
        Users user7 = new Users();
        Users user8 = new Users();
        Users user9 = new Users();
        Users user10 = new Users();

        List<Users> allUsers = new List<Users>();

        public Form2()
        {
            InitializeComponent();
            //User1 data
            //==============

            user1.addUserData("Hina", "Ali", "1984-09-12", "Pakistan", "Karachi", "Female");
            user1.addInterests(new List<string> { "Tennis", "Travelling", "Blogging" });
            user1.addEducation("NED University of Engineering and Technology", "BS", "2005", "2008", "Graduate School");
            user1.addProfessionalInfo("Afiniti Software Solutions", "Software Engineer", true);

            //User2 data
            //==============
            user2.addUserData("Ahmed", "Waris", "1986-06-23", "India", "New Delhi", "Male");
            user2.addInterests(new List<string> { "Travelling", "Sports" });
            user2.addEducation("School of Planning and Architecture", "BB.Arch.", "2007", "2010", "Graduate School");
            user2.addProfessionalInfo("Star Tech S India - Delhi", "Architect Interior Designer", true);

            //User3 data
            user3.addUserData("Hammad", "Jilani", "1992-05-03", "Pakistan", "Lahore", "Male");
            user3.addInterests(new List<string> { "Hiking", "Ice skating" });
            user3.addEducation("LUMS", "MBA", "2015", "2017", "Postgraduate School");
            user3.addProfessionalInfo("Suleman Dawood School of Business - LUMS", "Assistant Professor", true);
            //User3 data

            //User4 data
            user4.addUserData("Faraz", "Ahmed", "1997-11-26", "Pakistan", "Karachi", "Male");
            user4.addInterests(new List<string> { "Cricket", "Football" });
            user4.addEducation("HU", "BSCS", "2017", "2021", "Graduate School");
            user4.addProfessionalInfo("Upwork", "Freelancer", true);

            user5.addUserData("Misbah Ul", "Haq", "1971-1-26", "Pakistan", "Lahore", "Male");
            user5.addInterests(new List<string> { "Cricket", "Football", "Badminton" });
            user5.addEducation("Govt. College Lahore", "BA", "1985", "1990", "Graduate School");
            user5.addProfessionalInfo("PCB", "Cricketer", false);

            user6.addUserData("Marie", "Price", "1987-03-11", "Afghanistan", "Kabul", "Female");
            user6.addInterests(new List<string> { "Cats", "Food" });
            user6.addEducation("Kabul University", "PhD", "2005", "2009", "Postgraduate School");
            user6.addProfessionalInfo("Klean Corp", "Urban Planner", false);

            user7.addUserData("Adam", "Bennet", "1985-12-05", "India", "New Delhi", "Male");
            user7.addInterests(new List<string> { "Photography", "Indian Food" });
            user7.addEducation("MIT", "BSEE", "2007", "2011", "College");
            user7.addProfessionalInfo("Lonely Records", "Front End Developer", true);

            user8.addUserData("Taha", "Murtaza", "1999-08-07", "Pakistan", "Quetta", "Male");
            user8.addInterests(new List<string> { "Photography", "illustrations", "" });
            user8.addEducation("HU", "BSCS", "2017", "2021", "College");
            user8.addProfessionalInfo("Beep Sheep", "Facebook", true);

            user9.addUserData("Natalie", "Brown", "1951-01-01", "China", "Hong Kong", "Female");
            user9.addInterests(new List<string> { "Python", "C++", "JS", "C#" });
            user9.addEducation("CBCC", "MSCS", "1975", "1980", "Graduate School");
            user9.addProfessionalInfo("MITT", "Researchers", false);

            user10.addUserData("Sana", "Faheem", "1994-03-28", "Pakistan", "Rawalpindi", "Female");
            user10.addInterests(new List<string> { "Books", "Food" });
            user10.addEducation("Maju", "MBA", "2015", "2017", "Graduate School");
            user10.addProfessionalInfo("Leopards Courier", "Kuch bhi", false);

            listBox1.Items.Add(user1);
            listBox1.Items.Add(user2);
            listBox1.Items.Add(user3);
            listBox1.Items.Add(user4);
            listBox1.Items.Add(user5);
            listBox1.Items.Add(user6);
            listBox1.Items.Add(user7);
            listBox1.Items.Add(user8);
            listBox1.Items.Add(user9);
            listBox1.Items.Add(user10);



            allUsers.Add(user1);
            allUsers.Add(user2);
            allUsers.Add(user3);
            allUsers.Add(user4);
            allUsers.Add(user5);
            allUsers.Add(user6);
            allUsers.Add(user7);
            allUsers.Add(user8);
            allUsers.Add(user9);
            allUsers.Add(user10);


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
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

        private void button1_Click(object sender, EventArgs e)
        {
            List<Users> list1 = new List<Users>();
            foreach (Users u in allUsers)
            {
                list1.Add(u);
            }

            if ((textBox1.Text == "") && (comboBox1.Text == "") && (comboBox1.Text == "") && (radioButton1.Checked==false) && (radioButton2.Checked == false))
            {
                foreach (Users i in list1)
                {
                    listBox1.Items.Add(i);
                }
            }
            if ((textBox1.Text !=""))
            {
                for (int i=0; i< list1.Count;)
                {
                    if( list1[i].Fname != textBox1.Text)
                    {
                        list1.Remove(list1[i]);
                    }
                    else
                    {
                        i++;
                    }
                }

            }
            if ((comboBox1.Text != ""))
            {
                for (int i = 0; i < list1.Count;)
                {
                    if (list1[i].Country != comboBox1.Text)
                    {
                        list1.Remove(list1[i]);
                    }
                    else
                    {
                        i++;
                    }
                }

            }
            if ((comboBox2.Text != ""))
            {
                for (int i = 0; i < list1.Count;)
                {
                    if (list1[i].City != comboBox2.Text)
                    {
                        list1.Remove(list1[i]);
                    }
                    else
                    {
                        i++;
                    }
                }
        
            }
            if ((radioButton1.Checked == true))
            {
                for (int i = 0; i < list1.Count;)
                {
                    if (list1[i].Gender != "Male")
                    {
                        list1.Remove(list1[i]);
                    }
                    else
                    {
                        i++;
                    }
                }
 
            }
            if ((radioButton2.Checked == true))
            {
                for (int i = 0; i < list1.Count;)
                {
                    if (list1[i].Gender != "Female")
                    {
                        list1.Remove(list1[i]);
                    }
                    else
                    {
                        i++;
                    }
                }
               
            }
            listBox1.Items.Clear();
            for (int i = 0; i < list1.Count; i++) 
            {
                listBox1.Items.Add(list1[i]);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != (null))
            {
                Users user = listBox1.SelectedItem as Users;
                Form1 myForm = new Form1(user, true);
                //this.Hide();
                myForm.Show();
                //this.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Console.WriteLine(listBox1.SelectedItem);
            //if (listBox1.SelectedIndex == 0)
            if (listBox1.SelectedItem != (null))
            {
                Users user = listBox1.SelectedItem as Users;
                Form1 myForm = new Form1(user, false);
                //this.Hide();
                myForm.Show();
                //this.Close();
            }
        }
    }
}
