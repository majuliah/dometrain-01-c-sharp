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
