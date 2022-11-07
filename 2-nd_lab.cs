using System;
namespace _1st_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            #region level 1
            Console.WriteLine($"Level 1");
            #region task 2
            {
                Console.WriteLine($"    Task 2");

                double x, y;

                while (true)
                {
                    Console.WriteLine($"    Please enter x: ");
                    if (!double.TryParse(Console.ReadLine(), out x))
                    {
                        Console.WriteLine($"    Wrong x, please try again");
                        continue;
                    }
                    Console.WriteLine($"    Please enter y: ");
                    if (!double.TryParse(Console.ReadLine(), out y))
                    {
                        Console.WriteLine($"    Wrong y, please try again");
                        continue;
                    }
                    break;
                }

                /*
                 * y >= 0 and y + abs(x) <= 1
                 */
                if (y >= 0 && Math.Abs(x) + y <= 1)
                {
                    Console.WriteLine($"    The point ({x};{y}) is inside the triangle");
                }
                else
                {
                    Console.WriteLine($"    The point ({x};{y}) is not inside the triangle");
                }
            }
            #endregion

            #region task 4
            {
                Console.WriteLine($"Task 4");

                double a, b, c;
                double uu, z;

                while (true)
                {
                    Console.WriteLine($"    Please enter a: ");
                    if (!double.TryParse(Console.ReadLine(), out a))
                    {
                        Console.WriteLine($"    Wrong a, please try again");
                        continue;
                    }
                    Console.WriteLine($"    Please enter b: ");
                    if (!double.TryParse(Console.ReadLine(), out b))
                    {
                        Console.WriteLine($"    Wrong b, please try again");
                        continue;
                    }
                    Console.WriteLine($"    Please enter c: ");
                    if (!double.TryParse(Console.ReadLine(), out c))
                    {
                        Console.WriteLine($"    Wrong c, please try again");
                        continue;
                    }
                    break;
                }

                uu = a;
                if (b < uu)
                {
                    uu = b;
                }

                z = c;
                if (uu > z)
                {
                    z = uu;
                }
                Console.WriteLine($"    z = {z}");
            }
            #endregion

            #region task 7
            {
                Console.WriteLine($"Task 7");

                double x, y;

                while (true)
                {
                    Console.WriteLine($"    Please enter x: ");
                    if (!double.TryParse(Console.ReadLine(), out x))
                    {
                        Console.WriteLine($"    Wrong x, please try again");
                        continue;
                    }
                    break;
                }

                x = Math.Abs(x);

                y = x;
                if (x > 1)
                {
                    y = 1;
                }
                Console.WriteLine($"    y = {y}");
            }
            #endregion
            #endregion

            #region Level 2
            Console.WriteLine($"Level 2");

            #region task 1
            Console.WriteLine($"Task 1");
            {
                double s = 0.0;
                double height;
                int n;

                while (true)
                {
                    Console.WriteLine($"    Please enter the number of students (n): ");
                    if (!int.TryParse(Console.ReadLine(), out n))
                    {
                        Console.WriteLine($"    Wrong n, please try again");
                        continue;
                    }
                    if (n <= 0)
                    {
                        Console.WriteLine($"    n must be positive");
                        continue;
                    }
                    break;
                }

                for (int i = 1; i <= n; i++)
                {
                    Console.WriteLine($"Please enter the height of the {i} student in centimeteres.");
                    if (!double.TryParse(Console.ReadLine(), out height))
                    {
                        Console.WriteLine($"Incorrect format");
                        return;
                    }
                    if (height <= 0)
                    {
                        Console.WriteLine($"Height must be positive.");
                        return;
                    }
                    s += height;
                }

                double average = s / n;
                Console.WriteLine($"    Average height: {average}");
            }
            #endregion

            #region task 9
            Console.WriteLine($"Task 9");
            {
                double result, best = double.PositiveInfinity;
                int n;

                while (true)
                {
                    Console.WriteLine($"    Please enter the number (n) of sportsmen");
                    if (!int.TryParse(Console.ReadLine(), out n))
                    {
                        Console.WriteLine($"    Wrong n, please try again");
                        continue;
                    }
                    if (n <= 0)
                    {
                        Console.WriteLine($"    n must be positive");
                        continue;
                    }
                    break;
                }

                for (int i = 1; i <= n; i++)
                {
                    Console.WriteLine($"Please enter result of {i} sportsman:");

                    if (!double.TryParse(Console.ReadLine(), out result))
                    {
                        Console.WriteLine($"Incorrect format");
                        return;
                    }
                    if (result <= 0)
                    {
                        Console.WriteLine($"result must be positive");
                        return;
                    }

                    best = Math.Min(best, result);
                }
                Console.WriteLine($"    The best result: {best}");

            }
            #endregion
            #endregion

            #region Level 3
            Console.WriteLine($"Level 3");

            #region task 4
            Console.WriteLine($"Task 4");
            {
                double r1, r2;
                double distance;
                int n = 1, counter = 0;
                double x, y;

                while (true)
                {
                    Console.WriteLine($"    Please enter r1: ");
                    if (!double.TryParse(Console.ReadLine(), out r1))
                    {
                        Console.WriteLine($"    wrong r1, please try again");
                        continue;
                    }
                    if (r1 <= 0)
                    {
                        Console.WriteLine($"    r1 must be positive");
                        continue;
                    }
                    break;
                }

                while (true)
                {
                    Console.WriteLine($"    Please enter r2: ");
                    if (!double.TryParse(Console.ReadLine(), out r2))
                    {
                        Console.WriteLine($"    wrong r2, please try again");
                        continue;
                    }
                    if (r2 <= 0)
                    {
                        Console.WriteLine($"    r2 must be positive");
                        continue;
                    }
                    if (r2 < r1)
                    {
                        Console.WriteLine($"    r2 must be greater than r1, try again");
                    }
                    break;
                }

                Console.WriteLine($"    if input data is all fed, write '-1'");
                while (true)
                {
                    Console.WriteLine($"    Enter coordinates number {n}");
                    Console.Write($"    x: ");

                    if (!double.TryParse(Console.ReadLine(), out x))
                    {
                        Console.WriteLine($"    incorrect format");
                        return;
                    }
                    if (x == -1)
                    {
                        break;
                    }

                    Console.Write($"    y: ");
                    if (!double.TryParse(Console.ReadLine(), out y))
                    {
                        Console.WriteLine($"    incorrect format");
                        return;
                    }

                    distance = x * x + y * y;

                    if (distance <= r2 * r2 && distance >= r1 * r1)
                    {
                        counter++;
                    }
                    n++;

                }
                Console.WriteLine($"    Points in a ring: {counter}");

            }
            #endregion

            #region task 11
            Console.WriteLine($"Task 11");
            {
                int n = 0;
                int mark;
                int bad_students_counter = 0;
                bool bad_grade = false;
                double average = 0;
                double rating;
                bool stop_input = false;


                Console.WriteLine($"    if input data is all fed, write '-1'");

                while (true)
                {
                    Console.WriteLine($"    Enter marks for student {n + 1}");
                    rating = 0.0;

                    for (int j = 1; j <= 4; j++)
                    {

                        if (!int.TryParse(Console.ReadLine(), out mark))
                        {
                            Console.WriteLine($"    incorrect format");
                            return;
                        }

                        if (mark == -1)
                        {
                            stop_input = true;
                            break;
                        }

                        if (mark < 2 || mark > 5)
                        {
                            Console.WriteLine($"    Marks must be in range from 2 to 5");
                            return;
                        } else

                        if (mark == 2)
                        {
                            bad_grade = true;
                        }

                        rating += mark;
                    }

                    if (stop_input)
                    {
                        break;
                    }

                    if (bad_grade)
                    {
                        bad_students_counter++;
                    }
                    else
                    {
                        average += rating / 4;
                    }

               
                    n++;
                }

                Console.WriteLine($"    the amount of bad students: {bad_students_counter}");
                Console.WriteLine($"    group average mark: {average / (n - bad_students_counter)}");
            }
            #endregion

            #region task 12
            Console.WriteLine($"Task 12");
            {
                double r;
                int choice;

                while (true)
                {
                    while (true)
                    {
                        Console.WriteLine($"    Please enter r: ");
                        if (!double.TryParse(Console.ReadLine(), out r))
                        {
                            Console.WriteLine($"    Wrong r, try again");
                            continue;
                        }
                        if (r <= 0)
                        {
                            Console.WriteLine($"    r must be positive");
                        }
                        break;
                    }

                    Console.WriteLine($"    1 - Area of a square");
                    Console.WriteLine($"    2 - Area of a circle");
                    Console.WriteLine($"    3 - Area of equiliteral triangle");

                    while (true)
                    {
                        Console.WriteLine($"    Choose what to calculate (1, 2, 3):");
                        if (!int.TryParse(Console.ReadLine(), out choice))
                        {
                            Console.WriteLine($"    incorrect format, try again");
                            continue;
                        }
                        break;
                    }

                    double square = r * r;

                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine($"    Area if a square: {square}");
                            break;
                        case 2:
                            Console.WriteLine($"    Area of a circle: {Math.PI * square}");
                            break;
                        case 3:
                            Console.WriteLine($"    Area of a triangle: {square * Math.Sqrt(3) / 4}");
                            break;
                        default:
                            Console.WriteLine($"    Wrong choice: choose only 1, 2 or 3.");
                            break;
                    }

                    Console.WriteLine($"    Do you want to repeat the process? yes or no?");
                    string command = Console.ReadLine().ToLower();
                    if (command == "no")
                    {
                        break;
                    }
                    if (command != "no" && command != "yes")
                    {
                        Console.WriteLine($"    you should write yes or no only");
                    }
                }

            }
            #endregion

            #region task 13
            Console.WriteLine("Task 13");
            {
                int choice;
                double a, b;
                double area = 0;

                while (true)
                {
                    Console.WriteLine("     what should i calculate?");
                    Console.WriteLine("     1 - Area of a rectangle");
                    Console.WriteLine("     2 - area of a ring");
                    Console.WriteLine("     3 - area of isosceles triangle");

                    while (true)
                    {
                        if (!int.TryParse(Console.ReadLine(), out choice))
                        {
                            Console.WriteLine("     incorrect format, try again");
                            continue;
                        }
                        if (choice != 1 && choice != 2 && choice != 3)
                        {
                            Console.WriteLine("     you should choose only 1, 2 or 3. try again");
                            continue;
                        }
                        break;
                    }

                    while (true)
                    {
                        Console.Write("     enter a (positive):");
                        if (!double.TryParse(Console.ReadLine(), out a))
                        {
                            Console.WriteLine("     incorrect format, try again");
                            continue;
                        }
                        if (a <= 0)
                        {
                            Console.WriteLine("     a must be positive, try again");
                            continue;
                        }
                        break;
                    }

                    while (true)
                    {
                        Console.Write("     enter b (positive):");
                        if (!double.TryParse(Console.ReadLine(), out b))
                        {
                            Console.WriteLine("     incorrect format, try again");
                            continue;
                        }
                        if (b <= 0)
                        {
                            Console.WriteLine("     b must be positive, try again");
                            continue;
                        }
                        break;
                    }

                    switch (choice)
                    {
                        case 1:
                            area = a * b;
                            break;
                        case 2:
                            double maxx = Math.Max(a, b);
                            double minn = Math.Min(a, b);
                            area = Math.PI * (maxx - minn);
                            break;
                        case 3:
                            if (a > b + b)
                            {
                                Console.WriteLine("triangle undefined");
                                continue;
                            }
                            double height = Math.Sqrt(b * b - a * a / 4);
                            area = a * height / 2;
                            break;
                    }

                    Console.WriteLine($"    Area: {area}");
                    Console.WriteLine("     do you want to repeat the process? yes or no?");
                    string command = Console.ReadLine().ToLower();

                    if (command == "no")
                    {
                        break;
                    }
                    if (command != "no" && command != "yes")
                    {
                        Console.WriteLine("     You need to answer only yes or no");
                        return;
                    }
                }
            }
            #endregion

            #endregion
        }
    }
}
