public class NonFoodItem : Item
{
	public string material;

	//Constructor gets itemName and itemPrice from parent through base command
	public NonFoodItem(string itemName, double itemPrice, string itemMaterial) : base(itemName, itemPrice)
	{
		material = itemMaterial;
		name = itemName;
		price = itemPrice;
		
	}

	//Methods
	public string GetMaterial()
	{
		return material;
	}

	public override string ToString()
	{
		return "Item name: " + name + " | Item price: " + price + " | Item is made of: " + material + "\n";
	}
		

}