using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Что_то_на_казахском
{
    class Employer
    {

        public int id { set; get; }

        private string first_name, second_name, third_name, phone, birthday, departament;

        public string First_name
        {
            get { return first_name; }
            set { first_name = value; }
        }

        public string Second_name
        {
            get { return second_name; }
            set { second_name = value; }
        }

        public string Third_name
        {
            get { return third_name; }
            set { third_name = value; }
        }

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        public string Birthday
        {
            get { return birthday; }
            set { birthday = value; }
        }
        public string Departament
        {
            get { return departament; }
            set { departament = value; }
        }

        public Employer() { }

        public Employer(string first_name, string second_name, string third_name, string phone, string birthday, string departament) {
            this.first_name = first_name;
            this.second_name = second_name;
            this.third_name = third_name;
            this.phone = phone;
            this.birthday = birthday;
            this.departament = departament;
        }

    }
}
