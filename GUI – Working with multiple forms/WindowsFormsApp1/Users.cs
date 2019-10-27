using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{   public
    class Users
    {
        public string Fname;
        public string Lname;
        public string DOB;
        public string Country;
        public string City;
        public string Gender;

        public List<string> Interests;
        public List<string> Education;
        public List<string> Professional;

        

        public void addUserData(string fn , string  ln, string dob, string country, string city, string gender)
        {
            Fname = fn;
            Lname = ln;
            DOB = dob;
            Country = country;
            City = city;
            Gender = gender;

        }

        public void addInterests(List<string> newInterest)
        {
            Interests = newInterest;
        }

        public void addEducation(string schl , string deg , string frm , string to , string attendFor)
        {
           Education =  new List<string> { schl, deg, frm, to, attendFor };

        }

        public void addProfessionalInfo(string employer ,string jobTitle , bool currentJob)
        {
            Professional= new List<string> { employer, jobTitle, currentJob.ToString() };
        }

        public override string ToString()
        {
            return Fname + " " + Lname;

        }

    }
}
