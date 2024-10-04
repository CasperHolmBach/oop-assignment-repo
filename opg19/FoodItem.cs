public class FoodItem : Item
{
	public int expireTime;

	//Constructor gets itemName and itemPrice from parent through base command
	public FoodItem(string itemName, double itemPrice, int expiresIn) : base(itemName, itemPrice)
	{
		expireTime = expiresIn;
		name = itemName;
		price = itemPrice;
		
	}

	//Methods
	public int GetExpires()
	{
		return expireTime;
	}

	public override string ToString()
	{
		return "Item name: " + name + " | Item price: " + price + " | Item expires in: " + expireTime + " days \n";
	}
		

}