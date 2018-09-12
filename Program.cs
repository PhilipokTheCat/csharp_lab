﻿using System;
using System.Collections.Generic;

namespace csharp_lab
{
    enum JobTitle {
        Twitch_Streamer,
        Perfomance_Artist,
        Default
    }
    class Person {
        protected string firstName;
        protected string lastName;
        protected System.DateTime birthDate;
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
        public int salary { get; set; }
        public System.DateTime deadline { get; set; }
        public Project(string name, int salary, System.DateTime deadline) {
            this.name = name;
            this.salary = salary;
            this.deadline = deadline;
        }
        public Project() {
            this.name = "Default name";
            this.salary = 0;
            Random rand = new Random();
            this.deadline = new DateTime(rand.Next(2018, 2025), rand.Next(1, 13), rand.Next(1, 29));
        }
        public override string ToString() {
            return $"Project {name} with salary of ${salary} and deadline of {deadline.Day}-{deadline.Month}-{deadline.Year}";
        }
    }

    class Employee {
        private Person person;
        private JobTitle jobTitle;
        private int projectId;
        private List<Project> pastProjects = new List<Project>();
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
        public List<Project> PastProjects {
            get {
                return pastProjects;
            }
            set {
                pastProjects = value;
            }
        }
        public double AverageSalary {
            get{
                double summarySalary = 0;
                int projectsCount = this.pastProjects.Count;
                foreach (Project item in this.pastProjects)
                {
                    summarySalary += item.salary;
                }
                return projectsCount != 0 ? (summarySalary / projectsCount) : 0;
            }
        }
        public bool this[JobTitle jobTitle] {
            get {
                return this.jobTitle == jobTitle;
            }
        }
        public void AddProjects(List<Project> projects) {
            foreach(Project project in projects){
                this.pastProjects.Add(project);
            }
        }
        public override string ToString() {
            string pastProjectsList = "";
            foreach (Project project in this.pastProjects){
                pastProjectsList += $"\n{project}";
            }
            return $"{this.person}\nJob title: {this.jobTitle}\nCurrent projectID: {this.projectId}\nPast projects:{pastProjectsList}";
        }
        public virtual string ToShortString() {
            return $"{this.person}\nJob title: {this.jobTitle}\nCurrent projectID: {this.projectId}\nAverage salary: ${this.AverageSalary}";
        }
    }
    // class Program
    // {
    //     static void Main(string[] args)
    //     {
    //         Employee employee = new Employee(new Person("Billy", "Herrington", new DateTime(1969, 07, 14)), JobTitle.Perfomance_Artist, 69);
    //         Console.WriteLine(employee.ToShortString());
    //         Console.WriteLine($"{JobTitle.Default} {JobTitle.Twitch_Streamer} {JobTitle.Perfomance_Artist}");
    //         employee.Person = new Person("Sebastian", "Fors", new DateTime(1990, 12, 16));
    //         employee.ProjectId = 77777;
    //         employee.JobTitle = JobTitle.Twitch_Streamer;
    //         List<Project> projects = new List<Project>{new Project("TW-STR", 5000, new DateTime(2020, 12, 31)), new Project("GOOG-YT", 3000, new DateTime(2018, 12, 31))};
    //         employee.AddProjects(projects);
    //         Console.WriteLine(employee);
    //     }
    // }
}

namespace csharp_lab2
{
    interface IDateAndCopy {
        object DeepCopy();
        DateTime Date{ get; set; }
    }
    enum JobTitle {
        Twitch_Streamer,
        Perfomance_Artist,
        Default
    }
    class Person : IDateAndCopy {
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

        public DateTime Date { get; set; }
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
        public override bool Equals(object obj) {
            return this.GetHashCode() == obj.GetHashCode();
        }
        public override int GetHashCode() {
            var hashCode = 352033288;
            hashCode = hashCode * -1521134295 + this.firstName.GetHashCode();
            hashCode = hashCode * -1521134295 + this.lastName.GetHashCode();
            hashCode = hashCode * -1521134295 + this.birthDate.GetHashCode();
            return hashCode;
        }
        public virtual object DeepCopy() {
            return new Person(this.firstName, this.lastName, this.birthDate);
        }
    }

    class Project : IDateAndCopy {
        public string name { get; set; }
        public int salary { get; set; }
        public System.DateTime deadline { get; set; }
        public Project(string name, int salary, System.DateTime deadline) {
            this.name = name;
            this.salary = salary;
            this.deadline = deadline;
        }
        public Project() {
            this.name = "Default name";
            this.salary = 0;
            Random rand = new Random();
            this.deadline = new DateTime(rand.Next(2018, 2025), rand.Next(1, 13), rand.Next(1, 29));
        }
        public DateTime Date { get; set;}
        public override string ToString() {
            return $"Project {name} with salary of ${salary} and deadline of {deadline.Day}-{deadline.Month}-{deadline.Year}";
        }
        public override bool Equals(object obj) {
            return this.GetHashCode() == obj.GetHashCode();
        }
        public override int GetHashCode() {
            var hashCode = 185739981;
            hashCode = hashCode * -1968112315 + this.name.GetHashCode();
            hashCode = hashCode * -1968112315 + this.salary.GetHashCode();
            hashCode = hashCode * -1968112315 + this.deadline.GetHashCode();
            return hashCode;
        }
        public virtual object DeepCopy() {
            return new Project(this.name, this.salary, this.deadline);
        }
    }

    class Employee : Person, IDateAndCopy {
        private Person person;
        private JobTitle jobTitle;
        private int projectId;
        private List<Project> pastProjects = new List<Project>();
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
        public DateTime Date {
            get; set;
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
        public List<Project> PastProjects {
            get {
                return pastProjects;
            }
            set {
                pastProjects = value;
            }
        }
        public double AverageSalary {
            get{
                double summarySalary = 0;
                int projectsCount = this.pastProjects.Count;
                foreach (Project item in this.pastProjects)
                {
                    summarySalary += item.salary;
                }
                return projectsCount != 0 ? (summarySalary / projectsCount) : 0;
            }
        }
        public bool this[JobTitle jobTitle] {
            get {
                return this.jobTitle == jobTitle;
            }
        }
        public void AddProjects(List<Project> projects) {
            foreach(Project project in projects){
                this.pastProjects.Add(project);
            }
        }
        public override string ToString() {
            string pastProjectsList = "";
            foreach (Project project in this.pastProjects){
                pastProjectsList += $"\n{project}";
            }
            return $"{this.person}\nJob title: {this.jobTitle}\nCurrent projectID: {this.projectId}\nPast projects:{pastProjectsList}";
        }
        public virtual string ToShortString() {
            return $"{this.person}\nJob title: {this.jobTitle}\nCurrent projectID: {this.projectId}\nAverage salary: ${this.AverageSalary}";
        }
        public override bool Equals(object obj) {
            return this.GetHashCode() == obj.GetHashCode();
        }
        public override int GetHashCode() {
            var hashCode = 295814451;
            hashCode = hashCode * -1041235621 + this.jobTitle.GetHashCode();
            hashCode = hashCode * -1041235621 + this.pastProjects.GetHashCode();
            hashCode = hashCode * -1041235621 + this.projectId.GetHashCode();
            return hashCode;
        }
        public virtual object DeepCopy() {
            return new Employee(this.person.DeepCopy(), this.jobTitle, this.projectId);
        }
    }
    class Task {
        public string name;
        public bool isDone;
        public Task(string name, bool isDone) {
            this.name = name;
            this.isDone = isDone;
        }
        public Task() {
            this.name = "Default name";
            this.isDone = false;
        }
        public override string ToString() {
            return $"Task name: {this.name};\nTask state: {(this.isDone ? "done" : "undone")}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee(new Person("Billy", "Herrington", new DateTime(1969, 07, 14)), JobTitle.Perfomance_Artist, 69);
            Console.WriteLine(employee.ToShortString());
            Console.WriteLine($"{JobTitle.Default} {JobTitle.Twitch_Streamer} {JobTitle.Perfomance_Artist}");
            employee.Person = new Person("Sebastian", "Fors", new DateTime(1990, 12, 16));
            employee.ProjectId = 77777;
            employee.JobTitle = JobTitle.Twitch_Streamer;
            List<Project> projects = new List<Project>{new Project("TW-STR", 5000, new DateTime(2020, 12, 31)), new Project("GOOG-YT", 3000, new DateTime(2018, 12, 31))};
            employee.AddProjects(projects);
            Console.WriteLine(employee);
        }
    }
}