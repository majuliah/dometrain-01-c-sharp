
#region Simple Methods
// a method is a block of code that performs a specific task
// we use methosds to break our code into smaller, more manageable pieces!

// here is sn example of a method
void ThisIsAMethod()
{
    // this is the body of the method
    // it contains the code that will be executed when the method is called
    Console.WriteLine("Hello from thisIsAMethod!");
}

// we can call the method by using its name followed by parentheses
ThisIsAMethod();

// if we had the code like following, how might
// we go make a method for it?
Console.WriteLine("-----------------------");
Console.WriteLine("      New Example      ");
Console.WriteLine("-----------------------");

// we could make a method like this:
void PrintSeparator()
{
    Console.WriteLine("-----------------------");
}

// and then we could call the method like this:

PrintSeparator();
Console.WriteLine("      New Example      ");
PrintSeparator();

// we could take a step further and make ANOTHER method that prints out the entire header for us, like this:

void PrintHeader()
{
    PrintSeparator();
    Console.WriteLine("      New Example!      ");
    PrintSeparator();
}

// and then call it like this
PrintHeader();

#endregion

#region Arguments

//a parameter is a variable in a method definition. When a method is called
// the arguments are the data you pass into the method's parameters.
// the parameters go into the parenthesis of the method
// the arguments go into the parenthesis of the method call

// here is an example of a method with parameters
void MyMethod(string name, int age)
{
    // the method body
}

// here is an example of a method call with arguments
MyMethod("Majulha", 26);

// can we build upon the example we saw earlier?
// we can add a parametet to the method to make it more flexible!

void PrintSeparator2()
{
    Console.WriteLine("-------------------");
}

void PrintHeader2(string name)
{
    PrintSeparator2();
    Console.WriteLine($"      {name}      ");
    PrintSeparator2();
}

PrintHeader2("New Example 2!");
PrintHeader2("Another Example!");


#endregion

#region Return Types

// the difference between a method and function is that a function returns a value, while a method does not.
// a return value is a value that is returnet from a method when its called.
// methods with return types are called functions!!!!!
// a method can only have one return value
// and the return value must have the same type as the method

// here is an example of a method with a return value
int Add(int a, int b)
{
    return a + b;
}

// we can call the method like this
int sum = Add(5, 10);

// we can also call the method like this
int x = 5;
int y = 10;
int sum2 = Add(x, y);

// we can also call the method like this
int sum3 = Add
    (
    Add(1, 2),
    Add(x, y)
    );

// the return value must match the type of the method
// so this would be an error
//string Add(int a, int b)
//{
//    return a + b; // error: cannot convert int to string
//}


#endregion