// Floating point numbers are numbers with decimal points
// A float in c# is 32 bits or 4 bytes
// The range of a float is from 1.5 x 10^-45 to 3.4 x 10^38
// A double in c# is 64 bits or 8 bytes
// The range of a double is from 5.0 x 10^-324 to 1.7 x 10^308

// we can declare a float variable
float myFloat;
float my_float;
float MyFloat;

// We can declare a double variable
double myDouble;
double my_double;
double MyDouble;

// we can assign a value to these variables
myFloat = 5.5f; // we need to use the f suffix to indicate that this is a float
myDouble = 5.5; // we don't need a suffix for doubles

// we can declare and assign in one line    
float coolFloat = 15.5f;
double coolDouble = 15.5;

// we can re-assign the value of these variables
myFloat = 10.5f;
myDouble = 10.5;

// we can do math with floats and doubles
float floatSum = 5.5f + 10.5f;
double difference = 10.5 - 5.5;
float product = 5.5f * 10.5f;
float quotient = 5.5f / 10.5f;

// we can see the results of our math with string interpolation
Console.WriteLine($"Float sum: {floatSum}");
Console.WriteLine($"Double difference: {difference}");
Console.WriteLine($"Float product: {product}");
Console.WriteLine($"Float quotient: {quotient}");

# region 0.1 Strings
static void Strings()
{
    // Keep your eyes peeled:
    // What do you notice at the end of
    // the lines of code?

    // strings are represented by double quotes ""
    // In the following line, what part is the string?
    Console.WriteLine("Hello, World!");

    // We can "declare" a string variable
    string myString;
    string my_string;
    string MyString;

    // We can assign a value to a string variable
    myString = "Hello World";

    // We can declare and assign in one line
    string coolString = "Hello, World!";

    // we can re-assign the value of the variable
    coolString = "Hello, Universe!";

    // we can concatenate strings
    string firstName = "John";
    string lastName = "Doe";
    string fullName = firstName + " " + lastName;

    // we can use Console.WriteLine() to print strings
    Console.WriteLine(fullName);

    // we can use Console.ReadLine() to get input from the user
    // (this will be helpful for some basic programs!)
    myString = Console.ReadLine();

    // we can print the length of a string
    Console.WriteLine(myString.Length);

    // we can access individual characters in a string using an index
    Console.WriteLine(myString[0]);

    // if you just wanted to declare a single character, you can use single quotes ''
    char myChar = 'A';

    // we need to end our lines of code with a semicolon ;
}
#endregion
#region 0.2 Integers
// Integers are whole numbers
// An integer in C# is 32 bits or 4 bytes
// The range of an integer is from -2,147,483,648 to 2,147,483,647

// we can declare an integer variable
int myInt;
int my_int;
int MyInt;

// we can assign a value to an integer variable
myInt = 5;

// we can declare and assign in one line
int coolInt = 10;

// we can re-assign the value of the integer
myInt = 15;

// we can do math with integers
int sum = 5 + 10;
int difference = 10 - 5;
int product = 5 * 10;
int quotient = 5 / 10;

// this is a slightly more advanced topic, but we can see
// the results of our math with string interpolation
Console.WriteLine($"5 + 10 = {sum}");
Console.WriteLine($"10 - 5 = {difference}");
Console.WriteLine($"5 * 10 = {product}");
Console.WriteLine($"5 / 10 = {quotient}");

// Do we notice anything weird about the quotient? 
// Why is it 0?! 

// we will need to use another data type to help us here!
#endregion