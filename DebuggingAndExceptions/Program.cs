// debugging is the process of finding and 
// fixing errors within a computer program.
// errors in c# programs are called exceptions
// exceptions are thrown when an error occurs and can be caught using try-catch blocks

// lets create a simple program that throws an exception

int IntegerDivision(int numerator, int denominator)
{
    return numerator / denominator;
}

// the program will throw an exception when we try to divide by zero
int result = IntegerDivision(10, 0);

// exceptions are caught using try-catch blocks
// try-catch blocks look like this:
try
{
    // code that might throw an exception
}
catch(Exception e)
{
    // code that runs when an exception is thrown
}

// lets catch the exception thrown by the IntegerDivision method
try
{
    int result2 = IntegerDivision(10, 0);
}
catch (DivideByZeroException e)
{
    Console.WriteLine("Cannot divide by zero.");
    Console.WriteLine(e.Message);
}

// we can also use exception filters to catch exceptions that meet certain conditions
try
{
    IntegerDivision(10, 0);
}
catch(Exception e) when (e.Message.Contains("divide by zero"))
{
    Console.WriteLine("You cant divide by zero!");
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}

// we can use a finally block to run code after a try-catch block
try
{
    IntegerDivision(10, 0); 
}
catch (DivideByZeroException e)
{
    Console.WriteLine("Cannot divide by zero.");
}
finally
{
    Console.WriteLine("This code runs regardless of whether an exception was thrown or not.");
}