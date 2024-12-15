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
        }
    }
}
