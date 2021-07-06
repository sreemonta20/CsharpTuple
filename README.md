Often, we want to return more than one value from a class method. Prior to the introduction of tuples in .NET, there were three common ways to do so. 
Out parameters
Class or struct types
Anonymous types returned through a dynamic return type 
Tuples solve this problem. Tuples aren’t new to C# or .NET. Tuples were first introduced as a part of .NET Framework 4.0.
 
A C# tuple is a data structure that provides an easy way to represent a single set of data. The System.Tuple class provides static methods to create tuple objects.
 
Tuples allow us to,
Create, access, and manipulate a data set
Return a data set from a method without using out parameter
Pass multiple values to a method through a single parameter 
