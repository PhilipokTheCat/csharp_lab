using System;
using System.Collections.Generic;
using System.Collections;

// namespace csharp_lab
// {
//     enum JobTitle {
//         Twitch_Streamer,
//         Perfomance_Artist,
//         Default
//     }
//     class Person {
//         protected string firstName;
//         protected string lastName;
//         protected System.DateTime birthDate;
//         public Person(string firstName, string lastName, System.DateTime birthDate) {
//             this.firstName = firstName;
//             this.lastName = lastName;
//             this.birthDate = birthDate;
//         }
//         public Person() {
//             this.firstName = "David";
//             this.lastName = "Connor";
//             Random rand = new Random();
//             this.birthDate = new System.DateTime(rand.Next(1950, 2001), rand.Next(1, 13), rand.Next(1, 29));
//         }
//         public string FirstName {
//             get {
//                 return firstName;
//             }
//             set {
//                 firstName = value;    
//             }
//         }
//         public string LastName {
//             get {
//                 return lastName;
//             }
//             set {
//                 lastName = value;    
//             }
//         }
//         public System.DateTime BirthDate {
//             get {
//                 return birthDate;
//             }
//             set {
//                 birthDate = value;    
//             }
//         }
//         public int BirthYear {
//             get {
//                 return birthDate.Year;
//             }
//             set {
//                 birthDate = new DateTime(value, birthDate.Month, birthDate.Day);
//             }
//         }
//         public override string ToString() {
//             return $"{firstName} {lastName} {birthDate.Day}-{birthDate.Month}-{birthDate.Year}";
//         }
//         public virtual string ToShortString() {
//             return $"{firstName} {lastName}";
//         }
//     }

//     class Project {
//         public string name { get; set; }
//         public int salary { get; set; }
//         public System.DateTime deadline { get; set; }
//         public Project(string name, int salary, System.DateTime deadline) {
//             this.name = name;
//             this.salary = salary;
//             this.deadline = deadline;
//         }
//         public Project() {
//             this.name = "Default name";
//             this.salary = 0;
//             Random rand = new Random();
//             this.deadline = new DateTime(rand.Next(2018, 2025), rand.Next(1, 13), rand.Next(1, 29));
//         }
//         public override string ToString() {
//             return $"Project {name} with salary of ${salary} and deadline of {deadline.Day}-{deadline.Month}-{deadline.Year}";
//         }
//     }

//     class Employee {
//         private Person person;
//         private JobTitle jobTitle;
//         private int projectId;
//         private List<Project> pastProjects = new List<Project>();
//         public Employee(Person person, JobTitle jobTitle, int projectId) {
//             this.person = person;
//             this.jobTitle = jobTitle;
//             this.projectId = projectId;
//         }
//         public Employee() {
//             this.person = new Person();
//             this.jobTitle = JobTitle.Default;
//             this.projectId = 0;
//         }
//         public Person Person {
//             get {
//                 return person;
//             }
//             set {
//                 person = value;
//             }
//         }
//         public JobTitle JobTitle {
//             get {
//                 return jobTitle;
//             }
//             set {
//                 jobTitle = value;
//             }
//         }
//         public int ProjectId {
//             get {
//                 return projectId;
//             }
//             set {
//                 projectId = value;
//             }
//         }
//         public List<Project> PastProjects {
//             get {
//                 return pastProjects;
//             }
//             set {
//                 pastProjects = value;
//             }
//         }
//         public double AverageSalary {
//             get{
//                 double summarySalary = 0;
//                 int projectsCount = this.pastProjects.Count;
//                 foreach (Project item in this.pastProjects)
//                 {
//                     summarySalary += item.salary;
//                 }
//                 return projectsCount != 0 ? (summarySalary / projectsCount) : 0;
//             }
//         }
//         public bool this[JobTitle jobTitle] {
//             get {
//                 return this.jobTitle == jobTitle;
//             }
//         }
//         public void AddProjects(List<Project> projects) {
//             foreach(Project project in projects){
//                 this.pastProjects.Add(project);
//             }
//         }
//         public override string ToString() {
//             string pastProjectsList = "";
//             foreach (Project project in this.pastProjects){
//                 pastProjectsList += $"\n{project}";
//             }
//             return $"{this.person}\nJob title: {this.jobTitle}\nCurrent projectID: {this.projectId}\nPast projects:{pastProjectsList}";
//         }
//         public virtual string ToShortString() {
//             return $"{this.person}\nJob title: {this.jobTitle}\nCurrent projectID: {this.projectId}\nAverage salary: ${this.AverageSalary}";
//         }
//     }
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Employee employee = new Employee(new Person("Billy", "Herrington", new DateTime(1969, 07, 14)), JobTitle.Perfomance_Artist, 69);
//             Console.WriteLine(employee.ToShortString());
//             Console.WriteLine($"{JobTitle.Default} {JobTitle.Twitch_Streamer} {JobTitle.Perfomance_Artist}");
//             employee.Person = new Person("Sebastian", "Fors", new DateTime(1990, 12, 16));
//             employee.ProjectId = 77777;
//             employee.JobTitle = JobTitle.Twitch_Streamer;
//             List<Project> projects = new List<Project>{new Project("TW-STR", 5000, new DateTime(2020, 12, 31)), new Project("GOOG-YT", 3000, new DateTime(2018, 12, 31))};
//             employee.AddProjects(projects);
//             Console.WriteLine(employee);
//         }
//     }
// }

// namespace csharp_lab2
// {
//     interface IDateAndCopy {
//         DateTime Date{ get; set; }
//     }
//     enum JobTitle {
//         Twitch_Streamer,
//         Perfomance_Artist,
//         Default
//     }
//     class Person : IDateAndCopy {
//         protected string firstName;
//         protected string lastName;
//         protected System.DateTime birthDate;
//         public Person(string firstName, string lastName, System.DateTime birthDate) {
//             this.firstName = firstName;
//             this.lastName = lastName;
//             this.birthDate = birthDate;
//         }
//         public Person() {
//             this.firstName = "David";
//             this.lastName = "Connor";
//             Random rand = new Random();
//             this.birthDate = new System.DateTime(rand.Next(1950, 2001), rand.Next(1, 13), rand.Next(1, 29));
//         }

//         public DateTime Date { get; set; }
//         public string FirstName {
//             get {
//                 return firstName;
//             }
//             set {
//                 firstName = value;    
//             }
//         }
//         public string LastName {
//             get {
//                 return lastName;
//             }
//             set {
//                 lastName = value;    
//             }
//         }
//         public System.DateTime BirthDate {
//             get {
//                 return birthDate;
//             }
//             set {
//                 birthDate = value;    
//             }
//         }
//         public int BirthYear {
//             get {
//                 return birthDate.Year;
//             }
//             set {
//                 birthDate = new DateTime(value, birthDate.Month, birthDate.Day);
//             }
//         }
//         public override string ToString() {
//             return $"{firstName} {lastName} {birthDate.Day}-{birthDate.Month}-{birthDate.Year}";
//         }
//         public virtual string ToShortString() {
//             return $"{firstName} {lastName}";
//         }
//         public static bool operator !=(Person obj1, object obj2) {
//             return !(obj1 == obj2);
//         }
//         public static bool operator ==(Person obj1, object obj2) {
//             return obj1.Equals(obj2);
//         }
//         public override bool Equals(object obj) {
//             return this.GetHashCode() == obj.GetHashCode();
//         }
//         public override int GetHashCode() {
//             var hashCode = 352033288;
//             hashCode = hashCode * -1521134295 + this.firstName.GetHashCode();
//             hashCode = hashCode * -1521134295 + this.lastName.GetHashCode();
//             hashCode = hashCode * -1521134295 + this.birthDate.Year.GetHashCode();
//             hashCode = hashCode * -1521134295 + this.birthDate.Month.GetHashCode();
//             hashCode = hashCode * -1521134295 + this.birthDate.Day.GetHashCode();
//             return hashCode;
//         }
//         public virtual Person DeepCopy() {
//             return new Person(this.firstName, this.lastName, new DateTime(this.birthDate.Year, this.birthDate.Month, this.birthDate.Day));
//         }
//     }

//     class Project : IDateAndCopy {
//         public string name { get; set; }
//         public int salary { get; set; }
//         public System.DateTime deadline { get; set; }
//         public Project(string name, int salary, System.DateTime deadline) {
//             this.name = name;
//             this.salary = salary;
//             this.deadline = deadline;
//         }
//         public Project() {
//             this.name = "Default name";
//             this.salary = 0;
//             Random rand = new Random();
//             this.deadline = new DateTime(rand.Next(2018, 2025), rand.Next(1, 13), rand.Next(1, 29));
//         }
//         public DateTime Date { get; set;}
//         public override string ToString() {
//             return $"Project {name} with salary of ${salary} and deadline of {deadline.Day}-{deadline.Month}-{deadline.Year}";
//         }
//         public override bool Equals(object obj) {
//             return this.GetHashCode() == obj.GetHashCode();
//         }
//         public override int GetHashCode() {
//             var hashCode = 185739981;
//             hashCode = hashCode * -1968112315 + this.name.GetHashCode();
//             hashCode = hashCode * -1968112315 + this.salary.GetHashCode();
//             hashCode = hashCode * -1968112315 + this.deadline.GetHashCode();
//             return hashCode;
//         }
//         public virtual Project DeepCopy() {
//             return new Project(this.name, this.salary, this.deadline);
//         }
//     }

//     class Employee : Person, IDateAndCopy {
//         private JobTitle jobTitle;
//         private int projectId;
//         private Person person;
//         private List<Project> pastProjects = new List<Project>();
//         private List<Project> tasks = new List<Project>();
//         public Employee(Person person, JobTitle jobTitle, int projectId){
//             this.person = person;
//             this.jobTitle = jobTitle;
//             this.projectId = projectId;
//         }
//         public Employee(){
//             this.person = new Person();
//             this.jobTitle = JobTitle.Default;
//             this.projectId = 0;
//         }
//         public Person Person {
//             get {
//                 return person;
//             } 
//             set{
//                 person = value;
//             }
//         }
//         public DateTime Date {
//             get; set;
//         }
//         public JobTitle JobTitle {
//             get {
//                 return jobTitle;
//             }
//             set {
//                 jobTitle = value;
//             }
//         }
//         public int ProjectId {
//             get {
//                 return projectId;
//             }
//             set {
//                 if (value > 599 || value <= 99) throw new Exception("Project ID value should be greater than or equals to 100 and less than 599!");
//                 projectId = value;
//             }
//         }
//         public List<Project> PastProjects {
//             get {
//                 return pastProjects;
//             }
//             set {
//                 pastProjects = value;
//             }
//         }
//         public int bottomLine;
//         public IEnumerable GetIterator(int bottomLine = -1) {
//             this.bottomLine = bottomLine;
//             if (this.bottomLine == -1) {
//                 foreach(Task task in this.tasks) {
//                     yield return task;
//                 }
//                 foreach(Project project in this.pastProjects) {
//                     yield return project;
//                 }
//             }
//             else {
//                 foreach(Project project in this.pastProjects) {
//                     if (project.salary >= bottomLine) {
//                         yield return project;
//                     }
//                 }
//             }
//         }
//         public IEnumerator GetEnumerator(){
//             if (this.bottomLine == -1) {
//                 foreach(Task task in this.tasks) {
//                     yield return task;
//                 }
//                 foreach(Project project in this.pastProjects) {
//                     yield return project;
//                 }
//             }
//             else {
//                 foreach(Project project in this.pastProjects) {
//                     if (project.salary >= bottomLine) {
//                         yield return project;
//                     }
//                 }
//             }
//         }
//         public double AverageSalary {
//             get{
//                 double summarySalary = 0;
//                 int projectsCount = this.pastProjects.Count;
//                 foreach (Project item in this.pastProjects)
//                 {
//                     summarySalary += item.salary;
//                 }
//                 return projectsCount != 0 ? (summarySalary / projectsCount) : 0;
//             }
//         }
//         public bool this[JobTitle jobTitle] {
//             get {
//                 return this.jobTitle == jobTitle;
//             }
//         }
//         public void AddProjects(List<Project> projects) {
//             foreach(Project project in projects){
//                 this.pastProjects.Add(project);
//             }
//         }
//         public void AddTasks(List<Project> tasks) {
//             foreach(Task task in tasks){
//                 this.tasks.Add(task);
//             }
//         }
//         public override string ToString() {
//             string pastProjectsList = "";
//             foreach (Project project in this.pastProjects){
//                 pastProjectsList += $"\n{project}";
//             };
//             string tasksList = "";
//             foreach (Task task in this.tasks) {
//                 tasksList += $"\n{task}";
//             }
//             return $"{this.person}\nJob title: {this.jobTitle}\nCurrent projectID: {this.projectId}\nPast projects:{pastProjectsList}\nTasks:{tasksList}";
//         }
//         public virtual string ToShortString() {
//             return $"{this.person}\nJob title: {this.jobTitle}\nCurrent projectID: {this.projectId}\nAverage salary: ${this.AverageSalary}";
//         }
//         public override bool Equals(object obj) {
//             return this.GetHashCode() == obj.GetHashCode();
//         }
//         public override int GetHashCode() {
//             var hashCode = 295814451;
//             hashCode = hashCode * -1041235621 + this.jobTitle.GetHashCode();
//             hashCode = hashCode * -1041235621 + this.pastProjects.GetHashCode();
//             hashCode = hashCode * -1041235621 + this.projectId.GetHashCode();
//             return hashCode;
//         }
//         public virtual Employee DeepCopy() {
//             Employee newEmployee = new Employee(this.person, this.jobTitle, this.projectId);
//             newEmployee.AddProjects(this.pastProjects);
//             newEmployee.AddTasks(this.tasks);
//             return newEmployee;
//         }
//     }
//     class Task {
//         public string name;
//         public bool isDone;
//         public Task(string name, bool isDone) {
//             this.name = name;
//             this.isDone = isDone;
//         }
//         public Task() {
//             this.name = "Default name";
//             this.isDone = false;
//         }
//         public override string ToString() {
//             return $"Task name: {this.name}; Task state: {(this.isDone ? "done" : "undone")}";
//         }
//     }
//     class Program
//     {
//         static void Main(string[] args)
//         {   // 1
//             Console.WriteLine("\n№1");
//             bool isPersonsSimilar = (new Person("Billy", "Herrington", new DateTime(1969, 07, 14)) == new Person("Billy", "Herrington", new DateTime(1969, 07, 14)));
//             Console.WriteLine($"Both persons are similar: {isPersonsSimilar}");
//             // 2
//             Console.WriteLine("\n№2");
//             Employee employee = new Employee(new Person("Billy", "Herrington", new DateTime(1969, 07, 14)), JobTitle.Perfomance_Artist, 333);
//             List<Project> projects = new List<Project>();
//             projects.Add(new Project("TW-STR", 5000, new DateTime(2020, 12, 31)));
//             projects.Add(new Project("GOOG-YT", 3000, new DateTime(2018, 12, 31)));
//             employee.AddProjects(projects);
//             List<Project> tasks = new List<Project>();
//             tasks.Add(new Task("Dance", false));
//             tasks.Add(new Task("Become the boss of this gym", true));
//             employee.AddTasks(tasks);
//             Console.WriteLine(employee);
//             // 3
//             Console.WriteLine("\n№3");
//             Console.WriteLine(employee.Person);
//             // 4
//             Console.WriteLine("\n№4");
//             Employee copiedEmployee = employee.DeepCopy();
//             copiedEmployee.Person = new Person("Sebastian", "Fors", new DateTime(1990, 12, 16));
//             copiedEmployee.ProjectId = 400;
//             copiedEmployee.JobTitle = JobTitle.Twitch_Streamer;
//             Console.WriteLine($"Copied:\n{copiedEmployee}");
//             Console.WriteLine($"\n\nInitial:\n{employee}");
//             // 5
//             Console.WriteLine("\n№5");
//             try {
//                 employee.ProjectId = 77777;
//             } catch(Exception e) {
//                 Console.WriteLine($"{e}");
//             }
//             // 6
//             Console.WriteLine("\n№6");
//             foreach(object obj in employee.GetIterator()) {
//                 Console.WriteLine(obj);
//             }
//             // 7
//             Console.WriteLine("\n№7");
//             foreach(object obj in employee.GetIterator(4000)) {
//                 Console.WriteLine(obj);
//             }
//         }
//     }
// }

// namespace csharp_lab3
// {
//     interface IDateAndCopy {
//         DateTime Date{ get; set; }
//     }
//     enum JobTitle {
//         Twitch_Streamer,
//         Perfomance_Artist,
//         Default
//     }
//     class Person : IDateAndCopy, IComparable<Person>, IComparer<Person> {
//         protected string firstName;
//         protected string lastName;
//         protected System.DateTime birthDate;
//         public Person(string firstName, string lastName, System.DateTime birthDate) {
//             this.firstName = firstName;
//             this.lastName = lastName;
//             this.birthDate = birthDate;
//         }
//         public Person() {
//             this.firstName = "David";
//             this.lastName = "Connor";
//             Random rand = new Random();
//             this.birthDate = new System.DateTime(rand.Next(1950, 2001), rand.Next(1, 13), rand.Next(1, 29));
//         }

//         public DateTime Date { get; set; }
//         public string FirstName {
//             get {
//                 return firstName;
//             }
//             set {
//                 firstName = value;    
//             }
//         }
//         public string LastName {
//             get {
//                 return lastName;
//             }
//             set {
//                 lastName = value;    
//             }
//         }
//         public System.DateTime BirthDate {
//             get {
//                 return birthDate;
//             }
//             set {
//                 birthDate = value;    
//             }
//         }
//         public int BirthYear {
//             get {
//                 return birthDate.Year;
//             }
//             set {
//                 birthDate = new DateTime(value, birthDate.Month, birthDate.Day);
//             }
//         }
//         public int CompareTo(Person obj) {
//             if (obj == null) return 1;
//             return this.lastName.CompareTo(obj.lastName);
//         }
//         public static bool operator > (Person operand1, Person operand2) {
//             return operand1.CompareTo(operand2) == 1;
//         } 
//         public static bool operator < (Person operand1, Person operand2) {
//             return operand1.CompareTo(operand2) == -1;
//         } 
//         public static bool operator >= (Person operand1, Person operand2) {
//             return operand1.CompareTo(operand2) >= 0;
//         } 
//         public static bool operator <= (Person operand1, Person operand2) {
//             return operand1.CompareTo(operand2) <= 0;
//         } 
//         public int Compare(Person operand1, Person operand2) {
//             return operand1.birthDate.CompareTo(operand2.birthDate);
//         }
//         public override string ToString() {
//             return $"{firstName} {lastName} {birthDate.Day}-{birthDate.Month}-{birthDate.Year}";
//         }
//         public virtual string ToShortString() {
//             return $"{firstName} {lastName}";
//         }
//         public static bool operator !=(Person obj1, Person obj2) {
//             return !(obj1 == obj2);
//         }
//         public static bool operator ==(Person obj1, Person obj2) {
//             return obj1.Equals(obj2);
//         }
//         public override int GetHashCode() {
//             var hashCode = 352033288;
//             hashCode = hashCode * -1521134295 + this.firstName.GetHashCode();
//             hashCode = hashCode * -1521134295 + this.lastName.GetHashCode();
//             hashCode = hashCode * -1521134295 + this.birthDate.Year.GetHashCode();
//             hashCode = hashCode * -1521134295 + this.birthDate.Month.GetHashCode();
//             hashCode = hashCode * -1521134295 + this.birthDate.Day.GetHashCode();
//             return hashCode;
//         }
//         public virtual Person DeepCopy() {
//             return new Person(this.firstName, this.lastName, new DateTime(this.birthDate.Year, this.birthDate.Month, this.birthDate.Day));
//         }
//     }

//     class Project : IDateAndCopy {
//         public string name { get; set; }
//         public int salary { get; set; }
//         public System.DateTime deadline { get; set; }
//         public Project(string name, int salary, System.DateTime deadline) {
//             this.name = name;
//             this.salary = salary;
//             this.deadline = deadline;
//         }
//         public Project() {
//             this.name = "Default name";
//             this.salary = 0;
//             Random rand = new Random();
//             this.deadline = new DateTime(rand.Next(2018, 2025), rand.Next(1, 13), rand.Next(1, 29));
//         }
//         public DateTime Date { get; set;}
//         public override string ToString() {
//             return $"Project {name} with salary of ${salary} and deadline of {deadline.Day}-{deadline.Month}-{deadline.Year}";
//         }
//         public override bool Equals(object obj) {
//             return this.GetHashCode() == obj.GetHashCode();
//         }
//         public override int GetHashCode() {
//             var hashCode = 185739981;
//             hashCode = hashCode * -1968112315 + this.name.GetHashCode();
//             hashCode = hashCode * -1968112315 + this.salary.GetHashCode();
//             hashCode = hashCode * -1968112315 + this.deadline.GetHashCode();
//             return hashCode;
//         }
//         public virtual Project DeepCopy() {
//             return new Project(this.name, this.salary, this.deadline);
//         }
//     }

//     class Employee : Person, IDateAndCopy {
//         private JobTitle jobTitle;
//         private int projectId;
//         private Person person;
//         private List<Project> pastProjects = new List<Project>();
//         private List<Task> tasks = new List<Task>();
//         public Employee(Person person, JobTitle jobTitle, int projectId){
//             this.person = person;
//             this.jobTitle = jobTitle;
//             this.projectId = projectId;
//         }
//         public Employee(){
//             this.person = new Person();
//             this.jobTitle = JobTitle.Default;
//             this.projectId = 0;
//         }
//         public Person Person {
//             get {
//                 return person;
//             } 
//             set{
//                 person = value;
//             }
//         }
//         public DateTime Date {
//             get; set;
//         }
//         public JobTitle JobTitle {
//             get {
//                 return jobTitle;
//             }
//             set {
//                 jobTitle = value;
//             }
//         }
//         public int ProjectId {
//             get {
//                 return projectId;
//             }
//             set {
//                 if (value > 599 || value <= 99) throw new Exception("Project ID value should be greater than or equals to 100 and less than 599!");
//                 projectId = value;
//             }
//         }
//         public List<Project> PastProjects {
//             get {
//                 return pastProjects;
//             }
//             set {
//                 pastProjects = value;
//             }
//         }
//         public List<Task> Tasks {
//             get {
//                 return tasks;
//             }
//             set {
//                 tasks = value;
//             }
//         }
//         public int bottomLine;
//         public IEnumerable GetIterator(int bottomLine = -1) {
//             this.bottomLine = bottomLine;
//             if (this.bottomLine == -1) {
//                 foreach(Task task in this.tasks) {
//                     yield return task;
//                 }
//                 foreach(Project project in this.pastProjects) {
//                     yield return project;
//                 }
//             }
//             else {
//                 foreach(Project project in this.pastProjects) {
//                     if (project.salary >= bottomLine) {
//                         yield return project;
//                     }
//                 }
//             }
//         }
//         public IEnumerator GetEnumerator(){
//             if (this.bottomLine == -1) {
//                 foreach(Task task in this.tasks) {
//                     yield return task;
//                 }
//                 foreach(Project project in this.pastProjects) {
//                     yield return project;
//                 }
//             }
//             else {
//                 foreach(Project project in this.pastProjects) {
//                     if (project.salary >= bottomLine) {
//                         yield return project;
//                     }
//                 }
//             }
//         }
//         public double AverageSalary {
//             get{
//                 double summarySalary = 0;
//                 int projectsCount = this.pastProjects.Count;
//                 foreach (Project item in this.pastProjects)
//                 {
//                     summarySalary += item.salary;
//                 }
//                 return projectsCount != 0 ? (summarySalary / projectsCount) : 0;
//             }
//         }
//         public bool this[JobTitle jobTitle] {
//             get {
//                 return this.jobTitle == jobTitle;
//             }
//         }
//         public void AddProjects(List<Project> projects) {
//             foreach(Project project in projects){
//                 this.pastProjects.Add(project);
//             }
//         }
//         public void AddTasks(List<Task> tasks) {
//             foreach(Task task in tasks){
//                 this.tasks.Add(task);
//             }
//         }
//         public override string ToString() {
//             string pastProjectsList = "";
//             foreach (Project project in this.pastProjects){
//                 pastProjectsList += $"\n{project}";
//             };
//             string tasksList = "";
//             foreach (Task task in this.tasks) {
//                 tasksList += $"\n{task}";
//             }
//             return $"{this.person}\nJob title: {this.jobTitle}\nCurrent projectID: {this.projectId}\nAverage salary: ${this.AverageSalary}\nPast projects:{pastProjectsList}\nTasks:{tasksList}";
//         }
//         public virtual string ToShortString() {
//             return $"{this.person}\nJob title: {this.jobTitle}\nCurrent projectID: {this.projectId}\nAverage salary: ${this.AverageSalary}";
//         }
//         public override bool Equals(object obj) {
//             return this.GetHashCode() == obj.GetHashCode();
//         }
//         public override int GetHashCode() {
//             var hashCode = 295814451;
//             hashCode = hashCode * -1041235621 + this.jobTitle.GetHashCode();
//             hashCode = hashCode * -1041235621 + this.pastProjects.GetHashCode();
//             hashCode = hashCode * -1041235621 + this.projectId.GetHashCode();
//             return hashCode;
//         }
//         public virtual Employee DeepCopy() {
//             Employee newEmployee = new Employee(this.person, this.jobTitle, this.projectId);
//             newEmployee.AddProjects(this.pastProjects);
//             newEmployee.AddTasks(this.tasks);
//             return newEmployee;
//         }
//     }

//     class EmployeeComparer : IComparer<Employee> {
//         public int Compare(Employee emp1, Employee emp2) {
//             return emp1.AverageSalary.CompareTo(emp2.AverageSalary);
//         }
//     }
//     class Task {
//         public string name;
//         public bool isDone;
//         public Task(string name, bool isDone) {
//             this.name = name;
//             this.isDone = isDone;
//         }
//         public Task() {
//             this.name = "Default name";
//             this.isDone = false;
//         }
//         public override string ToString() {
//             return $"Task name: {this.name}; Task state: {(this.isDone ? "done" : "undone")}";
//         }
//     }

//     class EmployeeCollection {
//         private List<Employee> Employees = new List<Employee>();
//         public void AddDefaults() {
//             Employees.Add(new Employee(new Person("DefaultName", "DefaultSurname", new DateTime(2000, 12, 31)), JobTitle.Default, 100));
//         }
//         public void AddEmployees(List<Employee> employees) {
//             foreach(Employee employee in employees) {
//                 Employees.Add(employee);
//             }
//         }
//         public void Sort(string type) {
//             for(int i = 0; i < Employees.Count; i++) {
//                 for(int j = 0; j < Employees.Count-1; j++) {
//                     switch (type) {
//                         case "lastname": 
//                             if (this.SortByLastnames(Employees[j], Employees[j+1])) {
//                                 Employee temp = Employees[j];
//                                 Employees[j] = Employees[j+1];
//                                 Employees[j+1] = temp;
//                             };
//                             break;
//                         case "birthdate":
//                             if (this.SortByBirthdates(Employees[j], Employees[j+1])) {
//                                 Employee temp = Employees[j];
//                                 Employees[j] = Employees[j+1];
//                                 Employees[j+1] = temp;
//                             };
//                             break;
//                         case "averageSalary": 
//                             if (this.SortByAverageSalary(Employees[j], Employees[j+1])) {
//                                 Employee temp = Employees[j];
//                                 Employees[j] = Employees[j+1];
//                                 Employees[j+1] = temp;
//                             };
//                             break;
//                     }
//                 }
//             }
//         }
//         protected bool SortByLastnames(Employee emp1, Employee emp2) {
//             return emp1.Person.CompareTo(emp2.Person) == 1 ? true : false;
//         }
//         protected bool SortByBirthdates(Employee emp1, Employee emp2) {
//             return emp1.Person.Compare(emp1.Person, emp2.Person) == 1 ? true : false;
//         }
//         protected bool SortByAverageSalary(Employee emp1, Employee emp2) {
//             EmployeeComparer comparer = new EmployeeComparer();
//             return comparer.Compare(emp1, emp2) == 1 ? true : false;
//         }
//         public double GetMaxAverageSalary {
//             get {
//                 double maxSalary = -1;
//                 foreach(Employee employee in Employees) {
//                     if (employee.AverageSalary > maxSalary) maxSalary = employee.AverageSalary;
//                 }
//                 return maxSalary > -1 ? maxSalary : 0;
//             }
//         }
//         public IEnumerable<Employee> GetPerfomanceArtists {
//             get {
//                 List<Employee> list = new List<Employee>();
//                 foreach(Employee employee in Employees) {
//                     if (employee.JobTitle == JobTitle.Perfomance_Artist) {
//                         list.Add(employee);
//                     }
//                 };
//                 return list;
//             }
//         }
//         public List<Employee> GetAverageSalaryGroup(double value) {
//             List<Employee> list = new List<Employee>();
//             foreach(Employee employee in Employees) {
//                 if (employee.AverageSalary == value) list.Add(employee);
//             }
//             return list;
//         }
//         public override string ToString() {
//             string str = "";
//             foreach(Employee employee in Employees) {
//                 str += $"{employee}\n";
//             }
//             return str;
//         }
//         public virtual string ToShortString() {
//             string str = "";
//             foreach(Employee employee in Employees) {
//                 str += $"{employee.ToShortString()}\nCount of past projects: {employee.PastProjects.Count}\nCount of tasks: {employee.Tasks.Count}\n";
//             }
//             return str;
//         }
//     }
//     class TestCollections<Person, Employee> {
//         private List<Person> persons;
//         private List<string> strings;
//         private Dictionary<Person, Employee> EmployeesByPerson;
//         private Dictionary<string, Employee> EmployeesByString;
//         public TestCollections(int length) {

//         }
//     }
//     class Program
//     {
//         static void Main(string[] args)
//         {   // 1
//             Console.WriteLine("\n№1");
//             EmployeeCollection collection = new EmployeeCollection();
//             List<Employee> employees = new List<Employee>();
//             employees.Add(new Employee(new Person("Billy", "Herrington", new DateTime(1969, 07, 14)), JobTitle.Perfomance_Artist, 333));
//             employees.Add(new Employee(new Person("Sebastian", "Fors", new DateTime(1990, 12, 16)), JobTitle.Twitch_Streamer, 400));
//             employees.Add(new Employee(new Person("Vitaly", "Gromyako", new DateTime(1991, 12, 10)), JobTitle.Twitch_Streamer, 228));
//             collection.AddEmployees(employees);
//             Console.WriteLine(collection);
//             // 2
//             Console.WriteLine("\n№2");
//             collection.Sort("lastname");
//             Console.WriteLine(collection + "\n");
//             collection.Sort("birthdate");
//             Console.WriteLine(collection + "\n");
//             collection.Sort("averageSalary");
//             Console.WriteLine(collection + "\n");
//             // 3
//             Console.WriteLine("\n№3");
//             Console.WriteLine($"Max average salary: ${collection.GetMaxAverageSalary}");
//             string perfomanceArtistsStr = "";
//             foreach(Employee employee in collection.GetPerfomanceArtists) {
//                 perfomanceArtistsStr += employee.ToShortString() + "\n";
//             }
//             Console.WriteLine($"Perfomance artists: \n{perfomanceArtistsStr}");
//             string averageSalaryStr = "";
//             foreach(Employee employee in collection.GetAverageSalaryGroup(4000)) {
//                 averageSalaryStr += employee.ToShortString() + "\n";
//             }
//             if (averageSalaryStr == "") averageSalaryStr = "empty";
//             Console.WriteLine($"Average salary group: {averageSalaryStr}");
//         }
//     }
// }

namespace csharp_lab4
{
    interface IDateAndCopy {
        DateTime Date{ get; set; }
    }
    enum JobTitle {
        Twitch_Streamer,
        Perfomance_Artist,
        Default
    }
    class Person : IDateAndCopy, IComparable<Person>, IComparer<Person> {
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
        public int CompareTo(Person obj) {
            if (obj == null) return 1;
            return this.lastName.CompareTo(obj.lastName);
        }
        public static bool operator > (Person operand1, Person operand2) {
            return operand1.CompareTo(operand2) == 1;
        } 
        public static bool operator < (Person operand1, Person operand2) {
            return operand1.CompareTo(operand2) == -1;
        } 
        public static bool operator >= (Person operand1, Person operand2) {
            return operand1.CompareTo(operand2) >= 0;
        } 
        public static bool operator <= (Person operand1, Person operand2) {
            return operand1.CompareTo(operand2) <= 0;
        } 
        public int Compare(Person operand1, Person operand2) {
            return operand1.birthDate.CompareTo(operand2.birthDate);
        }
        public override string ToString() {
            return $"{firstName} {lastName} {birthDate.Day}-{birthDate.Month}-{birthDate.Year}";
        }
        public virtual string ToShortString() {
            return $"{firstName} {lastName}";
        }
        public static bool operator !=(Person obj1, Person obj2) {
            return !(obj1 == obj2);
        }
        public static bool operator ==(Person obj1, Person obj2) {
            return obj1.Equals(obj2);
        }
        public override int GetHashCode() {
            var hashCode = 352033288;
            hashCode = hashCode * -1521134295 + this.firstName.GetHashCode();
            hashCode = hashCode * -1521134295 + this.lastName.GetHashCode();
            hashCode = hashCode * -1521134295 + this.birthDate.Year.GetHashCode();
            hashCode = hashCode * -1521134295 + this.birthDate.Month.GetHashCode();
            hashCode = hashCode * -1521134295 + this.birthDate.Day.GetHashCode();
            return hashCode;
        }
        public virtual Person DeepCopy() {
            return new Person(this.firstName, this.lastName, new DateTime(this.birthDate.Year, this.birthDate.Month, this.birthDate.Day));
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
        public virtual Project DeepCopy() {
            return new Project(this.name, this.salary, this.deadline);
        }
    }

    class Employee : Person, IDateAndCopy {
        private JobTitle jobTitle;
        private int projectId;
        private Person person;
        private List<Project> pastProjects = new List<Project>();
        private List<Task> tasks = new List<Task>();
        public Employee(Person person, JobTitle jobTitle, int projectId){
            this.person = person;
            this.jobTitle = jobTitle;
            this.projectId = projectId;
        }
        public Employee(){
            this.person = new Person();
            this.jobTitle = JobTitle.Default;
            this.projectId = 0;
        }
        public Person Person {
            get {
                return person;
            } 
            set{
                person = value;
            }
        }
        public DateTime Date {
            get; set;
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
                if (value > 599 || value <= 99) throw new Exception("Project ID value should be greater than or equals to 100 and less than 599!");
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
        public List<Task> Tasks {
            get {
                return tasks;
            }
            set {
                tasks = value;
            }
        }
        public int bottomLine;
        public IEnumerable GetIterator(int bottomLine = -1) {
            this.bottomLine = bottomLine;
            if (this.bottomLine == -1) {
                foreach(Task task in this.tasks) {
                    yield return task;
                }
                foreach(Project project in this.pastProjects) {
                    yield return project;
                }
            }
            else {
                foreach(Project project in this.pastProjects) {
                    if (project.salary >= bottomLine) {
                        yield return project;
                    }
                }
            }
        }
        public IEnumerator GetEnumerator(){
            if (this.bottomLine == -1) {
                foreach(Task task in this.tasks) {
                    yield return task;
                }
                foreach(Project project in this.pastProjects) {
                    yield return project;
                }
            }
            else {
                foreach(Project project in this.pastProjects) {
                    if (project.salary >= bottomLine) {
                        yield return project;
                    }
                }
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
        public void AddTasks(List<Task> tasks) {
            foreach(Task task in tasks){
                this.tasks.Add(task);
            }
        }
        public override string ToString() {
            string pastProjectsList = "";
            foreach (Project project in this.pastProjects){
                pastProjectsList += $"\n{project}";
            };
            string tasksList = "";
            foreach (Task task in this.tasks) {
                tasksList += $"\n{task}";
            }
            return $"{this.person}\nJob title: {this.jobTitle}\nCurrent projectID: {this.projectId}\nAverage salary: ${this.AverageSalary}\nPast projects:{pastProjectsList}\nTasks:{tasksList}";
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
        public virtual Employee DeepCopy() {
            Employee newEmployee = new Employee(this.person, this.jobTitle, this.projectId);
            newEmployee.AddProjects(this.pastProjects);
            newEmployee.AddTasks(this.tasks);
            return newEmployee;
        }
    }

    class EmployeeComparer : IComparer<Employee> {
        public int Compare(Employee emp1, Employee emp2) {
            return emp1.AverageSalary.CompareTo(emp2.AverageSalary);
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
            return $"Task name: {this.name}; Task state: {(this.isDone ? "done" : "undone")}";
        }
    }

    class EmployeeCollection {
        public delegate void EmployeeListHandler(object source, EmployeeListHandlerEventArgs args);
        public event EmployeeListHandler EmployeesCountChanged;
        public event EmployeeListHandler EmployeeReferenceChanged;
        private List<Employee> Employees = new List<Employee>();
        public string collectionName { get; set; }
        public EmployeeCollection(string name) {
            this.collectionName = name;
        }
        public void AddDefaults() {
            Employee emp = new Employee(new Person("DefaultName", "DefaultSurname", new DateTime(2000, 12, 31)), JobTitle.Default, 100);
            Employees.Add(emp);
            EmployeesCountChanged(this, new EmployeeListHandlerEventArgs(collectionName, "Added default employee", emp));
        }
        public void AddEmployee(Employee employee) {
            Employees.Add(employee);
            EmployeesCountChanged(this, new EmployeeListHandlerEventArgs(collectionName, "Added new employee", employee));
        }
        public void Sort(string type) {
            for(int i = 0; i < Employees.Count; i++) {
                for(int j = 0; j < Employees.Count-1; j++) {
                    switch (type) {
                        case "lastname": 
                            if (this.SortByLastnames(Employees[j], Employees[j+1])) {
                                Employee temp = Employees[j];
                                Employees[j] = Employees[j+1];
                                Employees[j+1] = temp;
                            };
                            break;
                        case "birthdate":
                            if (this.SortByBirthdates(Employees[j], Employees[j+1])) {
                                Employee temp = Employees[j];
                                Employees[j] = Employees[j+1];
                                Employees[j+1] = temp;
                            };
                            break;
                        case "averageSalary": 
                            if (this.SortByAverageSalary(Employees[j], Employees[j+1])) {
                                Employee temp = Employees[j];
                                Employees[j] = Employees[j+1];
                                Employees[j+1] = temp;
                            };
                            break;
                    }
                }
            }
        }
        protected bool SortByLastnames(Employee emp1, Employee emp2) {
            return emp1.Person.CompareTo(emp2.Person) == 1 ? true : false;
        }
        protected bool SortByBirthdates(Employee emp1, Employee emp2) {
            return emp1.Person.Compare(emp1.Person, emp2.Person) == 1 ? true : false;
        }
        protected bool SortByAverageSalary(Employee emp1, Employee emp2) {
            EmployeeComparer comparer = new EmployeeComparer();
            return comparer.Compare(emp1, emp2) == 1 ? true : false;
        }
        public double GetMaxAverageSalary {
            get {
                double maxSalary = -1;
                foreach(Employee employee in Employees) {
                    if (employee.AverageSalary > maxSalary) maxSalary = employee.AverageSalary;
                }
                return maxSalary > -1 ? maxSalary : 0;
            }
        }
        public IEnumerable<Employee> GetPerfomanceArtists {
            get {
                List<Employee> list = new List<Employee>();
                foreach(Employee employee in Employees) {
                    if (employee.JobTitle == JobTitle.Perfomance_Artist) {
                        list.Add(employee);
                    }
                };
                return list;
            }
        }
        public List<Employee> GetAverageSalaryGroup(double value) {
            List<Employee> list = new List<Employee>();
            foreach(Employee employee in Employees) {
                if (employee.AverageSalary == value) list.Add(employee);
            }
            return list;
        }
        public bool Remove(int index) {
            if (index < 0 || index >= Employees.Count) return false;
            Employee emp = Employees[index];
            Employees.RemoveAt(index);
            EmployeesCountChanged(this, new EmployeeListHandlerEventArgs(collectionName, "Removed an employee", emp));
            return true;
        }
        public Employee this[int i] {
            get {
                return Employees[i];
            }
            set {
                Employees[i] = value;
                EmployeeReferenceChanged(this, new EmployeeListHandlerEventArgs(collectionName, "Changed an employee", value));
            }
        }
        public override string ToString() {
            string str = "";
            foreach(Employee employee in Employees) {
                str += $"{employee}\n";
            }
            return str;
        }
        public virtual string ToShortString() {
            string str = "";
            foreach(Employee employee in Employees) {
                str += $"{employee.ToShortString()}\nCount of past projects: {employee.PastProjects.Count}\nCount of tasks: {employee.Tasks.Count}\n";
            }
            return str;
        }
    }
    class TestCollections<Person, Employee> {
        private List<Person> persons;
        private List<string> strings;
        private Dictionary<Person, Employee> EmployeesByPerson;
        private Dictionary<string, Employee> EmployeesByString;
        public TestCollections(int length) {

        }
    }
    class EmployeeListHandlerEventArgs : System.EventArgs {
        public string collectionName { get; set; }
        public string changes { get; set; }
        public Employee link { get; set; }
        public EmployeeListHandlerEventArgs(string collectionName, string changes, Employee link){
            this.collectionName = collectionName;
            this.changes = changes;
            this.link = link;
        }
        public override string ToString() {
            return $"Name of the collection: {collectionName}\nChanges: {changes}\nEmployee: {link}";
        }
    }
    class Journal {
        class JournalEntry {
            public string collectionName { get; set ;}
            public string changesType { get; set; }
            public Employee target { get; set; }
            public JournalEntry(string collectionName, string changesType, Employee target) {
                this.collectionName = collectionName;
                this.changesType = changesType;
                this.target = target;
            }
            public override string ToString() {
                return $"Collection name: {collectionName}\nType of changes: {changesType}\n Target employee: {target.ToShortString()}";
            }
        }
        private List<JournalEntry> list = new List<JournalEntry>();
        public void EmployeesCountChanged(object sender, EmployeeListHandlerEventArgs e) {
            list.Add(new JournalEntry(e.collectionName, e.changes, e.link));
        }
        public void EmployeeReferenceChanged(object sender, EmployeeListHandlerEventArgs e) {
            list.Add(new JournalEntry(e.collectionName, e.changes, e.link));
        }
        public override string ToString() {
            string str = "";
            foreach (JournalEntry log in list) {
                str += $"{log}\n";
            }
            return str;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {   // 1
            EmployeeCollection firstCollection = new EmployeeCollection("First collection");
            EmployeeCollection secondCollection = new EmployeeCollection("Second Collection");
            Journal firstJournal = new Journal();
            Journal secondJournal = new Journal();
            firstCollection.EmployeeReferenceChanged += firstJournal.EmployeeReferenceChanged;
            firstCollection.EmployeesCountChanged += firstJournal.EmployeesCountChanged;
            firstCollection.EmployeeReferenceChanged += secondJournal.EmployeeReferenceChanged;
            secondCollection.EmployeesCountChanged += secondJournal.EmployeesCountChanged;
            secondCollection.EmployeeReferenceChanged += secondJournal.EmployeeReferenceChanged;
            firstCollection.AddEmployee(new Employee(new Person("Billy", "Herrington", new DateTime(1969, 07, 14)), JobTitle.Perfomance_Artist, 333));
            firstCollection.AddDefaults();
            secondCollection.AddEmployee(new Employee(new Person("Sebastian", "Fors", new DateTime(1990, 12, 16)), JobTitle.Twitch_Streamer, 400));
            secondCollection.AddDefaults();
            // 3
            firstCollection.AddEmployee(new Employee(new Person("Vitaly", "Gromyako", new DateTime(1991, 12, 10)), JobTitle.Twitch_Streamer, 228));
            firstCollection.Remove(1);
            firstCollection[0] = new Employee(new Person("Billy", "Herrington", new DateTime(1969, 07, 14)), JobTitle.Perfomance_Artist, 101);
            secondCollection.AddEmployee(new Employee(new Person("Vitaly", "Gromyako", new DateTime(1991, 12, 10)), JobTitle.Twitch_Streamer, 228));
            secondCollection.Remove(1);
            secondCollection[0] = new Employee(new Person("Sebastian", "Fors", new DateTime(1990, 12, 16)), JobTitle.Twitch_Streamer, 499);

            // 4
            Console.WriteLine($"First journal: \n{firstJournal}");
            Console.WriteLine($"Second journal: \n{secondJournal}");
        }
    }
}
