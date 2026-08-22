# region 0.1 Arrays
// arrays are a collection of variables of the same type.
// They are fixed in size and can be multidimensional.
// The elements of an array are accessed using an index, which starts at 0.
// Arrays can be declared and initialized in various ways.

// here is how we declare an array
int[] numbers1 = new int[3]; // declares an array of 3 integers

// here is how we set values in an array
numbers1[0] = 1;
numbers1[1] = 2;
numbers1[2] = 3;

// here is how we get values from an array
int firstNumber = numbers1[0]; // gets the first element of the array
int secondNumber = numbers1[1];

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

# region 0.2 Lists<>
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
#endregion

#region 0.3 Dictionary
// dictionaries are used to store key value pairs
// dictionaries are dynamic in size
// we can get values from a dictionary 
// we can set values into a dictionary
// we can add values into a dictionary
// we can remove values from dictionary
// we can check if a dictionary contains a key
// some other properties:

// the key in a dictionary are unique
// the values in a dictionary do not need to be unique
// dictionary keys do not need to be integers!

// here is how we declare a dictionary
Dictionary<string, int> wordsToNumbers = new Dictionary<string, int>();
Dictionary<int, string> numbersToWords = new Dictionary<int, string>();
Dictionary<string, int> shorthand = new();

//here is how we add entries
wordsToNumbers.Add("one", 1);
wordsToNumbers.Add("two", 2);
wordsToNumbers.Add("three", 3);

// here is what this will look like as we go line by line:
// ["one"] = 1
// ["two"] = 2
// ["three"] = 3

// here is how we get values from a dictionary
int one = wordsToNumbers["one"];
int two = wordsToNumbers["two"];
int three = wordsToNumbers["three"];

// here is how we get values from a dictionary
wordsToNumbers["one"] = 111;
wordsToNumbers["two"] = 222;

// wordsToNumbers is now:
// ["one"] = 111
// ["two"] = 222
// ["three"] = 3

// here us how we declare and initialize a dictionary
Dictionary<int, string> numbersToWords2 = new Dictionary<int, string>
{
    {1, "one" },
    {2, "two"},
    {3, "three" },
    {4, "four"},
};

Dictionary<int, string> numbersToWords3 = new Dictionary<int, string>
{
    [1] = "one",
    [2] = "two",
    [3] = "three",
    [4] = "four"
};

Dictionary<int, string> numbersToWords4 = new() 
{ 
    [1] = "one",
    [2] = "two",
    [3] = "three",
    [4] = "four"
};

// here is how we get the count of a dictionary
int count = numbersToWords2.Count; //4 because counts the numbers of PAIRS

// numbersToWords2 is:
//    [1] = "one",
//    [2] = "two",
//    [3] = "three",
//    [4] = "four"

// here is how we remove a value from dictionary
numbersToWords2.Remove(1); // will remove THE KEY
numbersToWords2.Remove(2);

// numbersToWords2 is:
//    [3] = "three",
//    [4] = "four"

// here is how we clear a dictionary
numbersToWords3.Clear();
numbersToWords4.Clear();

// this is how we check if a dictionary contains a key
bool contains = numbersToWords2.ContainsKey(3); //true

// here is how we check and get a value from a dictionary
bool contains2 = numbersToWords2.TryGetValue(
    3,
    out string? value
    );

// what happens if we add something that already exists?
// ERROR!!!
// wordsToNumbers.Add("one", 1);
// wordsToNumbers.Add(1, "one");

// we can use the indexer to add or set values
// wich will overwrite existing values

wordsToNumbers["one"] = 1;
numbersToWords2[1] = "one";

# endregion