using System.Text;

namespace Assigmnment_02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region String Formating
            //// String Formating
            //// Equation : X + Y = 12

            //int x = 5;
            //int y = 7;

            //// String Concatenation
            //string Message = "Equation : " + x + " + " + y + " = " + (x + y);
            //Console.WriteLine(Message);
            //// String : Immutable => Once created, cannot be changed

            //// String Formating
            //string Message2 = string.Format("Equation : {0} + {1} = {2}", x, y, x + y);
            //Console.WriteLine(Message2);

            //// String Interpolation

            //string Message3 = $"Equation : {x} + {y} = {x + y}";
            //Console.WriteLine(Message3); 
            #endregion


            #region Controle Statements
            // Control Statements
            // 1. Conditional Statements
            // 2. Looping Statements
            // 3. Jump Statements

            // Conditional Statements

            //Console.WriteLine("Enter the number of month in the 1st quarter: ");
            //int month = int.Parse(Console.ReadLine());

            //if (month == 1)
            //{
            //    Console.WriteLine("Jan");
            //}
            //else if (month == 2)
            //{
            //    Console.WriteLine("Feb");

            //}
            //else if (month == 3)
            //{
            //    Console.WriteLine("Mar");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid Month");
            //}

            //// Switch Case

            //Console.WriteLine("Enter number of month in the 1st quarter");
            //month = int.Parse(Console.ReadLine());
            //switch (month)
            //{
            //    case 1:
            //        Console.WriteLine("Jan");
            //        break;
            //    case 2:
            //        Console.WriteLine("Feb");
            //        break;
            //    case 3:
            //        Console.WriteLine("Mar");
            //        break;
            //    default:
            //        Console.WriteLine("Invalid Month");
            //        break;
            //}

            //Console.WriteLine("Enter name");
            //string name = Console.ReadLine();
            //if (name == "Ali" || name == "ali")
            //{
            //    Console.WriteLine("Hello Ali");
            //}
            //else if (name == "Ahmed")
            //{
            //    Console.WriteLine("Hello Ahmed");
            //}
            //else
            //{
            //    Console.WriteLine("Hello Stranger");
            //}

            //Console.WriteLine("Enter ur age: ");
            //int age = int.Parse(Console.ReadLine());
            //if (age >= 18)
            //{
            //    Console.WriteLine("Welcome");
            //}
            //else if (age < 18)
            //{
            //    Console.WriteLine("Bye bye ");
            //}
            //else
            //{
            //    Console.WriteLine("equel");
            //}

            //switch(age)
            //{
            //    case > 18:
            //        Console.WriteLine("Welcome");
            //        break;
            //    case < 18:
            //        Console.WriteLine("bye bye");
            //        break;
            //    default:
            //        Console.WriteLine("equel");
            //        break;
            //}

            //// Dot Net 8
            //string input = Console.ReadLine();

            //string output = input switch
            //{
            //    "1" => "Hello Ali",
            //    "2" => "Hello Ahmed",
            //    _ => "Hello Stranger"
            //};


            // Looping Statements

            // 1. For Loop
            // 2. While Loop
            // 3. Do While Loop
            // 4. For Each Loop

            // For Loop
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("Hello World");
            //}

            //// foreach loop
            //int[] numbers = { 1, 2, 3, 4, 5 };
            //for (int i = 0; i < numbers.Length; i++) {
            //    Console.WriteLine(numbers[i]);
            //}

            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            // While Loop
            //while (true)
            //{
            //    Console.WriteLine("Hello world");
            //}

            //int i = 1;
            //while (i <= 10)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            // Do While Loop
            //int i = 11;
            //do
            //{
            //    Console.WriteLine(i);
            //    i++;
            //} while (i <= 10); 
            #endregion

            #region Sting Builder
            //// String Builder : Class
            //// Mutable : Can be changed
            //StringBuilder S01;
            //// declare for reference from type StringBuilder
            ////s01 can refer to an object of type StringBuilder
            //// s01 refer to null

            //S01 = new StringBuilder("Ahmed");
            //// new
            //// allocate number of required bytes for the object at the heap
            //// initialize the object with the default values
            //// call user-defined constructor if exists
            //// assign the object to the reference

            //Console.WriteLine(S01);
            //S01.Append(" Ali"); 
            #endregion

            #region String Methods
            // String Methods
            //string S01 = "Hello World";
            //S01.Substring(1);
            //S01.Replace("Hello", "Hi");
            //S01.StartsWith("H", false, null);
            //S01.EndsWith("d", false, null);
            //S01.Contains("W");
            //S01.ToCharArray();
            //S01.CompareTo("Hello"); 
            #endregion


            #region Q1
            //Console.WriteLine("Enter number: ");
            //int number;
            //bool flag = int.TryParse(Console.ReadLine(), out number);
            //if (flag == true)
            //{
            //    if (number % 3 == 0 && number % 4 == 0)
            //    {
            //        Console.WriteLine("Yes");
            //    }
            //    else
            //    {
            //        Console.WriteLine("No");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input");
            //}

            #endregion

            #region Q2
            //Console.WriteLine("Enter number : ");
            //int number;
            //bool flag = int.TryParse(Console.ReadLine(), out number);
            //if (flag == true)
            //{
            //    if (number < 0)
            //    {
            //        Console.WriteLine("negative");
            //        Console.WriteLine(flag);
            //    }
            //    else
            //    {
            //        Console.WriteLine("positive");
            //        Console.WriteLine(flag);
            //    }

            //}
            //else
            //{
            //    Console.WriteLine("Invalid input");

            //} 
            #endregion

            #region Q3
            //Console.WriteLine("Enter 3 nums");
            //int num1, num2, num3;
            //bool flag1 = int.TryParse(Console.ReadLine(), out num1);
            //bool flag2 = int.TryParse(Console.ReadLine(), out num2);
            //bool flag3 = int.TryParse(Console.ReadLine(), out num3);

            //if (flag1 && flag2 && flag3)
            //{
            //    int min = Math.Min(num1, Math.Min(num2, num3));
            //    int max = Math.Max(num1, Math.Max(num2, num3));
            //    Console.WriteLine($"min num is : {min}");
            //    Console.WriteLine($"max num is : {max}");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input");
            //} 
            #endregion

            #region Q4
            //Console.WriteLine("Enter number: ");
            //int num;
            //bool flag = int.TryParse(Console.ReadLine(), out num);
            //if (flag)
            //{
            //    if (num % 2 == 0)
            //    {
            //        Console.WriteLine("even");
            //    }
            //    else
            //    {
            //        Console.WriteLine("odd");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input");
            //} 
            #endregion

            #region Q5
            //Console.WriteLine("Enter char");
            //string character = Console.ReadLine();

            //if ("aeiou".Contains(character))
            //{
            //    Console.WriteLine("vowel");
            //}
            //else if ("bcdfghjklmnpqrstvwxyz".Contains(character))
            //{
            //    Console.WriteLine("consonant");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input");
            //} 
            #endregion

            #region Q6
            //Console.WriteLine("Enter num");
            //int num;
            //bool flag = int.TryParse(Console.ReadLine(), out num);
            //if (flag)
            //{
            //    for (int i = 1; i <= num; i++)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input");

            //} 
            #endregion

            #region Q7
            //Console.WriteLine("Enter num");
            //int num;
            //bool flag = int.TryParse(Console.ReadLine(), out num);
            //if (flag)
            //{
            //    for(int i = 1; i<=12; i++)
            //    {
            //        Console.WriteLine(i*num);
            //    }
            //} 
            #endregion

            #region Q8
            //Console.WriteLine("Enter num : ");
            //int num;
            //bool flag = int.TryParse(Console.ReadLine(), out num);
            //if (flag)
            //{
            //    for (int i = 1; i <= num; i++)
            //    {
            //        if(i % 2 == 0)
            //        {
            //            Console.WriteLine(i);
            //        }
            //    }

            //}
            //else
            //{
            //    Console.WriteLine("Invalid input");
            //} 
            #endregion

            #region Q9
            //Console.WriteLine("enter two numbers: ");
            //int num1, num2;
            //bool flag1 = int.TryParse(Console.ReadLine(), out num1);
            //bool flag2 = int.TryParse(Console.ReadLine(), out num2);
            //if (flag1 && flag2)
            //{
            //    //double result = Math.Pow(num1, num2);
            //    //Console.WriteLine(result);
            //    int result = 1;
            //    for (int i = 1; i <= num2; i++)
            //    {
            //        result *= num1;
            //        Console.WriteLine(result);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input");
            //} 
            #endregion

            #region Q10
            //Console.WriteLine("enter marks of five: ");
            //int marks1, marks2, marks3, marks4, marks5;
            //bool flag1 = int.TryParse(Console.ReadLine(), out marks1);
            //bool flag2 = int.TryParse(Console.ReadLine(), out marks2);
            //bool flag3 = int.TryParse(Console.ReadLine(), out marks3);
            //bool flag4 = int.TryParse(Console.ReadLine(), out marks4);
            //bool flag5 = int.TryParse(Console.ReadLine(), out marks5);
            //if (flag1 && flag2 && flag3 && flag4 && flag5)
            //{
            //        int total = marks1 + marks2 + marks3 + marks4 + marks5;
            //        int average = total / 5;
            //        int percentage = (total / 5) * 100 / 100;
            //        Console.WriteLine($"Total marks: {total}");
            //        Console.WriteLine($"Average marks = {average}");
            //        Console.WriteLine($"Percentage: {percentage}");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input");
            //} 
            #endregion

            #region Q11
            //int month;
            //bool flag;

            //do
            //{
            //    Console.WriteLine("Enter month: ");
            //    flag = int.TryParse(Console.ReadLine(), out month);

            //}
            //while (!flag);

            //switch (month)
            //{
            //    case 1:
            //    case 3:
            //    case 5:
            //    case 7:
            //    case 8:
            //    case 10:
            //    case 12:
            //        Console.WriteLine("Days in Month: 31");
            //        break;
            //    case 2:
            //        Console.WriteLine("Days in Month: 28");
            //        break;
            //    default:
            //        Console.WriteLine("Days in Month: 30");
            //        break;
            //} 
            #endregion

            #region Q12
            //int num1;
            //bool flag1;
            //do
            //{
            //    Console.WriteLine("Enter num1: ");
            //    flag1 = int.TryParse(Console.ReadLine(), out num1);
            //} while (!flag1);

            //char op;
            //bool flag2;
            //do
            //{
            //    Console.WriteLine("Enter operator: ");
            //    flag2 = char.TryParse(Console.ReadLine(), out op);
            //} while (!flag2);

            //int num2;
            //bool flag3;
            //do
            //{
            //    Console.WriteLine("Enter num2: ");
            //    flag3 = int.TryParse(Console.ReadLine(), out num2);
            //} while (!flag3);

            //switch (op)
            //{
            //    case '+':
            //        Console.WriteLine(num1 + num2);
            //        break;
            //    case '-':
            //        Console.WriteLine(num1 - num2);
            //        break;
            //    case '*':
            //        Console.WriteLine(num1 * num2);
            //        break;
            //    case '/':
            //        Console.WriteLine(num1 / num2);
            //        break;
            //    default:
            //        Console.WriteLine("Invalid operator");
            //        break;
            //} 
            #endregion

            #region Q13
            //string word;
            //////bool flag;
            //////do
            //////{
            //////    Console.WriteLine("Enter word");
            //////    flag = !int.TryParse(Console.ReadLine(), out word);
            //////}
            //////while (!flag);
            //Console.WriteLine("Enter word: ");
            //word = Console.ReadLine();
            //for (int i = word.Length - 1; i >= 0; i--)
            //{
            //    Console.Write(word[i]);
            //}
            #endregion

            #region Q14
            //int num;
            //bool flag;
            //do
            //{
            //    Console.WriteLine("Enter int");
            //    flag = int.TryParse(Console.ReadLine(), out num);
            //}
            //while (!flag);
            //string word = num.ToString();
            //for (int i = word.Length - 1; i >= 0; i--)
            //{
            //    Console.Write(word[i]);
            //} 
            #endregion

            #region Q15
            //int num1;
            //bool flag1;
            //do
            //{
            //    Console.WriteLine("Enter num1: ");
            //    flag1 = int.TryParse(Console.ReadLine(), out num1);
            //} while (!flag1);

            //int num2;
            //bool flag2;
            //do
            //{
            //    Console.WriteLine("Enter num2: ");
            //    flag2 = int.TryParse(Console.ReadLine(), out num2);
            //} while (!flag2);


            //for (int i = num1; i <= num2; i++)
            //{
            //    for (int j = 2; j < i; j++)
            //    {

            //    }


            //} 
            #endregion
            #region Q16

            #endregion

            #region Q17

            #endregion

            #region Q18
            //int time;
            //bool flag;
            //do
            //{
            //    Console.Write("Enter the time: ");
            //    flag = int.TryParse(Console.ReadLine(), out time);

            //}
            //while (!flag);

            //if (time >= 2 && time <= 3)
            //{
            //    Console.WriteLine("considered highly efficient");
            //}
            //else if (time > 3 && time <= 4)
            //{
            //    Console.WriteLine("instructed to increase their speed");
            //}
            //else if (time > 4 && time <= 5)
            //{
            //    Console.WriteLine("should provided with training to enhance their speed");
            //}
            //else if (time > 5)
            //{
            //    Console.WriteLine("required to leave the company");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input");
            //} 
            #endregion
        }
    }
}
