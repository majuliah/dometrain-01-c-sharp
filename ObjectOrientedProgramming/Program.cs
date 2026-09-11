#region Intro and Reference Types
/*
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
Console.WriteLine("myValue before ChangeValue: " + myValue); // 50
ChangeValue(myValue);
Console.WriteLine("myValue after ChangeValue: " + myValue); // 50

void ChangeReference(List<string> words)
{
words = new List<string>();
words.Add("from");
words.Add("Dev");
words.Add("Leader");
}

List<string> myWords = new List<string> { "Hello", "World" };
Console.WriteLine("myWords before ChangeReference:");
Console.WriteLine(string.Join(" ", myWords)); // Hello World
ChangeReference(myWords);
Console.WriteLine("myWords after ChangeReference:");
Console.WriteLine(string.Join(" ", myWords)); // Hello World from Dev Leader

// this is because when we pass a value type to a method
// we're passing a copy of the value but when we pass a
// reference type to a method we're passing the reference!

// in C# we can create a class by using the class keyword
class OurClass4
{

}
*/
#endregion


#region Fields and Properties
// a field is a variable that is declared directly in a class or struct.
// Fields are used to store data for an object. They can be public, private, protected, or internal, and they can have different data types.
// here is how we declare a field in a class:
class Person
{
    private string _name; // this is a field
}

// a field is a variable that is declared directly in a class.
// we can give a field a value when we declate it
class Person2
{
    private string _name = "John Doe"; // this is a field with a value
}
// what does private do in the above exemples?
// "private" is an access modifier.
// We saw public as an access modifier in the last lesson, but there are others as well.
// "private" specifies that something is accessible only within the class
class Person3
{
    private string _name;
    public void SomeMe()
    {
        this._name = "John Doe"; // this is a field with a value
    }
}
//we can access _name using a method!
class Person4
{
    private string _name;
    public string GetName()
    {
        return this._name;
    }
}
//Person4 nomeNovoPessoa = new Person4();
//Console.WriteLine(nomeNovoPessoa.GetName());

// there are other access modifiers that we wont cover in this course

// a property is a member that provides a flexible mechanism to
// read, write, or compute the value of a private field.

class Person5
{
    private string _name = "Mary";
    public string Name 
    {
        get { return _name; } // this is the getter
    }

    public string Name2 => _name;
    public string Name3 { get; } = "Mary"; // this is the getter with a default value
    public string MutableName
    {
        get { return _name; } // this is the getter
        set { _name = value; } // this is the setter
    } 
}
////Person5 johnWithProperty = new Person5();
//Console.WriteLine(johnWithProperty.Name);
//Console.WriteLine(johnWithProperty.Name2);
//Console.WriteLine(johnWithProperty.Name3);

//Console.WriteLine("Setting the name...");
//johnWithProperty.MutableName = "John Doe";
//Console.WriteLine(johnWithProperty.MutableName);

//Console.WriteLine(johnWithProperty.MutableName);


#endregion

#region Static vs Instances

public sealed class StaticVsInstance
{
    public void RunExample()
    {
        // static is a modifier that makes a member belong to a type, rather than an "instance" of a type
        // we can even make entire classes static.

        // note that we cannot make an instance of "MyStaticClass" because it is marked static
        // MyStaticClass myStaticClass = new MyStaticClass(); // this will not work!

        // static classes cannot have instance members, so anything inside of a static class must also be static
        MyStaticClass.MyStaticMethod();

        // notice how we don't need to make an instance of MyStaticClass to call MyStaticMethod?
        // this is just like Console.WriteLine! This means that Console.WriteLine is a static method!

        // on non-static classes, we *can* add static members
        MyNonStaticClass myNonStaticClass1 = new MyNonStaticClass();
        MyNonStaticClass myNonStaticClass2 = new MyNonStaticClass();

        Console.WriteLine("Before mutating properties on MyNonStaticClass...");
        myNonStaticClass1.MyInstanceMethod();
        myNonStaticClass2.MyInstanceMethod();
        MyNonStaticClass.MyStaticMethod();

        // let's mutate these things and see what happens!
        myNonStaticClass1.MyInstanceProperty = "Dev";
        myNonStaticClass2.MyInstanceProperty = "Leader";
        MyNonStaticClass.MyStaticProperty = "Nick Cosentino";

        Console.WriteLine("After mutating properties on MyNonStaticClass...");
        myNonStaticClass1.MyInstanceMethod();
        myNonStaticClass2.MyInstanceMethod();
        MyNonStaticClass.MyStaticMethod();

        // static members are accessible across all instances. this can be
        // convenient, but can also lead to bugs if you're not careful!
        // personally - I advise a lot of caution with using static.
    }

    static class MyStaticClass
    {
        public static void MyStaticMethod()
        {
            Console.WriteLine("I am a static method!");
        }
    }

    class MyNonStaticClass
    {
        public string MyInstanceProperty { get; set; }

        public static string MyStaticProperty { get; set; }

        public static void MyStaticMethod()
        {
            Console.WriteLine($"The static property value is: {MyStaticProperty}");

            // this will not work because MyInstanceProperty is not static!
            //Console.WriteLine($"The instance property value is: {MyInstanceProperty}");
        }

        public void MyInstanceMethod()
        {
            Console.WriteLine($"The static property value is: {MyStaticProperty}");
            Console.WriteLine($"The instance property value is: {MyInstanceProperty}");
        }
    }
}


#endregion