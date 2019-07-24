using System;

namespace StudentProject {
    class Program {
        static void Main(string[] args)
        {
            Student brailee = new Student();
            brailee.FirstName = "Brailee";
            brailee.LastName = "Begley";
            brailee.IsPaid = true;
            brailee.Birthday = new DateTime(1995, 11, 14);

            Student jesse = new Student();
            jesse.FirstName = "Jesse";
            jesse.IsPaid = true;
            jesse.Birthday = new DateTime(1990, 1, 1);

            Student briana = new Student();
            briana.FirstName = "Briana";
            briana.LastName = "Presly";
            briana.IsPaid = true;
            briana.Address = "123 Cherry Street";
            briana.City = "Cincinnati";

            Student titus = new Student();
            titus.FirstName = "Titus";
            titus.LastName = "Moore";
            titus.IsPaid = false;
            titus.Phone = "5135555555";
            titus.Birthday = new DateTime(1999, 04, 27);


         }
    }
    class Student {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string state { get; set; }
        public string Zip { get; set; }
        public string Bootcamp { get; set; }
        public string Status { get; set; } // current, future, past
        public string Email { get; set; }
        public string Phone { get; set; }
        public bool IsPaid { get; set; } = false;
        public DateTime Birthday { get; set; }
    }
            }

