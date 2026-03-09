using System.Buffers.Text;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Timers;
using System.Xml.Linq;
using static System.Formats.Asn1.AsnWriter;
using static System.Net.WebRequestMethods;
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

        }
    }
}
