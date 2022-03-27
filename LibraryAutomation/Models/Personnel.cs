namespace LibraryAutomation.Models
{
    internal class Personnel
    {
        public static string FIRST_NAME = "fname", LAST_NAME = "lname", GENDER = "gender", AGE = "age";
        public static string CONTACT_ADDRESS = "contact_add", PERSONNEL_EMAIL = "personnel_email", PERSSONEL_PASS = "personnel_pass";

        int id;
        string firstName;
        string lastName;
        bool gender;
        int age;
        string contactAddress;
        string personnelEmail;
        string personnelPass;

        public Personnel(string firstName, string lastName, bool gender, int age, string contactAddress, string personnelEmail, string personnelPass)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.gender = gender;
            this.age = age;
            this.contactAddress = contactAddress;
            this.personnelEmail = personnelEmail;
            this.personnelPass = personnelPass;
        }

        public int Id { get => id; }
        public string FirstName { get => firstName; }
        public string LastName { get => lastName; }
        public bool Gender { get => gender; }
        public int Age { get => age; }
        public string ContactAddress { get => contactAddress; }
        public string PersonnelEmail { get => personnelEmail; }
        public string PersonnelPass { get => personnelPass; }
    }
}
