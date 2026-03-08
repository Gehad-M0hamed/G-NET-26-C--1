using System.Buffers.Text;
using System.Diagnostics.Metrics;
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



        }
    }
}
