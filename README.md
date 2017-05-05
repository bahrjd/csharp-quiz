# C# QUIZ

- What is an interface?
A contract
- What is polymorphism?  Describe an example?
Polymorphism is the ability of a class to accept multiple data types with different implementations or behaviors
- What is the difference between a class and an object?
A class is a blueprint or instructions for creating an object where an object is an instantiation of a class
- What are the four pillars of OOP?
The four pillars of object-oriented programming are: Inheritance, Encapsulation, Abstraction, and Polymorphism
- What is an abstract class?
An abstract class is one that cannot be instantiated and may or may not have implementations
- What is the difference between an abstract class and an interface?
An interface contains signatures, but no implementations. An abstract class may contain implementations, but neither may be instantiated.
- TRUE or FALSE: an abstract class can be instantiated?
FALSE
- TRUE or FALSE: an abstract class can have a constructor?
TRUE
- Is a string a value type or a reference type?  
REFERENCE TYPE
- What is the package management system used in Visual Studio?
Visual Studio uses the NuGet package manager
- After the following method executes and is completed what will be the value of the Name property of the Employee parameter object?
Harry Potter

````

public static void UpdateEmployee(Employee employee)
{
    employee.Name = "Harry Potter";
}

````

- Will the Employee parameter object in the following method become null after the method executes and is completed?  Why or why not?
No, it's not setting a property of the Employee class
````

public static void NullEmployee(Employee employee)
{
    employee = null;
}

````

- Create a class named Employee with the properties to hold the following info:
  - first name
  - last name
  - hire date
  - email

- Create an Employee object from the class defined above.  Give this object the following information:
  - first name: Harry
  - last name: Potter
  - hire date: 1/1/2015
  - email: harry.potter@gmail.com

- Take the Employee class created from the previous example and override the ToString() method to return a string representation of the properties.  Use string interpolation.

- Create a static method on the Employee class named CloneEmployee that takes an Employee object as a parameter and returns a deep copy.

- Create a method on the Employee class that returns the number of days an employee has been employed.

- Create a list of Employee objects.  Add three Employee objects to the list.  Iterate over the list of objects and call each object's ToString() method on each iteration.
