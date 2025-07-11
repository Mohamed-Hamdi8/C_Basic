namespace Day01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1- Write a program that allows the user to enter a number then print it.
            //bool Parsed;
            //do
            //{
            //    Console.Write("Enter Number Plz : ");
            //    Parsed = int.TryParse(Console.ReadLine(), out int Num);
            //} while (!Parsed);
            #endregion

            #region 2- Write C# program that converts a string to an integer, but the string contains non-numeric characters. And mention what will happen
            //try
            //{
            //    string Name = "Mohamed";
            //    int X = int.Parse(Name);
            //    Console.WriteLine(X); //Will create obj from class Exception(throw exception)  --> System.FormatException {The input string 'Mohamed' was not in a correct format}.
            //                          //Run Time Error
            //}
            //catch (Exception ex) 
            //{
            //    Console.WriteLine("Error: " + ex.Message);
            //}
            #endregion

            #region 3- Write C# program that Perform a simple arithmetic operation with floating-point numbers And mention what will happen
            //float Num01 = 10.5f;
            //float Num02 = 3.2f;

            //float result = Num01 / Num02;

            //Console.WriteLine("Result of division: " + result); //nothing will happen its simple operation

            #endregion

            #region 4-Write C# program that Extract a substring from a given string.
            //string Name = "Mohamed";
            ////Extruct hamed
            //for (int i = 2; i < Name.Length; i++)
            //{
            //    Console.Write(Name[i]);
            //}
            ////or
            //Console.WriteLine(Name.Substring(2, 5));

            #endregion

            #region 5- Write C# program that Assigning one value type variable to another and modifying the value of one variable and mention what will happen
            //int A = 10;  
            //int B = A;       

            //B = 20;          // Change the value of 'b' to 20

            //Console.WriteLine("Value of a: " + A);  // Output: 10 not changed becuase it's value type
            //Console.WriteLine("Value of b: " + B);  // Output: 20
            #endregion
        }
    }
}
