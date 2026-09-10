// object oriented programming is a programming paradigm
// that uses objects and classes in programming
// we can structure a program by building related
// properties and behaviors into individual objects
// this means that for the first time we start to think 
// about our programs less like just a sequence of instructions
// and more like a collection of interacting objects

// in c# we can create a class by using the class keyword
using System.Security.Cryptography.X509Certificates;

public class OurClass
{
    
}

// we can create an object from a class by using  the new keyword
OurClass ourObject = new OurClass();

// we can use the short-form method to create an object
OurClass ourObject2 = new();

// remember the methods and functions we were creating?
// we can also create methods and functions inside of our classes
public class OurClass2
{
    // this is a method
    public void ExampleMethod()
    {
        Console.WriteLine("Hello from our method!");
    }
    public int ExampleFunction()
    {
        return 42;
    }
}
// lets make a new instance!
OurClass2 ourObject3 = new();
ourObject3.ExampleMethod();

int result = ourObject3.ExampleFunction();

// where else have we seen classes and objects?
// the console class!
Console.WriteLine("This is a method on the Console class!");

// Console.WriteLine looks a little bit different...
// why didn't we have to create a new instance of the Console class?
// well see why in a later lesson!

// objects are "reference types" in c#
// and up until now we've only been working with
// "value types" like int, double, and bool
// ... except for our collections!

OurClass objetc1 = new OurClass(); // new reference
OurClass objetc2 = new OurClass(); // new reference
OurClass objetc3 = objetc1; // same reference as objetc1

Console.WriteLine("Object1 == object2:");
Console.WriteLine(object1 == object2); // false
Console.WriteLine("Object1 == object3:");
Console.WriteLine(object1 == object3); // true

// collections are very the same!
List<int> list1 = new List<int>() { 1, 2, 3}; 
List<int> list2 = new List<int>() { 1, 2, 3};

Console.WriteLine("List1 == list2:");
Console.WriteLine(list1 == list2); // false

// lets wrap up with re-examining our parameter passing
// with value types and reference types!

void ChangeValue(int value)
{
    value = 100;
}   

int myValue = 50;
Console.WriteLine("myValue before ChangeValue: " + myValue);
ChangeValue(myValue);
Console.WriteLine("myValue after ChangeValue: " + myValue);






