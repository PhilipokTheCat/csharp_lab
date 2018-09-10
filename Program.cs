using System;

namespace csharp_lab
{
    enum JobTitle {
        Developer,
        DevOps,
        ProjectManager,
        Default
    }
    class Person {
        private string firstName;
        private string lastName;
        private System.DateTime birthDate;
        public Person(string firstName, string lastName, System.DateTime birthDate) {
            this.firstName = firstName;
            this.lastName = lastName;
            this.birthDate = birthDate;
        }
        public Person() {
            this.firstName = "David";
            this.lastName = "Connor";
            Random rand = new Random();
            this.birthDate = new System.DateTime(rand.Next(1950, 2001), rand.Next(1, 13), rand.Next(1, 29));
        }
        public string FirstName {
            get {
                return firstName;
            }
            set {
                firstName = value;    
            }
        }
        public string LastName {
            get {
                return lastName;
            }
            set {
                lastName = value;    
            }
        }
        public System.DateTime BirthDate {
            get {
                return birthDate;
            }
            set {
                birthDate = value;    
            }
        }
        public int BirthYear {
            get {
                return birthDate.Year;
            }
            set {
                birthDate = new DateTime(value, birthDate.Month, birthDate.Day);
            }
        }
        public override string ToString() {
            return $"{firstName} {lastName} {birthDate.Day}-{birthDate.Month}-{birthDate.Year}";
        }
        public virtual string ToShortString() {
            return $"{firstName} {lastName}";
        }
    }

    class Project {
        public string name { get; set; }
        public int budget { get; set; }
        public System.DateTime deadline { get; set; }
        public Project(string name, int budget, System.DateTime deadline) {
            this.name = name;
            this.budget = budget;
            this.deadline = deadline;
        }
        public Project() {
            this.name = "Default name";
            this.budget = 0;
            Random rand = new Random();
            this.deadline = new DateTime(rand.Next(2018, 2025), rand.Next(1, 13), rand.Next(1, 29));
        }
        public override string ToString() {
            return $"Project {name} with budget of ${budget} and deadline of {deadline.Day}-{deadline.Month}-{deadline.Year}";
        }
    }

    class Employee {
        private Person person;
        private JobTitle jobTitle;
        private int projectId;
        private Project[] pastProjects;
        public Employee(Person person, JobTitle jobTitle, int projectId) {
            this.person = person;
            this.jobTitle = jobTitle;
            this.projectId = projectId;
        }
        public Employee() {
            this.person = new Person();
            this.jobTitle = JobTitle.Default;
            this.projectId = 0;
        }
        public Person Person {
            get {
                return person;
            }
            set {
                person = value;
            }
        }
        public JobTitle JobTitle {
            get {
                return jobTitle;
            }
            set {
                jobTitle = value;
            }
        }
        public int ProjectId {
            get {
                return projectId;
            }
            set {
                projectId = value;
            }
        }
        public Project[] PastProjects {
            get {
                return PastProjects;
            }
            set {
                PastProjects = value;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
