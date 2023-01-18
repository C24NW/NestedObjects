using NestedObjects;

Advisor compSciAdvisor = new Advisor()
{
    Email = "name@email.edu",
    FullName = "AdvisorFirstName AdvisorLastName",
    OfficeLocation = "Building Number"

};

Student stu1 = new Student()
{
    FirstName = "StudentFirst",
    LastName = "StudentLast",
    DateOfBirth = new DateOnly(1899, 12, 31),
    AssignedAdvisor = compSciAdvisor,
    PhoneNumber = "1234567890",
    SchoolEmail = "email@school.edu"
};


Console.WriteLine($"Student: {stu1.FirstName} has {stu1.AssignedAdvisor.FullName}");