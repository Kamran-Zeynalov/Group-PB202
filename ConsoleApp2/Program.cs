namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region 18.10

            //int num = 5;
            //if (num > 0)
            //{
            //    Console.WriteLine("Musbetdir");
            //}
            //else if(num == 0)
            //{
            //    Console.WriteLine("0 -dir ");
            //}
            //else
            //{
            //    Console.WriteLine("Menfidir");
            //}


            //int num = 5;
            //int res = 1;

            //for (int i = 1; i <= num; i++)
            //{
            //    res *= i;

            //}
            //Console.WriteLine("5!: " + res);



            //Start:
            //    Console.WriteLine("Enter Number: ");
            //    int num = Int32.Parse(Console.ReadLine());
            //    if (num >= 90 && num <= 100)
            //    {
            //        Console.WriteLine("A");
            //    }
            //    else if (num >= 80 && num <= 89)
            //    {
            //        Console.WriteLine("B");
            //    }
            //    else if (num >= 70 && num <= 79)
            //    {
            //        Console.WriteLine("C");
            //    }
            //    else if (num >= 60 && num <= 69)
            //    {
            //        Console.WriteLine("D");
            //    }
            //    else if (num < 0 || num > 100)
            //    {
            //        Console.WriteLine("Choose another number");
            //        goto Start;
            //    }
            //    else
            //    {
            //        Console.WriteLine("F");
            //    }




            //int num = 5;
            //int num1 = 25;
            //int num2 = 25;

            //if ((num > num2) && (num > num1))
            //{
            //    Console.WriteLine(num + $" - {num1} ve {num2}-den boyukdur");
            //}
            //else if(num1 > num && num1 > num2)
            //{
            //    Console.WriteLine(num1 + $" - {num} ve {num2}-den boyukdur");
            //}
            //else if(num2 > num && num2 > num1)
            //{
            //    Console.WriteLine(num2 + $" - {num1} ve {num}-dan boyukdur");
            //}
            //else
            //{
            //    Console.WriteLine("Ededlerden Her hansisa Berarberdir");
            //}





            //int num = 123888;
            //int count = 0;
            //while (num > 0) 
            //{
            //    num /= 10;
            //    count++;
            //}
            //Console.WriteLine("Ededin mertebei: " + count + " - qederdir");


            //int a = 0;
            //int b = 1;
            //int nextNum = 0;
            //Console.Write(a +", " + b + ", ");


            //for (int i = 99; i > nextNum;) {


            //    nextNum = a + b;
            //    a = b;
            //    b = nextNum;

            //    if(nextNum > 99)
            //    {
            //        break;
            //    }

            //    Console.Write(nextNum + ", ");
            //}


            //int num = 8;
            //while (num % 2 == 0)
            //{
            //    num /= 2;
            //}
            //if(num == 1)
            //    Console.WriteLine("Quvvetidir");
            //else
            //    Console.WriteLine("Quvveti deyil");

            #endregion

            #region 25.10
            //int[] arr = { 3, 54, 12, 100, 43, 12 };
            //Array.Sort(arr);


            //int result = BinarySearch(arr, 43);

            //if(result == -1)
            //{
            //    Console.WriteLine("Index Not Found");
            //}
            //else
            //{
            //    Console.WriteLine($"Index: {result}");
            //}

            //string elifba = "";

            //string sentence = "salamn code academy";

            //foreach (char i in sentence) { 

            //    if(elifba.Contains(i))
            //    {

            //    }
            //}




           // Console.WriteLine(AddNum(534));
            #endregion
        }

        public static int BinarySearch(int[] arr, int search)
        {
            int firstValue = 0;
            int lastValue = arr.Length - 1;

            while (firstValue <= lastValue)
            {
                int midValue = (lastValue + firstValue) / 2;

                if (arr[midValue] == search)
                {
                    return midValue;
                }

                if (arr[midValue] < search)
                {
                    firstValue = midValue + 1;
                }
                else
                {
                    lastValue = midValue - 1;
                }
            }
            return -1;
        }




        public static int AddNum(int number)
        {
            int digits = 1;
            int number2 = number;
            while (number2 > 0)
            {
                digits *= 10;//10
                number2 /= 10; //52

            }

            return 3* digits + number;
        }


    }
}
