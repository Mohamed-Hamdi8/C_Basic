namespace Day02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1- Write a program that allows the user to insert an integer then print all numbers between 1 to that number.
            //bool parsed;
            //int number;
            //do
            //{
            //    Console.Write("Enter Number : ");
            //    parsed = int.TryParse(Console.ReadLine(), out number);
            //} while (!parsed);
            //for( int i = 1; i <= number;i++)
            //{
            //    Console.Write($"{i} ");
            //}
            #endregion

            #region 2- Write a program that allows the user to insert an integer then print a multiplication table up to 12.
            //bool parsed;
            //int number;
            //do
            //{
            //    Console.Write("Enter Number : ");
            //    parsed = int.TryParse(Console.ReadLine(), out number);
            //} while (!parsed);
            //int Multi = 0;
            //for(int i = 0; i < 12; i++)
            //{
            //    Multi += number;
            //    Console.Write($"{Multi} ");
            //}
            #endregion

            #region 3- Write a program that allows to user to insert number then print all even numbers between 1 to this number
            //bool parsed;
            //int number;
            //do
            //{
            //    Console.Write("Enter Number : ");
            //    parsed = int.TryParse(Console.ReadLine(), out number);
            //} while (!parsed);
            //for(int i = 2; i <= number; i++)
            //{
            //    if(i%2==0)
            //    Console.Write($"{i} ");
            //}
            #endregion

            #region 4- Write a program that takes two integers then prints the power.
            //bool parsed;
            //int number;
            //int power;
            //do
            //{
            //    Console.Write("Enter Number : ");
            //    parsed = int.TryParse(Console.ReadLine(), out number);
            //} while (!parsed);
            //do
            //{
            //    Console.Write("Enter power : ");
            //    parsed = int.TryParse(Console.ReadLine(), out power);
            //} while (!parsed);
            //int result = 1 ;
            //for(int i = 0; i< power; i++)
            //{
            //    result *= number;
            //}
            //    Console.WriteLine(result);
            #endregion

            #region 5- Write a program to enter marks of five subjects and calculate total, average and percentage.
            //bool parsed;
            //int mark01;
            //int mark02;
            //int mark03;
            //int mark04;
            //int mark05;
            //do
            //{
            //    Console.Write("Enter Mark Of Subjec01 : ");
            //    parsed = int.TryParse(Console.ReadLine(), out mark01);
            //} while (!parsed);
            //do
            //{
            //    Console.Write("Enter Mark Of Subjec02 : ");
            //    parsed = int.TryParse(Console.ReadLine(), out mark02);
            //} while (!parsed);
            //do
            //{
            //    Console.Write("Enter Mark Of Subjec03 : ");
            //    parsed = int.TryParse(Console.ReadLine(), out mark03);
            //} while (!parsed);
            //do
            //{
            //    Console.Write("Enter Mark Of Subjec04 : ");
            //    parsed = int.TryParse(Console.ReadLine(), out mark04);
            //} while (!parsed);
            //do
            //{
            //    Console.Write("Enter Mark Of Subjec05 : ");
            //    parsed = int.TryParse(Console.ReadLine(), out mark05);
            //} while (!parsed);

            //double SubjectMarkTotal = mark01 + mark02 + mark03 + mark04 + mark05;
            //double SubjectAvarage = SubjectMarkTotal / 5;
            //double SubjectPercentage = (SubjectMarkTotal/500) * 100;

            //Console.WriteLine($"Total Marks = {SubjectMarkTotal} \n" +
            //    $"Avarage = {SubjectAvarage} \n" +
            //    $"Percentage = {SubjectPercentage}%");
            #endregion

            #region 6- Write a program to allow the user to enter a string and print the REVERSE of it.
            //Console.Write("Enter Your Name : ");
            //string Name = Console.ReadLine();
            //for(int i = Name.Length-1; i >= 0; i--)
            //{
            //    Console.Write($"{Name[i]} ");
            //}
            #endregion

            #region 7- Write a program to allow the user to enter int and print the REVERSED of it.
            //bool parsed;
            //int number;
            //do
            //{
            //    Console.Write("Enter Number : ");
            //    parsed = int.TryParse(Console.ReadLine(), out number);
            //} while (!parsed);
            //string NumbersChar = number.ToString();
            //for (int i = NumbersChar.Length - 1; i >= 0; i--)
            //{
            //    Console.Write($"{NumbersChar[i]} ");
            //}
            #endregion

            #region 8- Write a program in C# Sharp to find prime numbers within a range of numbers.
            //bool parsed;
            //int StartNum;
            //int EndNum;
            //do
            //{
            //    Console.Write("Enter starting number of ranges : ");
            //    parsed = int.TryParse(Console.ReadLine(), out StartNum);
            //} while (!parsed || StartNum < 0);
            //do
            //{
            //    Console.Write("Enter ending number of ranges : ");
            //    parsed = int.TryParse(Console.ReadLine(), out EndNum);
            //} while (!parsed || EndNum < 0);
            //for (int i = StartNum; i <= EndNum; i++)
            //{
            //    {
            //        if (IsPrime(i))
            //        Console.Write($"{i} ");
            //    }
            //}
            #endregion

            #region 9-   Write a program in C# Sharp to convert a decimal number into binary without using an array.
            //bool parsed;
            //int DecimalNumber;
            //do
            //{
            //    Console.Write("Enter Decimal Number : ");
            //    parsed = int.TryParse(Console.ReadLine(), out DecimalNumber);
            //} while (!parsed || DecimalNumber <=0);
            //string binary = "";

            //while (DecimalNumber > 0)
            //{
            //    int remainder = DecimalNumber % 2;
            //    binary = remainder + binary;
            //    DecimalNumber /= 2;
            //}

            //Console.WriteLine("Binary: " + binary);
            #endregion

            #region 10- Create a program that asks the user to input three points (x1, y1), (x2, y2), and (x3, y3), and determines whether these points lie on a single straight line.
            //Console.WriteLine("Enter coordinates for Point 1 (x1 y1): ");
            //Console.Write("x1 : ");
            //double x1 = double.Parse(Console.ReadLine());
            //Console.Write("y1 : ");
            //double y1 = double.Parse(Console.ReadLine());

            //Console.WriteLine("Enter coordinates for Point 2 (x2 y2): ");
            //Console.Write("x2 : ");
            //double x2 = double.Parse(Console.ReadLine());
            //Console.Write("y2 : ");
            //double y2 = double.Parse(Console.ReadLine());

            //Console.WriteLine("Enter coordinates for Point 3 (x3 y3): ");
            //Console.Write("x3 : ");
            //double x3 = double.Parse(Console.ReadLine());
            //Console.Write("y3 : ");
            //double y3 = double.Parse(Console.ReadLine());

            //double tendencyA = (y2 - y1) / (x2 - x1);
            //double tendencyB = (y3 - y2) / (x3 - x2);

            //if (tendencyA == tendencyB)
            //    Console.WriteLine("these points lie on a single straight line.");
            //else
            //    Console.WriteLine("these points not lie on a single straight line.");
            #endregion

            #region 11-  Write a program that prints an identity matrix using for loop, in other words takes a value n from the user and shows the identity table of size n * n.
            //bool parsed;
            //int n;
            //do
            //{
            //    Console.Write("Enter the size of the identity matrix (n): ");
            //    parsed = int.TryParse(Console.ReadLine(), out n);
            //} while (!parsed || n<0);

            //Console.WriteLine($"\nIdentity matrix of size {n} x {n}:\n");

            //for (int row = 0; row < n; row++)
            //{
            //    for (int col = 0; col < n; col++)
            //    {
            //        if (row == col)
            //            Console.Write("1 ");
            //        else
            //            Console.Write("0 ");
            //    }
            //    Console.WriteLine();
            //}
            #endregion
        }
    }
}
