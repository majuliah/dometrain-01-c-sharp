// lists are used to store multiple values
// lists are zero based
// lists are dynamic in size
// we can get values from a list
// we can set values in a list
// we can add values to a list
// we can remove values to a list
// we can insert values into a list
// we clear a list
// we can sort a list

// here is how we declare a list
List<string> words = new List<string>();

// here is how we add values to a list
words.Add("one");
words.Add("two");
words.Add("there");

// here is how we get values from a list
string firstWord = words.First();
Console.WriteLine(firstWord);
string secondWord = words.Last();
Console.WriteLine(secondWord);

string thirdWord = words[0];
string fourthWord = words[1];
string fifthWord = words[2];

words[0] = "four";

// here is how we declare and initialize a list
List<int> numbers = new List<int>
{
    1,
    2,
    3,
    4,
};
// here is how we declare and initialize a list
int count = numbers.Count;

// here is how we remove a value from a list
numbers.Remove(1);
numbers.Remove(2);
numbers.Remove(3);

// number is now:
// [4]

// here is how we insert a value from a list
numbers.Insert(0, 1);
numbers.Insert(1, 2);
numbers.Insert(2, 3);

// here is hou we clear a list
numbers.Clear();

// here is how we sort a list
words.Sort();




















/*
# region 0.1 Arrays
// arrays are a collection of variables of the same type.
// They are fixed in size and can be multidimensional.
// The elements of an array are accessed using an index, which starts at 0.
// Arrays can be declared and initialized in various ways.

// here is how we declare an array
int[] numbers = new int[3]; // declares an array of 3 integers

// here is how we set values in an array
numbers[0] = 1;
numbers[1] = 2;
numbers[2] = 3;

// here is how we get values from an array
int firstNumber = numbers[0]; // gets the first element of the array
int secondNumber = numbers[1];

// here is how we declare and initialize an array 
int[] newNumbers = new int[]
{
    5,
    6,
    7,
    8
};

int[] numbers3 =
{
    10,
    11,
    12
};

int[] numbers4 = [3, 4, 5];

// here is how we get the length of an array
int length = numbers3.Length;
#endregion
*/