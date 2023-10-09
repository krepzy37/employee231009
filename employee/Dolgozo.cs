using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employee
{
    class Dolgozo
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
        public string Department { get; set; }
        public string Position { get; set; }
        public string Gender { get; set; }
        public string MaritalStatus { get; set; }
        public int Salary { get; set; }

        public Dolgozo(string d)
        {
            var e = d.Split(';');
            Name = e[0];
            Age = int.Parse(e[1]);
            City = e[2];
            Department = e[3];
            Position = e[4];
            Gender = e[5];
            MaritalStatus = e[6];
            Salary = int.Parse(e[7]);
        }

        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}, Department: {Department}, Position: {Position}, Gender: {Gender}, Marital status: {MaritalStatus}, Salary (EUR): {Salary}";
        }
    }
}
