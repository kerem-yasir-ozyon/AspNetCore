// See https://aka.ms/new-console-template for more information
using Intro.Business;
using Intro.Entities;

Console.WriteLine("Hello, World!");

string[] loans = { "kredi1", "kredi2", "kredi3" };

for (int i = 0; i < loans.Length; i++)
{
    Console.WriteLine(loans[i]);
}

Course course1 = new Course();
course1.Id = 1;
course1.Name = "C#";
course1.Description = ".Net8";
course1.Price = 0;

Course course2 = new Course();
course2.Id = 2;
course2.Name = "java";
course2.Description = "Java17";
course2.Price = 0;

Course course3 = new Course();
course3.Id = 3;
course3.Name = "python";
course3.Description = "Python3.12";
course3.Price = 0;

Course[] courses = { course1, course2, course3 };

for (int i = 0; i < courses.Length; i++)
{
    Console.WriteLine(courses[i].Name + " / " + courses[i].Description);
}

CourseManager courseManager = new CourseManager();
Course[] courses2 = courseManager.GetAll();

for (int i = 0; i < courses2.Length; i++)
{
    Console.WriteLine(courses[i].Name + " / " + courses[i].Description);
}

IndividualCustomer customer1 =  new IndividualCustomer();
customer1.Id = 1;
customer1.NationalIdentity = "12345678922";
customer1.FirstName = "Kerem";
customer1.LastName = "Ozyon";
customer1.CustomerNumber = "1234";

IndividualCustomer customer2 = new IndividualCustomer();
customer2.Id = 2;
customer2.NationalIdentity = "12334578922";
customer2.FirstName = "ERdem";
customer2.LastName = "Ozyon";
customer2.CustomerNumber = "1434";

CoorporateCustomer customer3 = new CoorporateCustomer();
customer3.Id = 3;
customer3.Name = "Def";
customer3.CustomerNumber = "654756645";
customer3.TaxNumber = "123143534";

CoorporateCustomer customer4 = new CoorporateCustomer();
customer4.Id = 4;
customer4.Name = "Abc";
customer4.CustomerNumber = "123123123";
customer4.TaxNumber = "234234234";

string[] cities1 = { "Ankara", "İstanbul", "İzmir" };
string[] cities2 = { "Bursa", "Bolu", "Diyarbakır" };