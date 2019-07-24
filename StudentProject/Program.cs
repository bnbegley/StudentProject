using System;

namespace StudentProject {
    class Program {
        static void Main(string[] args)
        {
            Student brailee = new Student();
            brailee.SetStatus("CURRENT");
            brailee.FirstName = "Brailee";
            brailee.LastName = "Begley";
            brailee.IsPaid = true;
            brailee.Birthday = new DateTime(1995, 11, 14,16,11,11);
            

            Student jesse = new Student("Jesse","Kyle");
            jesse.SetStatus("PAST");
            Console.WriteLine($"Student: {jesse.FirstName} {jesse.LastName}");
            jesse.IsPaid = true;
            jesse.Birthday = new DateTime(1990, 1, 1);

            Student briana = new Student();
            briana.FirstName = "Briana";
            briana.LastName = "Presley";
            briana.IsPaid = true;
            briana.Address = "123 Cherry Street";
            briana.City = "Cincinnati";

            Student titus = new Student();
            titus.FirstName = "Titus";
            titus.LastName = "Moore";
            titus.IsPaid = false;
            titus.Phone = "5135555555";
            titus.Birthday = new DateTime(1999, 04, 27)
            titus.SetCreditScore(9000);
            titus.SetCreditScore(750);
            titus.SetCreditScore(350);
            Console.WriteLine($"Titus's credit score is: {titus.CreditScore}");


            Console.WriteLine($"Brailee's Bootcamp is {brailee.Bootcamp}");

            Console.WriteLine($"Jesse's Bootcamp is {jesse.Bootcamp}");

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
       public int CreditScore { get; private set; }


        public void SetCreditScore(int CreditScore) {
            if (CreditScore >= 400 && CreditScore <= 900) {
                this.CreditScore = CreditScore;}
            else
            { Console.WriteLine("Credit Score must be between 400 and 900.");
            }
        }

        public void SetStatus(string status)
        {
            if ((status == "CURRENT")
                ||(status == "PAST") 
                || (status=="FUTURE")) {
                this.Status = status;
            } else {
                Console.WriteLine("Status must be CURRENT, PAST, or FUTURE.");
            }
           
        }

        public Student(string FirstName, String LastName)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Bootcamp = "Java";
        }
        public Student() {
            this.Bootcamp = ".Net";
        }
    }
            }

