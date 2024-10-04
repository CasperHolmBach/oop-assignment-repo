public class CustomerDatabase
{
	Customer[] customers;
	int numOfCustomer = 0; //Keep count of the amount of customers

	//----------Constructor----------
	public CustomerDatabase()
	{
		customers = new Customer[10];
	}
		
	//----------Methods----------
	public void registerCustomer(Customer addedCustomer)
	{
		customers[numOfCustomer] = addedCustomer;
		numOfCustomer++;
	}

	public void deleteCustomer(int idToBeDeleted)
	{
		for(int i = 0; i < customers.Length; i++)
		{
			if(customers[i].id == idToBeDeleted)
				customers[i] = null;
		}
	}

	public void printDatabase()
	{
		for(int i = 0; i < customers.Length; i++)
		{
			if(customers[i] != null)
			{
				Console.WriteLine("Name: " + customers[i].name);
				Console.WriteLine("Id: " + customers[i].id);
				Console.WriteLine("Balance: " + customers[i].balance);
				Console.WriteLine(" ");
			}
		}
	}

	public void showCustomers()
	{
		for(int i = 0; i < customers.Length; i++)
		{
			if(customers[i] != null)
				Console.WriteLine(customers[i].name);
		}
	}
}