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