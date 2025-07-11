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

            #region 6- Write C# program that Assigning one reference type variable to another and modifying the object through one variable and mention what will happen
            //Point p1 = new Point() ;
            //p1.X = 5;

            //Point p2 = p1;

            //p2.X = 100;              

            //Console.WriteLine("p1.X = " + p1.X);  // Output: 100 , because P2 It has become a sign of P1 and any modify on P2 will affect on P1
            //Console.WriteLine("p2.X = " + p2.X);  // Output: 100
            #endregion

            #region 7-Write C# program that take two string variables and print them as one variable
            //string firstName = "Mohamed";
            //string lastName = "Hamdi";

            //string fullName01 = string.Format("{0} {1}", firstName, lastName);
            //string fullName02 = firstName + " " + lastName;
            //string fullName03 = $"{firstName} {lastName}"; //Best Practise

            //Console.WriteLine("Full Name: " + fullName01);
            //Console.WriteLine("Full Name: " + fullName02);
            //Console.WriteLine("Full Name: " + fullName03);
            #endregion

            #region 8- Write a program that calculates the simple interest given the principal amount, rate of interest, and time. 
            //double principal;
            //double rate;
            //double time;
            //bool flag;
            //do
            //{
            //    Console.Write("Enter principal amount :  ");
            //    flag = double.TryParse(Console.ReadLine(), out principal );
            //} while (!flag || principal < 0 );
            //do
            //{
            //    Console.Write("Enter rate of interest :  ");
            //    flag = double.TryParse(Console.ReadLine(), out rate);
            //} while (!flag);
            //do
            //{
            //    Console.Write("Enter time [ number of Years] :  ");
            //    flag = double.TryParse(Console.ReadLine(), out time);
            //} while (!flag);
            //double SimpleInterest = (principal * rate * time) / 100;
            //Console.WriteLine($"\nSimple Interest = {SimpleInterest:f3}");
            #endregion

            #region 9- Write a program that calculates the Body Mass Index (BMI) given a person's weight in kilograms and height in meters. 
            //double weight;
            //double height;
            //bool parsed;
            //do
            //{
            //    Console.Write("Enter Your Weight [Kg] : ");
            //    parsed = double.TryParse(Console.ReadLine(), out weight);
            //}while (!parsed || weight < 0);
            //do
            //{
            //    Console.Write("Enter Your Height [Metre] : ");
            //    parsed = double.TryParse(Console.ReadLine(), out height);
            //} while (!parsed || height < 0);

            //double BMI = weight/(height * height);
            //Console.WriteLine($"BMI = {BMI:f2}");
            #endregion
        }
        class Point
        {
            public int X;
            public int Y;
        }

    }
}
