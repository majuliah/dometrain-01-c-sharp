// ternary operators are used to assign a
// value to a variable based on a condition.
// The syntax is: (condition) ? value_if_true : value_if_false;

int x = 10;
string result = (x > 5) 
    ? "x is greater than 5" 
    : "x is less than or equal to 5";
Console.WriteLine(result);

result = x == 10 
    ? "x is equal to 10" 
    : "x is not equal to 10";
Console.WriteLine(result);

result = x < 20
    ? "x is less than 20"
    : "x is greater than or equal to 20";
Console.WriteLine(result);




#region 0.1 if statements
// the most basic type of control flow is the if statement,
// which allows us to execute a block of code only if a certain
// condition is true. If the condition is false, the block of code is skipped.

// The expression inside of the parentheses 
// is called the "condition"

if (true)
{    
    Console.WriteLine("This will always execute!");
}

if (false)
{
    Console.WriteLine("This will never execute!");
}

// we can use variables as the condition to check
// remember boolean variables?
// let's use one here!

bool condition = true;
if(condition)
{
    Console.WriteLine("This print when the condition is true!");
}

// we can also use the else statement to execute a block of code
// when the condition is false

if (condition)
{
    Console.WriteLine("This print when the condition is true!");
}
else
{
    Console.WriteLine("This print when the condition is false!");
}

// we can also use the else if statement to check multiple conditions
if (condition)
{
    Console.WriteLine("This print when the condition is true!");
}
else if(!condition)
{
    Console.WriteLine("This print when the condition is false!");
}
else
{
    //This print when the condition is neither true nor false!
    Console.WriteLine("Trick question?");
}
// can the else block above ever be executed?
// No!!
// Because our boolean variable can only be true or false.
// So the first two conditions will always cover all possible cases,
// and the else block will never be executed.

// Let's try this again with an integer!
// we will introduce some new syntax here as well
// < is the less than operator, which checks if the value on the left is less than the value on the right
// > is the greater than operator, which checks if the value on the left is greater than the value on the right
// <= is the less than or equal to operator, which checks if the value on the left is less than or equal to the value on the right
// >= is the greater than or equal to operator, which checks if the value on the left is greater than or equal to the value on the right
// == is the equality operator, which checks if the value on the left is equal to the value on the right
// != is the inequality operator, which checks if the value on the left is not equal to the value on the right

int number = 1;
if(number < 5)
{
    Console.WriteLine("The number is less than 5");
}
else if (number == 5)
{
    Console.WriteLine("The number is equal to 5");
}
else
{
    Console.WriteLine("The number is greater than 5");
}

// remember the && and the || operators?
// we can use them to combine multiple conditions in an if statement

number = 3;
if (number >= 1 && number <= 5)
{
    Console.WriteLine("The number is between 1 and 5");
}
else
{
    Console.WriteLine("The number is not between 1 and 5");
}

if(number < 1 || number > 5)
{
    Console.WriteLine("The number is not between 1 and 5");
}
else
{
    Console.WriteLine("The number is between 1 and 5");
}

#endregion