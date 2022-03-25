using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Mohammad Al-Qaisy

namespace Task04
{
    class Client
    {
        string userName, firstName, middleName, lastName, shortName, gender, phone, password, email;
        public Client(string _userName, string _firstName, string _middleName, string _lastName,
            string _shortName, string _gender, string _phone, string _password, string _email)
        {
            userName = _userName;
            firstName = _firstName;
            middleName = _middleName;
            lastName = _lastName;
            shortName = _shortName;
            gender = _gender;
            phone = _phone;
            password = _password;
            email = _email;
        }
        public string _userName
        {
            set { userName = value; }
            get { return userName; }
        }
        public string _firstName
        {
            set { firstName = value; }
            get { return firstName; }
        }
        public string _middleName
        {
            set { middleName = value; }
            get { return middleName; }
        }
        public string _lastName
        {
            set { lastName = value; }
            get { return lastName; }
        }
        public string _shortName
        {
            set { shortName = value; }
            get { return shortName; }
        }
        public string _gender
        {
            set { gender = value; }
            get { return gender; }
        }
        public string _phone
        {
            set { phone = value; }
            get { return phone; }
        }
        public string _password
        {
            set { password = value; }
            get { return password; }
        }
        public string _email
        {
            set { email = value; }
            get { return email; }
        }
       
    }
}
