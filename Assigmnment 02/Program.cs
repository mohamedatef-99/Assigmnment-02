namespace Assigmnment_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
