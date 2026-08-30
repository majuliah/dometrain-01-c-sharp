#region For Loops
// a for loop is a loop that runs a specific number of times
// we saw how to count with while loops...
// but a for loop is designed to count!

// here is the syntax for a for loop:
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
}

// a for loop has three parts:
// 1. the initializer: int = 0;
// 2. the condition: i < 10;
// 3. the iterator: i++

// note that we can't access i outside of the loop!
// i = 123; // this will not work!

// we can use break and continue in a for loop as well,
// just like we did with while loop

// here's an example of a for loop with a break:
for (int i = 0; i <10; i++)
{
    if (i == 5)
    {
        Console.WriteLine("We're outta here!");
        break; //break, breakes the loop
    }
    Console.WriteLine(i);
}

// here's an exemple of a for loop with continue
for (int i = 0; i < 10; i++)
{
    if (i == 5)
    {
        Console.WriteLine("Skipping the 5!");
        continue; // continue will go back to the next iteration
    }
    Console.WriteLine(i);
}



#endregion



# region 1: Do and DoWhile

// While loops and do while loops are used
// to execute a block of code repeatedly.

//here is what a while loop looks like
// while( condition )
//{
//  //code to execute
//}

// here is what a do while loop looks like
// do
// {
//      //code to execute
// }

// lets make some real ones!

// here is a while loop that counts to 7
int count = 0;
while (count > 5)
// while(count < 5) -> this will never run
{
    Console.WriteLine(count);
    count++;
}
Console.WriteLine($"The total of count is {count}!");


// here is args do while loop that counts to 5
count = 0;
do
{
    Console.WriteLine(count);
    count++;
} while (count < 5);
// while(count > 5)  -> this will execute 1 time
Console.WriteLine($"The total count is {count}");

// lets add a condition to the while loop
// so we can see, the behavior of
//break and continue
count = 0;
while (count < 5)
{
    if (count == 3)
    {
        count++;
        Console.WriteLine("I'm skipping 3!");
        continue;
        //continue breaks the rest of the code, ignores everything above and goes back to the while condition
    }
    Console.WriteLine(count);
    count++;
    if (count == 5) //with if(count == 4), this code will never enter
    {
        Console.WriteLine("I'm out of here!");
        break;
    }
}
#endregion









