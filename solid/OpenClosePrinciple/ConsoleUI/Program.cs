// See https://aka.ms/new-console-template for more information
using OCPLibrary;

List<IApplicantModel> applicants = new List<IApplicantModel>
{
    new PersonModel { FirstName = "Tim", LastName = "Corey" },
    new ManagerModel { FirstName = "Rena", LastName = "Bai" },
    new ExecutiveModel { FirstName = "Thomas", LastName = "Wong" }
};

List<EmployeeModel> employees = new List<EmployeeModel>();


foreach (var person in applicants)
{
    employees.Add(person.AccountProcessor.Create(person));
}

foreach (var emp in employees)
{
    Console.WriteLine($"{emp.FirstName} {emp.LastName}: {emp.EmailAddress} IsManager: {emp.IsManager} IsExecutive: {emp.IsExecutive}");
}

Console.ReadLine();