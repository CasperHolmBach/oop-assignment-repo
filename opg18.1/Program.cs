//Opgave 18.1

class Assignment
{
	static void Main()
	{
		Customer aCustomer = new Customer("Casper", 1, 1000);

		aCustomer.Deposit(500);
		aCustomer.Withdraw(700);
		Console.Write(aCustomer.GetBalance());
	}

	public class Customer
	{
		public string name;
		public int id;
		public double balance;

		//----------Constructors----------
		//Default constructor
		/*
		public Customer()
		{
			name = " ";
			id = 0;
			balance = 0;
		}
		*/

		public Customer(string customerName, int customerID)
		{
			name = customerName;
			id = customerID;
			balance = 0;
		}

		public Customer(string customerName, int customerID, double customerBalance)
		{
			name = customerName;
			id = customerID;
			balance = customerBalance;
		}

		//----------Methods----------
		public void Deposit(double amount)
		{
			balance = balance + amount;
		}

		public void Withdraw(double amount)
		{
			if (balance > amount)
				balance = balance - amount;
		}

		public double GetBalance()
		{
			return balance;
		}
		
	}

}