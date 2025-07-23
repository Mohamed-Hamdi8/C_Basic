namespace Day03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q.1
            //1- Explain the difference between passing (Value type parameters) by value and by reference then write a suitable c# example.
            //int x = 5;
            //PassByValue(x);    // x will be changed but in function only
            //Console.WriteLine(x); //5
            //PassByValue(ref x); // x will be changed in function and in main because of ref keyword
            //Console.WriteLine(x); //10
            #endregion

            #region Q.2
            //2- Explain the difference between passing (Reference type parameters) by value and by reference then write a suitable c# example.
            //int[] Numbers = { 1, 2, 3, 4, 5 };
            //Console.WriteLine(SumOfArray(Numbers)); //in function we change the first element of array to 22 so the output will be 36
            //Console.WriteLine(Numbers[0]); //22 because we passed the array by value

            ////////////////////////////////////////////////
            //int[] Numbers2 = { 1, 2, 3, 4, 5 };
            //Console.WriteLine(SumOfArray(ref Numbers2)); //in function we change the first element of array to 99 so the output will be 113
            //Console.WriteLine(Numbers2[0]); //99 because we passed the array by reference

            #endregion

            #region Q.3
            //3- Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers
            //int a = 5, b = 3, sum, sub;
            //SumAndSub(a, b, out sum, out sub);
            //Console.WriteLine(sum);
            //Console.WriteLine(sub);
            #endregion

            #region Q.4
            //4- Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number.
            //Console.Write("Enter The Number : ");
            //int num = int.Parse(Console.ReadLine());
            //Console.WriteLine($"The Sum Of Digits Of [{num}] = {SumOfDigits(num)}");
            #endregion

            #region Q.5
            //5- Create a function named "IsPrime", which receives an integer number and retuns true if it is prime, or false if it is not:
            //Console.Write("Enter The Number : ");
            //int num = int.Parse(Console.ReadLine());
            //if (IsPrime(num))
            //{
            //    Console.WriteLine("The Number is Prime");
            //}
            //else
            //{
            //    Console.WriteLine("The Number is not Prime");
            //}
            #endregion

            #region Q.6
            //6- Create a function named MinMaxArray, to return the minimum and maximum values stored in an array, using reference parameters
            //int[] Arr = { 1, 2, 3, 4, 5 };
            //MinMaxArray(Arr, out int min, out int max);
            //Console.WriteLine(min);
            //Console.WriteLine(max);
            #endregion

            #region Q.7
            //Console.Write("Enter The Number : ");
            //int num = int.Parse(Console.ReadLine());
            //Console.WriteLine($"The Factorial Of [{num}] = {fac(num)}");
            #endregion

            #region Q.8
            //8 - Create a function named "ChangeChar" to modify a letter in a certain position(0 based) of a string, replacing it with a different letter
            Console.WriteLine("Enter the String Wan't Reblace (0 based) :  ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the Letter Wan't Reblace :  ");
            char letter = char.Parse(Console.ReadLine());
            Console.WriteLine(ChangeChar(name, letter));
            #endregion
        }
        #region Methods
        public static void PassByValue(int x)
        {
            x = 10;
        }
        public static void PassByValue(ref int x)
        {
            x = 10;
        }
        public static int SumOfArray(int[] Arr)
        {
            int sum = 0;
            Arr[0] = 22;
            for (int i = 0; i < Arr.Length; i++)
            {
                sum += Arr[i];
            }
            return sum;
        }
        public static int SumOfArray(ref int[] Arr)
        {
            int sum = 0;
            Arr[0] = 99;
            for (int i = 0; i < Arr.Length; i++)
            {
                sum += Arr[i];
            }
            return sum;
        }
        public static void SumAndSub(int x, int y, out int sum, out int sub)
        {
            sum = x + y;
            sub = x - y;
        }
        public static int SumOfDigits(int num)
        {
            int sum = 0;
            while (num != 0)
            {
                sum += num % 10;
                num /= 10;
            }
            return sum;
        }
        public static bool IsPrime(int x)
        {
            if (x == 1)
                return false;
            for (int i = 2; i <= Math.Sqrt(x); i++)
            {
                if (x % i == 0)
                    return false;
            }
            return true;
        }
        public static void MinMaxArray(int[] Arr, out int min, out int max)
        {
            min = Arr[0];
            max = Arr[0];
            for (int i = 0; i < Arr.Length; i++)
            {
                if (Arr[i] < min)
                    min = Arr[i];
                if (Arr[i] > max)
                    max = Arr[i];
            }
        }
        public static int fac(int x)
        {
            int fac = 1;
            if (x == 1)
                return 1;
            for (int i = x; i > 1; i--)
            {
                fac *= i;
            }
            return fac;
        }
        public static string ChangeChar(string name, char letter)
        {
            char[] letters = name.ToCharArray();
            letters[0] = letter;
            return new string(letters);
        } 
        #endregion
    }
}

