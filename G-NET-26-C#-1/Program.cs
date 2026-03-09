using System.Buffers.Text;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Numerics;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;
using System.Security.Cryptography;
using System.Timers;
using System.Xml.Linq;
using static System.Formats.Asn1.AsnWriter;
using static System.Net.Mime.MediaTypeNames;
using static System.Net.WebRequestMethods;
using static System.Reflection.Metadata.BlobBuilder;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace G_NET_26_C__1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1: Regions
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 2: REGIONS
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: What is the purpose of #region and #endregion directives in C#? 
            //-- Organize code into groups.
            // 
            //    How do they help in code organization?
            //--making large code files easier to navigate and maintain.
            //
            // ══════════════════════════════════════════════════════════════════════

            //Nested Region Example

            #endregion

            #region Question 2: Variable Declaration - Explicit vs Implicit
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 3: VARIABLE DECLARATION - EXPLICIT VS IMPLICIT
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: What is the difference between explicit and implicit variable 
            //    declaration in C#? Provide examples of both.
            //
            // ══════════════════════════════════════════════════════════════════════



            // EXPLICIT DECLARATION 
            //*int, string
            //*Can be declared without a value.
            //* must know the type beforehand.
            //* int age = 20;
            //string name = "Gehad";

            // IMPLICIT DECLARATION 
            //*var
            //*Must be assigned a value immediately.
            //* Its type cannot be changed later.
            //* The compiler handles the type Based on the value we place.
            //* var num = 10;
            //var message = "Hello";


            #endregion

            #region Question 3: Constants
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 4: CONSTANTS
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: Write the syntax for declaring a constant in C#. Why would you use 
            //    a constant instead of a regular variable?
            //
            // ══════════════════════════════════════════════════════════════════════
            //*To ensure that value It will never change while the program is running.
            //* Improved performance as the compiler places the value directly, making it faster.

            // Constant examples
            //const double Pi = 3.14159;

            #endregion

            #region Question 4: Class-level vs Method-level Scope
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 4: CLASS-LEVEL VS METHOD-LEVEL SCOPE
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: Explain the difference between class-level scope and method-level 
            //    scope with examples.
            //
            // ══════════════════════════════════════════════════════════════════════
            //    class-level scope:
            //    *Variables declared at this level are known as Fields.
            //    * accessible from anywhere within the class
            //    *These variables live as long as the object (instance) exists in memory
            //Example 
            //    class MyClass
            //{
            //    private int _classLevel = 1;
            //    public void MethodA()
            //    {
            //        Console.WriteLine(_classLevel);
            //    }
            //}



            // method - level scope:"Local Variables"
            //*Variables declared inside a method (including parameters).
            //*only visible and accessible within that specific method.
            //* lifetime is short; they are created when the method is called and destroyed when the method returns.
            //Example 
            //public void MyMethod(int param)
            //  {
            //      int methodLevel = 2;
            //    Console.WriteLine(methodLevel);
            //  }
            #endregion

            #region Question 5: Block-level Scope
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 5: BLOCK-LEVEL SCOPE
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: What is block-level scope? Give an example showing a variable that 
            //    is only accessible within a specific block.
            //
            // ══════════════════════════════════════════════════════════════════════
            //*refers to the visibility of a variable declared within a specific block of code
            //*if,for,while ,foreach
            //example
            //    public void MyMethod()
            //    {
            //        if (true)
            //        {
            //            int blockLevel = 4;
            //            Console.WriteLine(blockLevel);//Accessible 
            //        }
            //        Console.WriteLine(blockLevel);//doesn't here
            //    }
            #endregion

            #region Question 6: Variable Lifetime - Local vs Static
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 6: VARIABLE LIFETIME - LOCAL VS STATIC
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: What is variable lifetime? Explain the lifetime of local variables 
            //    vs static variables.
            //
            // ══════════════════════════════════════════════════════════════════════
            //*Lifetime is how long a variable exists in memory — from creation to destruction.

            //Local Variables:
            //*Created When the method where they are declared is called.
            //* Destroyed When the method returns(
            //Static Variables:
            //*Created When the App start.
            //*Destroyed When the App end.

            #endregion

            #region Question 7: Garbage Collector
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 7: GARBAGE COLLECTOR
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: What is the Garbage Collector in C#? How does it affect the 
            //    lifetime of objects?
            //
            // ══════════════════════════════════════════════════════════════════════
            //*Garbage Collector automatically removes objects from Heap when no references point to them.
            //*Making the object's life end as soon as it becomes inaccessible, thus preventing the accumulation of unused data and memory corruption.

            #endregion


            #region Question 8: Variable Shadowing
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 8: VARIABLE SHADOWING
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: What is variable shadowing in C#? Does C# allow shadowing in 
            //    nested blocks within the same method?
            //
            // ══════════════════════════════════════════════════════════════════════
            //*Shadowing occurs when a variable declared in an inner scope has the same name as one in an outer scope
            //    * No, It will happen a compile -time error
            //    *Can only shadow class-level fields with local variables.
            #endregion

            #region Question 9: C# Naming Rules
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 9: C# NAMING RULES
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: List five rules that must be followed when naming variables in C#.
            //
            // ══════════════════════════════════════════════════════════════════════

            //*Names must start with a letter or _(underscore).
            //* Can contain letters, digits, and underscores(no spaces).
            //* Avoid keywords
            //* Avoid unclear abbreviations
            //*case -sensitive: It varies from capital letter to small letter.


            #endregion

            #region Question 10: Naming Conventions
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 10: NAMING CONVENTIONS
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: What naming conventions are recommended for: (a) local variables, 
            //    (b) class names, (c) constants?
            //
            // ══════════════════════════════════════════════════════════════════════
            //(a)camelCase
            //(b)PascalCase
            //(c)PascalCase

            #endregion

            #region Question 11: Error Types
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 11: ERROR TYPES
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: Compare and contrast syntax errors, runtime errors, and logical 
            //    errors. Provide an example of each.
            //
            // ══════════════════════════════════════════════════════════════════════
            //syntax errors:
            //    *It happens when:Before running
            //    *Detected By: Compiler.
            //    * Program won't start
            //     example: Missing(;)
            //runtime errors:
            //    *It happens when:While runningز
            //    *Detected By: CLR / Exceptionز
            //    * Program crashes
            //     example:Divide by (0)
            //logical errors:
            //    *It happens when:After runningز
            //    *Detected By: Developer / Testing
            //* Wrong result
            //       example:(+)instead of (*)


            #endregion

            #region Question 12: Exception Handling Importance
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 12: EXCEPTION HANDLING IMPORTANCE
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: Why is exception handling important in C#? What would happen if 
            //    you don't handle exceptions?
            //
            // ══════════════════════════════════════════════════════════════════════
            //*allows a program to deal with unexpected runtime errors.
            //*Prevent application crash.
            //*Log details for debugging
            //**The program will terminate immediately and "die".

            #endregion

            #region Question 13: try-catch-finally
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 13: TRY-CATCH-FINALLY
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: Write a code example demonstrating try-catch-finally. Explain when 
            //    the finally block executes.
            //
            // ══════════════════════════════════════════════════════════════════════
            //**the finally block //executes always//,Even if the try block has a return statement, the finally block will still execute before the method finishes.
            #endregion

            #region Question 14: Common Built-in Exceptions
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 14: COMMON BUILT-IN EXCEPTIONS
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: List and explain five common built-in exceptions in C# with 
            //    scenarios when each would occur.
            //
            // ══════════════════════════════════════════════════════════════════════
            //NullReferenceException:
            //* MaybeNullWhenAttribute using null
            //FormatException:
            //* parsing with invalid format
            //DivideByZeroException:
            //*dividing int by 0
            //IndexOutOfRangeException:
            //* MarshalUsingAttribute invalid array index
            //FileNotFoundException:
            //*File does not exist



            #endregion

            #region Question 15: Multiple catch Blocks
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 15: MULTIPLE CATCH BLOCKS
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: Why is the order of catch blocks important when handling multiple 
            //    exceptions? Write code showing correct ordering.
            //
            // ══════════════════════════════════════════════════════════════════════
            //*it will "catch" every error, and the more specific catch blocks below it will never be reached.This results in a Compile-time error.
            //* *catch (FormatException) { }
            //  catch (ArgumentException) { }
            //  catch (Exception) { } // Last!
            #endregion

            #region Question 16: throw Keyword
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 16: THROW KEYWORD
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: What is the difference between 'throw' and 'throw ex' when 
            //    re-throwing an exception? Which one preserves the stack trace?
            //
            // ══════════════════════════════════════════════════════════════════════
            //throw: Keeps original location."preserves the stack trace"
            //throw ex :Loses original location.
            #endregion

            #region Question 17: Stack and Heap Memory
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 17: STACK AND HEAP MEMORY
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: Explain the differences between Stack and Heap memory in C#. 
            //    What types of data are stored in each?
            //
            // ══════════════════════════════════════════════════════════════════════
            //Stack:
            //    *Very Fast
            //    * Limited(~1MB)
            //    *Automatic
            //    * Local Variables
            //    *Method Parameters
            //    *Return Addresses
            //Heap:
            //*Slower
            //* Large(GBs)
            //* Garbage Collector.
            //* Objects(new)
            //*Arrays
            //*Strings


            #endregion

            #region Question 18: Value Types vs Reference Types
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 18: VALUE TYPES VS REFERENCE TYPES
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: Write a code example showing how value types and reference types 
            //    behave differently when assigned to another variable.
            //
            // ══════════════════════════════════════════════════════════════════════
            

        //int x = 10;
        //    int y = x; 
        //    y = 20;
        //    Console.WriteLine($" x = {x}, y = {y}");// x = 10, y = 20
        //    Point p1 = new Point() { Coordinates ="(5,5)" };
        //    Point p2 = p1;
        //    p2.Coordinates = "(4,4)";
        //    Console.WriteLine($" p1 = {p1.Coordinates}, p2 = {p2.Coordinates}");//p1 = (4, 4), p2 = (4, 4)
            #endregion
           
 
        }
       //* class Point { public string Coordinates; }
    }
}
