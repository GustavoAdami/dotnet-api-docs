﻿// <Snippet1>
using System;
using System.Reflection;
using System.Security;

public class MyClass2
{
    public MyClass2(int i) { }
    public static void Main()
    {
        try
        {
            Type myType = typeof(MyClass2);
            Type[] types = new Type[1];
            types[0] = typeof(int);
            // Get the constructor that is public and takes an integer parameter.
            ConstructorInfo constructorInfoObj = myType.GetConstructor(
                BindingFlags.Instance | BindingFlags.Public, null, types, null);
            if (constructorInfoObj != null)
            {
                Console.WriteLine("The constructor of MyClass2 that is public " +
                    "and takes an integer as a parameter is:");
                Console.WriteLine(constructorInfoObj.ToString());
            }
            else
            {
                Console.WriteLine("The constructor of the MyClass2 that is public " +
                    "and takes an integer as a parameter is not available.");
            }
        }
        catch (ArgumentNullException e)
        {
            Console.WriteLine("ArgumentNullException: " + e.Message);
        }
        catch (ArgumentException e)
        {
            Console.WriteLine("ArgumentException: " + e.Message);
        }
        catch (SecurityException e)
        {
            Console.WriteLine("SecurityException: " + e.Message);
        }
        catch (Exception e)
        {
            Console.WriteLine("Exception: " + e.Message);
        }
    }
}
// </Snippet1>
