// See https://aka.ms/new-console-template for more information
using LSPLibrary;

Manager accountingVP = new Manager();

accountingVP.FirstName = "Thomas";
accountingVP.LastName = "Wong";
accountingVP.CalculatePerHourRate(4);

Employee emp = new Employee();
emp.FirstName = "Rena";
emp.LastName = "Pai";
emp.CalculatePerHourRate(2);
emp.AssignManager(accountingVP);

Console.WriteLine($"{ emp.FirstName }'s salary is ${emp.Salary}/hour");
Console.ReadLine();