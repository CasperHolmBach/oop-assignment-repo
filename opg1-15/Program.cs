//Console.WriteLine("Hej Mongollos");

//Opgave 5.1
//Console.WriteLine("Hej");

//Opgave 5.2
//Det er en float eller double

//Opgave 5.3
//en int til månedens nummer og en string til månedens navn

//Opgave 5.4
/*byte overflow = 256;
Console.WriteLine(overflow);
Terminalen melder fejl så snart en byte fylder mere end 255*/

//Opgave 5.5
/*
int i = 5;
long l = i;
Console.WriteLine(l);

float f = 5;
double d = f;
Console.WriteLine(d);
*/


//Opgave 6.1
//En expression er hvad som helst, som har en tildelt værdi og som kan benyttes i et sammenhæng, hvor en værdi forventes.

//Opgave 6.2
//Ja, fordi den kan angive en værdi

//Opgave 6.3
//Statements er valg og funktioner som programmet kan træffe f.eks. if statements, for-løkker og kald på metoder.


//Opgave 7.1
//Angiver variabler
/*
double radius;
double result;

Console.WriteLine("Angiv en radius");
radius = double.Parse(Console.ReadLine());

result = Math.PI*Math.Pow(radius, 2);
Console.WriteLine("Arealet på din cirkel giver:" + result);
*/

//Opgave 7.2
/*
//Angiver radier
int r1 = 1;
double circ1;
int r2 = 3;
double circ2;
int r3 = 5;
double circ3;


//Regner omkredser
circ1 = 2*Math.PI*r1;
Console.WriteLine("Omkredsen på cirkel 1 er: " + circ1);
circ2 = 2*Math.PI*r2;
Console.WriteLine("Omkredsen på cirkel 2 er: " + circ2);
circ3 = 2*Math.PI*r3;
Console.WriteLine("Omkredsen på cirkel 3 er: " + circ3);
*/

//Opgave 7.4
/*
int seconds = 1726225165;

//Regner hvor mange år der er gået + resten fra den division.
int years = seconds / 31556926;
int remainderYears = seconds % 31556926;

//Regner hvor mange måneder jeg kan få ud af resten af sekunder.
int months = remainderYears / 2629743;
int remainderMonths = remainderYears % 2629743;

//Regner hvor mange dage jeg kan få ud af resten af sekunder
int days = remainderMonths / 86400;
int remainderDays = remainderMonths % 86400;

//Nu printer jeg alle resultaterne
Console.WriteLine("Der er gået " + years + " år, " + months + " måneder, " + days + " dage og " + remainderDays + " sekunder siden 1. januar 1970");
*/

//Opgave 8.1
//En boolean er en variabel der kan holde værdierne true eller false.

//Opgave 8.2
// Man kan bruge: == != < > <= >=

//Opgave 8.3
/*
double price = 599.95;
double budget = 1000.0;
boolean requiredReading = true;
boolean shouldBuy = price < budget && requiredReading;

1) Programmet læser fra venstre til højre, men hvis første betingelse ikke er rigtig, fortsætter den ikke med næste da det er ligegyldt eftersom der benyttes &&.
2) Oversætter man den linje kode til sine værdier får man: boolean shouldBuy = 599.95 < 1000.0 && true;
3) Først regnes price < budget som to doubles. Eftersom det er sandt bliver det til true. Udsagnet requiredReading er ogs true. 
4) shouldBuy repræsenterer en true eller false værdi på baggrund af om prisen er indenfor dit budget.
*/

//Opgave 8.4


/*
Random rnd = new Random(); //Generer tilfældigt tal da det er sjovere
byte dice = (byte)rnd.Next(1,6); //Det giver bedst mening at bruge en byte da den fylder mindst og jeg ikke skal bruge tal højere end 6 og mindre end 1.

if(dice > 3 && dice%2 == 0)
	Console.WriteLine(dice);
else
{	
	Console.WriteLine("Tallet opfyldte ikke kriterierne. Tallet var:");
	Console.WriteLine(dice);
}
*/

//Opgave 9.1
/*
int epoch = 22118400;

int nrMonth = (epoch / 2592000)+1;
int remainderMonths = epoch % 2592000;
Console.WriteLine("Vi er i måned nr " + nrMonth);

int nrDay = remainderMonths / 86400;
Console.WriteLine("Vi er i dag nr " + nrDay);
*/

//Opgave 11.1
//Et array er en kompleks type, som kan holde flere værdier end f.eks. en int. Man kan forstille sig et array som en tabel / skema. 

//Opgave 11.2
//Det giver mening at bruge et array hvis man skal opbevare flere variabler af samme type, hvor det ikke er relevant at give hver enkelt et navn.

//Opgave 11.3
//Arrayets type bestemmer hvilke datatyper arrayet kan opbevare

//Opgave 11.4
/*
Random rnd = new Random(); //Initialize random number
int[] array = new int[10]; //Initialize array 

Console.WriteLine("Dit array ser således ud:");
for(int i = 0; i < array.Length; i++) //Fill array with random numbers
{
	array[i] = rnd.Next(1,10);
	Console.Write(array[i] + " ");
}

Console.WriteLine(" ");

int placeHolder; //Variable for holding number being swapped
int pos = 0; //position for the given number being moved

for(int i = 0; i < array.Length; i++) //Sort array
{
	
	while(array[pos] > array[pos+1])
	{
		if(pos > array.Length)
			break;
		
		placeHolder = array[pos]; //Save next number in the place holder variable
		array[pos] = array[pos + 1]; //move ent number one index forward
		array[pos + 1] = placeHolder; //Put the held value in the current index
		
		pos = 1 + pos;
		
		
	}
	pos = i;
	Console.Write(array[i] + " ");		
}
*/



//Opgave 15.1
/*
int iterationer = 10;
int[] array = { 1, 2, 3, 4, 5 };

// increment
for (int i = 0 ; i < iterationer ; i++)
{
	array[i]++;
}

// print
for (int i = 0 ; i < array.Length ; i++)
{
	Console.WriteLine(array[i]);
}
*/
//Der fås: System.IndexOutOfRangeException. Dette er pga at variablen iterationer er 10 og bliver brugt som stop condition i et Forloop, som bevæger sig igennem et array der kun har et index på 5 (0-4).

//Rettede kode:
/*
int iterationer = 10;
int[] array = { 1, 2, 3, 4, 5};

// print
for (int i = 0 ; i < array.Length ; i++)
{
	Console.WriteLine(array[i]);
}

// increment
for (int i = 0 ; i < iterationer ; i++)
{
	try
	{
		array[i]++;
	}
	catch(IndexOutOfRangeException)
	{
		Console.Write(" ");
	}
}
*/
//Dette kunne være en løsning. Her bliver der bare skrevet en blank linje, hvis index er out of bounds. Det vil dog ikke være en god løsning. Da det ikke er et dynamisk input giver det mere mening bare at løse det direkte.



//Opgave 15.2
/*
int[] accounts = { 903, 716, 67 };

int GetAccountNumber()
{
	Console.WriteLine("Enter an account number: ");
	return Convert.ToInt32(Console.ReadLine());
}

void PrintAccountState(int accountId)
{
	Console.WriteLine("Account " + accountId + " contains " + accounts[accountId]);
}

while (true)
{
	int accountId = GetAccountNumber();
	PrintAccountState(accountId);
}
*/

//1. Inputtet 3 er ude fra array index
// 3. Programmet giver format exception. Løsning:

/*
int[] accounts = { 903, 716, 67 };

int GetAccountNumber()
{
	int input = 0;
	bool validInput = false;
	
	while(!validInput)
	{
		Console.WriteLine("Enter an account number: ");

		try
		{
			input = Convert.ToInt32(Console.ReadLine());
			validInput = true;
		}
		catch(FormatException)
		{
			Console.WriteLine("Only numbers are valid inputs, try again: ");
		}
	}
	
	return input;
}

void PrintAccountState(int accountId)
{
	Console.WriteLine("Account " + accountId + " contains " + accounts[accountId]);
}

while (true)
{
	try
	{
		int accountId = GetAccountNumber();
		PrintAccountState(accountId);
	}
	catch(IndexOutOfRangeException)
	{
		Console.WriteLine("This account does not exist, please choose another.");
	}
}
*/


Console.Write("mongol");
