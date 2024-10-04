class Program
{
	static void Main()
	{
		Random rnd = new Random(); //Create instance of random for later use		
		
		//3 different arrays with random foods, nonfoods and materials for randomizing database
		string[] foods = new string[10]
        	{
           	 	"Pizza",
           	 	"Sushi",
           	 	"Tacos",
            		"Pasta",
            		"Burgers",
            		"Salad",
            		"Ice Cream",
            		"Chocolate",
            		"Steak",
            		"Fruit"
        	};

		string[] nonFoodItems = new string[10]
        	{
            		"Book",
            		"Laptop",
            		"Chair",
            		"Bicycle",
            		"Watch",
            		"Desk",
            		"Camera",
            		"Guitar",
            		"Phone",
            		"Backpack"
       		};

		string[] materials = new string[10]
        	{
            		"Paper",
            		"Leather",
            		"Nylon",
            		"Aluminum",
            		"Copper",
            		"Wood",
            		"Glass",
            		"Steel",
            		"Plastic",
            		"Rubber"
       		};		

		//Initialize database for foods
		FoodItem[] listOfFoods = new FoodItem[10]; 
		Console.WriteLine("Initialized database for foods");

		//Initialize array for nonfoods
		NonFoodItem[] listOfNonFoods = new NonFoodItem[10]; 
		Console.WriteLine("Initialized database for nonfood items");

		//For loop fills array with food items
		for(int i = 0; i < listOfFoods.Length; i++)
		{
			listOfFoods[i] = new FoodItem(foods[i], rnd.NextDouble() * (20 - 1) + 1, rnd.Next(1,5));
		}	
		
		Console.WriteLine(" ");
		Console.WriteLine("Now printing all the foods in the foods database");

		for(int i = 0; i < listOfFoods.Length; i++)
		{
			Console.Write(listOfFoods[i]);
		}


		
		//For loop fills array with nonFood items
		for(int i = 0; i < listOfNonFoods.Length; i++)
		{
			listOfNonFoods[i] = new NonFoodItem(nonFoodItems[i], rnd.NextDouble() * (20 - 1) + 1, materials[rnd.Next(1,10)]);
		}	
		
		Console.WriteLine(" ");
		Console.WriteLine("Now printing all the non food items in the non foods database");

		for(int i = 0; i < listOfNonFoods.Length; i++)
		{
			Console.Write(listOfNonFoods[i]);
		}
	}

}