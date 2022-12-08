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

        public string first_name { set; get; }

        public string second_name { set; get; }

        public string third_name { set; get; }

        public string phone { set; get; }

        public string birthday { set; get; }

        public string departament { set; get; }

        public Employer() { }

        public Employer(int id, string first_name, string second_name, string third_name, string phone, string birthday, string departament) {
            this.id = id;
            this.first_name = first_name;
            this.second_name = second_name;
            this.third_name = third_name;
            this.phone = phone;
            this.birthday = birthday;
            this.departament = departament;
        }

    }
}
