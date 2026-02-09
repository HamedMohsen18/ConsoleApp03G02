using System;

namespace CSharpAssignment
{
    class Program
    {
        // Class-level field
        static int classField = 100;

        static void Main(string[] args)
        {
            Console.WriteLine("C# Fundamentals Assignment – Solved");

            #region Question 1: Regions
            // #region and #endregion are used to organize code
            // They allow collapsing and expanding code sections in the IDE
            #endregion

            #region Question 2: Variable Declaration - Explicit vs Implicit
            // Explicit declaration
            int x = 10;

            // Implicit declaration
            var y = 20;
            #endregion

            #region Question 3: Constants
            // Constants are declared using the const keyword
            const double PI = 3.14;
            // Constants are used when values should not change
            #endregion

            #region Question 4: Class-level vs Method-level Scope
            // classField is accessible throughout the class
            MethodScopeExample();
            #endregion

            #region Question 5: Block-level Scope
            if (true)
            {
                int blockVariable = 10;
                Console.WriteLine(blockVariable);
            }
            // blockVariable is not accessible here
            #endregion

            #region Question 6: Variable Lifetime - Local vs Static
            // Local variables live during method execution
            // Static variables live for the lifetime of the application
            #endregion

            #region Question 7: Garbage Collector
            // Garbage Collector automatically frees memory
            // by removing unreferenced objects
            #endregion

            #region Question 8: Variable Shadowing
            int value = 5;
            {
                int valueShadow = 10; // Shadowing example
                Console.WriteLine(valueShadow);
            }
            #endregion

            #region Question 9: C# Naming Rules
            // 1. Must start with letter or underscore
            // 2. Cannot start with number
            // 3. Cannot use reserved keywords
            // 4. Case-sensitive
            // 5. No spaces allowed
            #endregion

            #region Question 10: Naming Conventions
            // Local variables: camelCase
            // Class names: PascalCase
            // Constants: PascalCase
            #endregion

            #region Question 11: Error Types
            // Syntax Error: detected at compile time
            // Runtime Error: occurs while program runs
            // Logical Error: program runs but gives wrong output
            #endregion

            #region Question 12: Exception Handling Importance
            // Exception handling prevents program crashes
            // and allows graceful error recovery
            #endregion

            #region Question 13: try-catch-finally
            try
            {
                int result = 10 / 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Finally block always executes");
            }
            #endregion

            #region Question 14: Common Built-in Exceptions
            // NullReferenceException
            // DivideByZeroException
            // IndexOutOfRangeException
            // FormatException
            // InvalidCastException
            #endregion

            #region Question 15: Multiple catch Blocks
            try
            {
                int[] arr = new int[2];
                Console.WriteLine(arr[5]);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            #endregion

            #region Question 16: throw vs throw ex
            // throw; preserves stack trace
            // throw ex; resets stack trace
            #endregion

            #region Question 17: Stack and Heap Memory
            // Stack stores value types and local variables
            // Heap stores reference types and objects
            #endregion

            #region Question 18: Value Types vs Reference Types
            int a = 5;
            int b = a;
            b = 10;

            int[] arr1 = { 1, 2 };
            int[] arr2 = arr1;
            arr2[0] = 9;
            #endregion

            #region Question 19: Object in C#
            // object is the base type of all types in C#
            // Common methods: ToString(), Equals(), GetHashCode(), GetType()
            #endregion
        }

        static void MethodScopeExample()
        {
            int localValue = 50;
            Console.WriteLine(classField + localValue);
        }
    }
}
