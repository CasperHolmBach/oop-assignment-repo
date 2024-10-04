public class Item
{
	public string name;
	public double price;

	//Constructor
	public Item(string itemName, double itemPrice)
	{
		name = itemName;
		price = itemPrice;
	}

	//Methods
	public string GetName()
	{
		return name;
	}
	
	public double GetPrice()
	{
		return price;
	}

}