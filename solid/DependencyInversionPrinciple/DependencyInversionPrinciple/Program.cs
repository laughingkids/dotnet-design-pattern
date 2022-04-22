// Issue: Higher level module depends on Lower level module - Person and Chore
// using NonDIPLibrary;
// Person owner = new Person
// {
//     FirstName = "Thomas",
//     LastName = "Wong",
//     EmailAddress = "thomas.wang@laughingkids.me",
//     TelephoneNumber = "555-1212"
// };
// Chore chore = new Chore
// {
//     ChoreName = "Take out the trash",
//     Owner = owner
// };



using DependencyInversionPrinciple;
using DIPLibrary;

IPerson owner = Factory.CreatePerson();
owner.FirstName = "Thomas";
owner.LastName = "Wong";
owner.EmailAddress = "thomas.wang@laughingkids.me";
owner.TelephoneNumber = "555-1212";

IChore chore = Factory.CreateChore();
chore.ChoreName = "Take out the trash";
chore.Owner = owner;

chore.PerformedWork(3);
chore.PerformedWork(1.5);
chore.CompleteChore();

Console.ReadLine();
