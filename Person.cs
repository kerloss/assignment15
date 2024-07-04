using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_15
{
    struct Person
    {
        private string name;
        private int age;

        //Constructor to initialize the properties
        public Person(string _name, int _age)
        {
            this.name = _name;
            this.age = _age;
        }

        //proparty for name
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        //proparty for age
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

    }

}
