
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