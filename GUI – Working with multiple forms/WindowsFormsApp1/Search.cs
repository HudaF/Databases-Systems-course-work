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
    public partial class Search : Form
    {

        Users user1 = new Users();
        Users user2 = new Users();
        Users user3 = new Users();
        
        List<Users> allUsers= new List<Users>();
        

        public Search()
        {
            InitializeComponent();
            //User1 data
            //==============
            
            user1.addUserData("Hina", "Ali", "12-09-1984", "Pakistan", "Karachi", "Female");
            user1.addInterests(new List<string>{ "Tennis" ,"Travelling" ,"Blogging"});
            user1.addEducation("NED University of Engineering and Technology", "BS", "2005", "2008", "Graduate School");
            user1.addProfessionalInfo("Afiniti Software Solutions", "Software Engineer", true);

            //User2 data
            //==============
            user2.addUserData("Ahmed", "Waris",  "23-06-1986", "India", "New Delhi", "Male");
            user2.addInterests(new List<string> { "Travelling", "Sports" });
            user2.addEducation("School of Planning and Architecture", "BB.Arch.", "2007", "2010", "Graduate School");
            user2.addProfessionalInfo("Star Tech S India - Delhi", "Architect Interior Designer", true);

            //User3 data
            user3.addUserData("Hammad", "Jilani",  "03-05-1992", "Pakistan", "Lahore","Male");
            user3.addInterests(new List<string> { "Hiking"  , "Ice skating" });
            user3.addEducation("LUMS", "MBA", "2015", "2017", "Postgraduate School");
            user3.addProfessionalInfo("Suleman Dawood School of Business - LUMS", "Assistant Professor", true);
            //User3 data

            //User4 data



            allUsers.Add(user1);
            allUsers.Add(user2);
            allUsers.Add(user3);



        }

        private void Search_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //foreach (Users u in allUsers)
            //{
            //    listBox1.Items.Add(u.Fname + u.Lname);
            //}
            //listBox1.Items.Add(comboBox1.Text);


            string gender = "";
            if(radioButton1.Checked == true)
            {
                gender = radioButton1.Text;

            }
            else if(radioButton2.Checked == true)
            {
                gender = radioButton2.Text;

            }

            
            foreach (Users u in allUsers)
            {
                
                if (u.Gender == gender)
                {
                    listBox1.Items.Add(u.Fname + u.Lname);
                }

            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
