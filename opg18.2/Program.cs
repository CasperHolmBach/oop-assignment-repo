//Opgave 18.2

class Assignment
{
	static void Main()
	{
		CustomerDatabase db = new CustomerDatabase(); //Create database (db)
		Customer aCustomer = new Customer("Abe", 1);
		Customer bCustomer = new Customer("john" , 2);
		Customer cCustomer = new Customer("noah" , 3);

		Console.WriteLine("First test");
		db.registerCustomer(aCustomer);
		db.printDatabase();

		Console.WriteLine("Second test");
		db.registerCustomer(bCustomer);
		db.printDatabase();
		
		Console.WriteLine("Indbetaler 2000 kroner på johns konto");
		bCustomer.Deposit(2000);
		Console.WriteLine("Saldoen for john er: " + bCustomer.GetBalance());
		Console.WriteLine(" ");

		Console.WriteLine("Third test");
		db.registerCustomer(cCustomer);
		db.printDatabase();

		Console.WriteLine("Fourth test");
		db.deleteCustomer(1);
		db.printDatabase();
		
	}
}