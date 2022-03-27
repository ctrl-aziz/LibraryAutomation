using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAutomation.Models
{
    internal class Student
    {
        public static String FIRST_NAME = "fname", LAST_NAME = "lname", GENDER = "gender", AGE = "age";
        public static String CONTACT_ADDRESS = "contact_add", STUDENT_EMAIL = "stud_email", STUDENT_PASS = "stud_pass";

        int id;
        String firstName;
        String lastName;
        bool gender;
        int age;
        String contactAddress;
        String studentEmail;
        String studentPass;

        public Student(String firstName, String lastName, bool gender, int age, String contactAddress, String studentEmail, String studentPass)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.gender = gender;
            this.age = age;
            this.contactAddress = contactAddress;
            this.studentEmail = studentEmail;
            this.studentPass = studentPass;
        }

        public int Id { get => id; }
        public String FirstName { get => firstName; }
        public String LastName { get => lastName; }
        public bool Gender { get => gender; }
        public int Age { get => age; }
        public String ContactAddress { get => contactAddress; }
        public String StudentEmail { get => studentEmail; }
        public String StudentPass { get => studentPass; }
    }
}
