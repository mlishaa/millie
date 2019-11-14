using System;
using System.Text.RegularExpressions;

namespace ContactList
{
    class Contact
    {

        private String firstName;
        private String lastName;
        private String phone;

        public String FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public String LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public String Phone
        {
            get { return phone; }
            set
            {
                Regex re = new Regex(@"\d{3}-\d{3}-\d{4}");
                if (re.IsMatch(value))
                {
                    phone = value;
                }else
                {
                    value = "000-000-0000";
                }
            }
        }
        public Contact() { }

        public Contact(String firstName,String lastName,String phone)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Phone = phone;
        }

        public override string ToString()
        {
            String outPut = "";
            outPut += String.Format(" {0}\t{1}\t{2}", FirstName, LastName, Phone);
            return outPut;
        }
    }
}
