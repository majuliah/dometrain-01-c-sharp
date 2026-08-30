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










