// See https://aka.ms/new-console-template for more information


// TASK 1

Console.WriteLine("TASK 1: TO PRINT ONTO THE CONSOLE\n");
string name = "John Doe";
int age = 25;
bool isAdmin = true;

Console.WriteLine($"Name= {name}\nAge= {age}\nRole is Admin= {isAdmin}" );

Console.WriteLine("\n---------------------------------------------------------------------------------------------------\n");


//TASK 2
Console.WriteLine("TASK 2: TO DETERMINE IF A NUMBER IS ODD OR EVEN\n");
int Number;
string result;
try
{
    Console.Write("Enter a Number:  ");
    Number = int.Parse(Console.ReadLine());
    //string result= Number % 2==0 ? "Even" : "Odd";
    if (Number % 2 == 0)
    {
        result = "Even";
    }
    else
    {
        result = "Odd";
    }
    Console.WriteLine($"\nNumber {Number} is an {result} number");
}
catch(Exception ex)
{
    Console.WriteLine("\n"+ ex.Message.ToString()); 
}

Console.WriteLine("\n---------------------------------------------------------------------------------------------------\n");


//TASK 3
Console.WriteLine("TASK 3: TO PRINT OUT NUMBERS 1-10 USING FOR LOOP\n");
for(int i = 1; i <= 10; i++)
{
    Console.WriteLine(i.ToString());
}

Console.WriteLine("\n---------------------------------------------------------------------------------------------------\n");



// TASK 4
Console.WriteLine("TASK 4: TO Declare and initialize an integer array with the values 2, 4, 6, 8, 10., Print out the Sum of the numbers, " +
    "and also print each number onto the console\n\n");

int[] integerArray= new int[5] {2,4,6,8,10};
int arraySum = integerArray.Sum(x => x);
Console.WriteLine($"Sum of Numbers in the Integer Array= {arraySum}\n");
Console.WriteLine("Elements of the Integer array are:");
foreach (int number in integerArray)
{
    Console.WriteLine(number);
}

Console.WriteLine("\n---------------------------------------------------------------------------------------------------\n");


// TASK 5
Console.WriteLine("TASK 5: To Write a method named Greet that takes a string parameter name and prints out a personalized greeting message.\n\n"); 
void Greet(string name)
{
    Console.WriteLine("Hello, "+name+"!");
}

Greet("Alice");

Console.WriteLine("\n---------------------------------------------------------------------------------------------------\n");







