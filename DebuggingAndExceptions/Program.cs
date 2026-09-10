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