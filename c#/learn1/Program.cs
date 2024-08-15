using Classes;

Console.WriteLine("The current time is " + DateTime.Now);

var account = new BankAccount("Jane", 1000);
Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} initial balance");
