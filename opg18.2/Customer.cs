public class Customer
{
	public string name;
	public int id;
	public double balance;

	//----------Constructors---------
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