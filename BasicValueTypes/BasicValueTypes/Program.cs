#region 0.1 Strings
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

#region 0.3 Floats and Doubles
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

#endregion

#region 0.3 Booleans
// A boolean is a data type that can only have two values: true or false
// A boolean in C# is 1 bit or 1 byte

// we can declare a boolean variable
bool myBool;
bool my_bool;
bool MyBool;

// we can assign a value to a boolean variable
myBool = true;
my_bool = false;

// we can declare and assign in one line    
bool coolBool = false;

// we can re-assign the value of a boolean variable
coolBool = true;

// we can do boolean logic with these variables
bool trueAndFalse = true && false; // false
bool trueAndTrue = true && true; // true
bool falseAndFalse = false && false; // false

// we can do boolean logic with the OR operator ||
bool trueOrFalse = true || false; // true
bool trueOrTrue = true || true; // true
bool falseOrFalse = false || false;

// we can do boolean logic with the NOT operator !
bool notTrue = !true; // false
bool notFalse = !false; // true

// the results of boolean logic
// as we see with string interpolation:
Console.WriteLine($"true && false = {trueAndFalse}");
Console.WriteLine($"true && true = {trueAndTrue}");
Console.WriteLine($"false && false = {falseAndFalse}");
Console.WriteLine($"true || false = {trueOrFalse}");
Console.WriteLine($"true || true = {trueOrTrue}");
Console.WriteLine($"false || false = {falseOrFalse}");
Console.WriteLine($"!true = {notTrue}");
Console.WriteLine($"!false = {notFalse}");
#endregion

#region 0.4 DateTime, DateOnly, TimeOnly
// Date and time can be stored in a DateTime variable
// Dates can be assigned to a DateOnly variable
// Times can be assigned to a TimeOnly variable

// We can declare a DateTime variable
DateTime myDateTime;

// We can declate a DateOnly variable
DateOnly myDateOnly;

// We can declare a TimeOnly variable
TimeOnly myTimeOnly;

// we can assign a value to these variables
myDateTime = DateTime.Now; // current date and time
myDateOnly = new DateOnly(2026, 8, 21); // current date
myTimeOnly = new TimeOnly(12, 0, 0); // current time  

// we can declare and assign in one line
DateTime coolDateTime = DateTime.Now;
DateOnly coolDateOnly = new DateOnly(2026, 08, 22);
TimeOnly coolTimeOnly = new TimeOnly(12, 0, 0);

// we can re-assign the value of these variables
myDateTime = DateTime.Now;
myDateOnly = new DateOnly(2026, 8, 23);
myTimeOnly = new TimeOnly(12, 0, 0);

// Dates and Times are complex... consider 
// that we haven't factores in time zones, daylight savings, leap years, etc.

// we can make a DateTime variable out of
// a DateOnly and a TimeOnly variable
DateTime dateTimeFromCombination = new DateTime(myDateOnly, myTimeOnly);

// let's print out the values of our variables
Console.WriteLine($"DateTime: {myDateTime}");
Console.WriteLine($"DateOnly: {myDateOnly}");
Console.WriteLine($"TimeOnly: {myTimeOnly}");
Console.WriteLine($"Combined DateTime: {dateTimeFromCombination}");
#endregion

#region 0.5 Type Conversion
// How do we convert between these types?
// We can "cast" them, wich means to convert them to a different type.

// we can implicitly cast betwen compatible types
// for example, we can cast an int to a double

int myIntNew = 5;
double myDoubleNew = myIntNew; // implicit cast
Console.WriteLine("Implicit cast:");
Console.WriteLine($"Int: {myIntNew}, Double: {myDoubleNew}" );

// we can also explicitly cast between compatible types
// for example, we can cast a double to an int
myDoubleNew = 5.7;
myIntNew = (int)myDouble; // explicit cast
Console.WriteLine("Explicit cast:");
Console.WriteLine($"Double: {myDouble}, Int: {myInt}" );

// we cannot cast between incompatible types, such as a string and an int
    string myString = "5";
// int myInt = (int)myString; // this would cause a compile-time error

// we can also convert between types that are not compatible 
//for example, we can convert a string to an int
myInt = int.Parse(myString); // this will throw an exception if the string is not a valid int
Console.WriteLine("Parse:");
Console.WriteLine($"myString: {myString}, myInt: {myInt}" );

myString = "6.6";
myDouble = double.Parse(myString); // this will throw an exception if the string is not a valid double
Console.WriteLine("Parse:");
Console.WriteLine($"myString: {myString}, myDouble: {myDouble}" );
#endregion