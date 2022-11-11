using System;
using System.Collections.Generic;

namespace _3st_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            #region algorithms
            Console.WriteLine("fundamental algorithms");

            #region 11 binary search
            Console.WriteLine("11 binary search");
            {
                int n;

                Console.WriteLine("     enter n");

                while (true)
                {
                    if (!int.TryParse(Console.ReadLine(), out n))
                    {
                        Console.WriteLine("     incorrect format, try again");
                        continue;
                    }
                    if (n <= 0)
                    {
                        Console.WriteLine("     n > 0, try again");
                        continue;
                    }
                    break;
                }

                double xx;

                Console.WriteLine("     enter x");

                while (true)
                {
                    if (!double.TryParse(Console.ReadLine(), out xx))
                    {
                        Console.WriteLine("     incorrect format, try again");
                        continue;
                    }
                    break;
                }

                List<double> x = new List<double>();


                Console.WriteLine("     enter n values");

                for (int i = 0; i < n; i++)
                {
                    double value;

                    if (!double.TryParse(Console.ReadLine(), out value))
                    {
                        Console.WriteLine("     incorrect format");
                        return;
                    }

                    x.Add(value);
                }

                x.Sort();
                int left = 0, right = n - 1, answer = -1;

                while (left <= right)
                {
                    int middle = (left + right) / 2;

                    if (x[middle] == xx)
                    {
                        answer = middle;
                        break;
                    }
                    if (x[middle] < xx)
                    {
                        left = middle + 1;
                    }
                    if (x[middle] > xx)
                    {
                        right = middle - 1;
                    }
                }

                if (answer >= 0)
                {
                    Console.WriteLine($"    index: {answer}");
                }
                else
                {
                    Console.WriteLine("     no answer");
                }
            }
            #endregion

            #region 12 merging arrays with with elements alternation
            Console.WriteLine("12 merging arrays with with elements alternation");
            {
                int n, m;

                Console.WriteLine("     enter n");

                while (true)
                {
                    if (!int.TryParse(Console.ReadLine(), out n))
                    {
                        Console.WriteLine("     incorrect format, try again");
                        continue;
                    }
                    if (n <= 0)
                    {
                        Console.WriteLine("     n > 0, try again");
                        continue;
                    }
                    break;
                }

                Console.WriteLine("     enter m");

                while (true)
                {
                    if (!int.TryParse(Console.ReadLine(), out m))
                    {
                        Console.WriteLine("     incorrect format, try again");
                        continue;
                    }
                    if (m <= 0)
                    {
                        Console.WriteLine("     m > 0, try again");
                        continue;
                    }
                    break;
                }

                double[] a = new double[n], b = new double[m];

                Console.WriteLine($"     enter {n} values");

                for (int i = 0; i < n; i++)
                {
                    double value;

                    if (!double.TryParse(Console.ReadLine(), out value))
                    {
                        Console.WriteLine("     incorrect format");
                        return;
                    }

                    a[i] = value;
                }

                Console.WriteLine($"     enter {m} values");

                for (int i = 0; i < m; i++)
                {
                    double value;

                    if (!double.TryParse(Console.ReadLine(), out value))
                    {
                        Console.WriteLine("     incorrect format");
                        return;
                    }

                    b[i] = value;
                }

                List<double> c = new List<double>();

                for (int i = 0; i < Math.Min(n, m); i++)
                {
                    c.Add(a[i]);
                    c.Add(b[i]);
                }

                double[] copy_;
                if (n < m)
                {
                    copy_ = b;
                }
                else
                {
                    copy_ = a;
                }

                for (int i = Math.Min(n, m); i < Math.Max(n, m); i++)
                {
                    c.Add(copy_[i]);
                }

                string answer = "   answer: ";
                foreach (double v in c)
                {
                    answer += v.ToString();
                    answer += " ";
                }
                Console.WriteLine(answer);
            }
            #endregion

            #region 13 merging two sorted arrays keeping sorted order
            Console.WriteLine("13 merging two sorted arrays keeping sorted order");
            {
                int n, m;

                Console.WriteLine("     enter n");

                while (true)
                {
                    if (!int.TryParse(Console.ReadLine(), out n))
                    {
                        Console.WriteLine("     incorrect format, try again");
                        continue;
                    }
                    if (n <= 0)
                    {
                        Console.WriteLine("     n > 0, try again");
                        continue;
                    }
                    break;
                }

                Console.WriteLine("     enter m");

                while (true)
                {
                    if (!int.TryParse(Console.ReadLine(), out m))
                    {
                        Console.WriteLine("     incorrect format, try again");
                        continue;
                    }
                    if (m <= 0)
                    {
                        Console.WriteLine("     m > 0, try again");
                        continue;
                    }
                    break;
                }

                List<double> a = new List<double>(), b = new List<double>(), c = new List<double>();

                Console.WriteLine("     enter n values");

                for (int i = 0; i < n; i++)
                {
                    double value;

                    if (!double.TryParse(Console.ReadLine(), out value))
                    {
                        Console.WriteLine("     incorrect format");
                        return;
                    }

                    a.Add(value);
                }

                Console.WriteLine("     enter m values");

                for (int i = 0; i < m; i++)
                {
                    double value;

                    if (!double.TryParse(Console.ReadLine(), out value))
                    {
                        Console.WriteLine("     incorrect format");
                        return;
                    }

                    b.Add(value);
                }

                a.Sort();
                b.Sort();

                int ii = 0, jj = 0;

                while (ii < n || jj < m)
                {
                    if (ii == n)
                    {
                        c.Add(b[jj]);
                        jj++;
                        continue;
                    }

                    if (jj == m)
                    {
                        c.Add(a[ii]);
                        ii++;
                        continue;
                    }

                    if (a[ii] <= b[jj])
                    {
                        c.Add(a[ii]);
                        ii++;
                    }
                    else
                    {
                        c.Add(b[jj]);
                        jj++;
                    }
                }

                string answer = "   answer: ";
                foreach (double v in c)
                {
                    answer += v.ToString();
                    answer += " ";
                }
                Console.WriteLine(answer);
            }
            #endregion

            #region 14 inverting array
            Console.WriteLine("14 inverting array");
            {
                int n;

                Console.WriteLine("     enter n");

                while (true)
                {
                    if (!int.TryParse(Console.ReadLine(), out n))
                    {
                        Console.WriteLine("     incorrect format, try again");
                        continue;
                    }
                    if (n <= 0)
                    {
                        Console.WriteLine("     n > 0, try again");
                        continue;
                    }
                    break;
                }

                double[] x = new double[n];

                Console.WriteLine("     enter n values");

                for (int i = 0; i < n; i++)
                {
                    double value;

                    if (!double.TryParse(Console.ReadLine(), out value))
                    {
                        Console.WriteLine("     incorrect format");
                        return;
                    }

                    x[i] = value;
                }

                for (int i = 0; i < n / 2; i++)
                {
                    (x[i], x[n - i - 1]) = (x[n - i - 1], x[i]);
                }

                string answer = "   answer: ";
                foreach (double v in x)
                {
                    answer += v.ToString();
                    answer += " ";
                }
                Console.WriteLine(answer);
            }

            #endregion

            #region level 1
            Console.WriteLine("level 1");

            #region task 6
            Console.WriteLine("task 6");
            {
                double s = 0;
                double[] vector = new double[5];
                double x;

                for (int i = 0; i <= 4; i++)
                {
                    Console.WriteLine($"     enter {i + 1} dimension of the vector");

                    while (true)
                    {
                        if (!double.TryParse(Console.ReadLine(), out x))
                        {
                            Console.WriteLine("     incorrect format, try again");
                            continue;
                        }
                        break;
                    }
                    vector[i] = x;
                }

                foreach (double xx in vector)
                {
                    s += xx * xx;
                }
                Console.WriteLine($"    L2 norm: {Math.Sqrt(s)}");
            }
            #endregion

            #region task 10
            Console.WriteLine("Task 10");
            {
                double p, q, u;
                int counter = 0;
                double[] array = new double[10];
                double x;

                while (true)
                {
                    Console.WriteLine("     enter p:");
                    if (!double.TryParse(Console.ReadLine(), out p))
                    {
                        Console.WriteLine("     incorrect format");
                        continue;
                    }

                    Console.WriteLine("     enter q:");
                    if (!double.TryParse(Console.ReadLine(), out q))
                    {
                        Console.WriteLine("     incorrect format");
                        continue;
                    }
                    break;
                }

                u = p;
                if (p > q)
                {
                    p = q;
                    q = u;
                }

                for (int i = 0; i <= 9; i++)
                {
                    Console.WriteLine($"     enter {i + 1} element of array");

                    if (!double.TryParse(Console.ReadLine(), out x))
                    {
                        Console.WriteLine("     incorrect format");
                        return;
                    }

                    array[i] = x;
                }

                foreach (double element in array)
                {
                    if (element > p && element < q)
                    {
                        counter++;
                    }
                }
                Console.WriteLine($"    counter: {counter}");
            }
            #endregion

            #region task 11
            Console.WriteLine("Task 11");
            {
                List<double> positive_only = new List<double>();
                double[] array = new double[10];
                double x;

                for (int i = 0; i <= 9; i++)
                {
                    Console.WriteLine($"    enter {i + 1} element of array");
                    if (!double.TryParse(Console.ReadLine(), out x))
                    {
                        Console.WriteLine("     incorrect format");
                        return;
                    }

                    array[i] = x;
                }

                foreach (double v in array)
                {
                    if (v > 0)
                    {
                        positive_only.Add(v);
                    }
                }

                Console.WriteLine($"    answer: {positive_only.ToString()}");
            }
            #endregion

            #region task 12
            Console.WriteLine("Task 12");
            {
                int idx = 0;
                double value = 0;
                double[] array = new double[] { 1, 2, 3, -1, -2, -3, 4, 5 };

                for (int i = 0; i <= 7; i++)
                {
                    if (array[i] < 0)
                    {
                        idx = i;
                        value = array[i];
                    }
                }
                Console.WriteLine($"    value {value} index {idx}");

            }
            #endregion

            #region task 13
            Console.WriteLine("task 13");
            {
                List<double> even = new List<double>(), odd = new List<double>();

                Console.WriteLine($"enter 10 values");

                for (int i = 0; i < 10; ++i)
                {

                    double value;
                    if (!double.TryParse(Console.ReadLine(), out value))
                    {
                        return;
                    }

                    if (i % 2 == 0)
                    {
                        even.Add(value);
                    }
                    else
                    {
                        odd.Add(value);
                    }
                }

                foreach (double el in odd)
                {
                    Console.WriteLine($"    {el}");
                }
                Console.WriteLine("*****************");
                foreach (double el in even)
                {
                    Console.WriteLine($"    {el}");
                }
            }
            #endregion

            #endregion

            #region level 2
            Console.WriteLine("Level 2");

            #region task 5
            Console.WriteLine("task 5");
            {
                int n;
                double x;

                while (true)
                {
                    Console.WriteLine("     enter length of the array");
                    if (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
                    {
                        Console.WriteLine("     incorrect format or n is not positive, try again");
                        continue;
                    }
                    break;
                }

                List<double> input_data = new List<double>();
                List<double> answer = new List<double>();
                int idx_max = 0, idx_min = 0;

                Console.WriteLine("     Plese enter n values");

                for (int i = 0; i < n; i++)
                {
                    double value;

                    if (!double.TryParse(Console.ReadLine(), out value))
                    {
                        Console.WriteLine("     Incorrect format");
                        return;
                    }

                    input_data.Add(value);

                    if (value > input_data[idx_max])
                    {
                        idx_max = i;
                    }

                    if (value < input_data[idx_min])
                    {
                        idx_min = i;
                    }
                }

                int start = Math.Min(idx_min, idx_max), end = Math.Max(idx_min, idx_max);

                for (int i = start; i < end; i++)
                {
                    double val = input_data[i];
                    if (val < 0)
                    {
                        answer.Add(val);
                    }
                }

                string ans = "   answer:";
                foreach (double v in answer)
                {
                    ans += v.ToString();
                    ans += " ";
                }
                Console.WriteLine(ans);

            }
            #endregion

            #region task 6
            Console.WriteLine("Task 6");
            {
                int n;

                Console.WriteLine("     please enter the length of the array n");

                while (true)
                {
                    if (!int.TryParse(Console.ReadLine(), out n))
                    {
                        Console.WriteLine("     incorrect format, try again");
                        continue;
                    }

                    if (n <= 0)
                    {
                        Console.WriteLine("     n must be positive, enter again");
                        continue;
                    }
                    break;
                }

                Console.WriteLine("     enter n values");

                List<double> x = new List<double>();
                double mean = 0;

                for (int i = 0; i < n; i++)
                {
                    double value;

                    if (!double.TryParse(Console.ReadLine(), out value))
                    {
                        Console.WriteLine("     incorrect format");
                        return;
                    }

                    x.Add(value);
                    mean += value;
                }
                mean = mean / n;
                int idx_mean = 0;

                for (int i = 0; i < n; i++)
                {
                    if (Math.Abs(mean - x[i]) < Math.Abs(mean - x[idx_mean]))
                    {
                        idx_mean = i;
                    }
                }

                double p;
                Console.WriteLine("     enter p");

                while (true)
                {
                    if (!double.TryParse(Console.ReadLine(), out p))
                    {
                        Console.WriteLine("     incorrect format, try again");
                        continue;
                    }
                    break;
                }

                x.Insert(idx_mean+1, p);



                string s = "    answer: ";
                foreach (double v in x)
                {
                    s += v.ToString();
                    s += " ";
                }

                Console.WriteLine(s);
            }
            #endregion

            #region task 9
            Console.WriteLine("task 9");
            {
                int n;

                Console.WriteLine("     please enter the length of the array n");

                while (true)
                {
                    if (!int.TryParse(Console.ReadLine(), out n))
                    {
                        Console.WriteLine("     incorrect format, try again");
                        continue;
                    }

                    if (n <= 0)
                    {
                        Console.WriteLine("     n must be positive, enter again");
                        continue;
                    }
                    break;
                }

                List<double> x = new List<double>();

                Console.WriteLine("     enter n values");

                int idx_max = 0, idx_min = 0;

                for (int i = 0; i < n; i++)
                {
                    double value;

                    if (!double.TryParse(Console.ReadLine(), out value))
                    {
                        Console.WriteLine("     incorrect format");
                        return;
                    }

                    x.Add(value);

                    if (value > x[idx_max])
                    {
                        idx_max = i;
                    }

                    if (value < x[idx_min])
                    {
                        idx_min = i;
                    }
                }

                double ans = 0;

                for (int i = Math.Min(idx_max, idx_min); i <= Math.Max(idx_max, idx_min); i++)
                {
                    ans += x[i];
                }
                ans = ans / (Math.Abs(idx_min - idx_max) + 1);
                Console.WriteLine($"    answer: {ans}");
            }
            #endregion

            #region task 10
            Console.WriteLine("task 10");
            {
                int n;

                Console.WriteLine("     please enter the length of the array n");

                while (true)
                {
                    if (!int.TryParse(Console.ReadLine(), out n))
                    {
                        Console.WriteLine("     incorrect format, try again");
                        continue;
                    }

                    if (n <= 0)
                    {
                        Console.WriteLine("     n must be positive, enter again");
                        continue;
                    }
                    break;
                }

                double min_el = double.PositiveInfinity;
                List<double> x = new List<double>();

                Console.WriteLine("     enter n values");

                for (int i = 0; i < n; i++)
                {
                    double value;

                    if (!double.TryParse(Console.ReadLine(), out value))
                    {
                        Console.WriteLine("     incorrect format");
                        return;
                    }

                    x.Add(value);

                    if (value > 0 && value < min_el)
                    {
                        min_el = value;
                    }
                }

                x.Remove(min_el);
                string answer = "   answer: ";
                foreach (double v in x)
                {
                    answer += v.ToString();
                    answer += " ";
                }
                Console.WriteLine(answer);

            }
            #endregion

            #region task 11
            Console.WriteLine("task 11");
            {
                int n;

                Console.WriteLine("     please enter the length of the array n");

                while (true)
                {
                    if (!int.TryParse(Console.ReadLine(), out n))
                    {
                        Console.WriteLine("     incorrect format, try again");
                        continue;
                    }

                    if (n <= 0)
                    {
                        Console.WriteLine("     n must be positive, enter again");
                        continue;
                    }
                    break;
                }

                int last_positive = 0;
                List<double> x = new List<double>();

                Console.WriteLine("     enter n values");

                for (int i = 0; i < n; i++)
                {
                    double value;

                    if (!double.TryParse(Console.ReadLine(), out value))
                    {
                        Console.WriteLine("     incorrect format");
                        return;
                    }

                    x.Add(value);

                    if (value > 0)
                    {
                        last_positive = i;
                    }
                }

                double p;
                Console.WriteLine("     enter p");
                while (true)
                {
                    if (!double.TryParse(Console.ReadLine(), out p))
                    {
                        Console.WriteLine("     incorrect format, try again");
                        continue;
                    }
                    break;
                }

                x.Insert(last_positive+1, p);
                string answer = "   answer: ";
                foreach (double v in x)
                {
                    answer += v.ToString();
                    answer += " ";
                }
                Console.WriteLine(answer);
            }

            #endregion

            #region task 13
            Console.WriteLine("task 13");
            {
                int n;

                Console.WriteLine("     please enter the length of the array n");

                while (true)
                {
                    if (!int.TryParse(Console.ReadLine(), out n))
                    {
                        Console.WriteLine("     incorrect format, try again");
                        continue;
                    }

                    if (n <= 0)
                    {
                        Console.WriteLine("     n must be positive, enter again");
                        continue;
                    }
                    break;
                }

                double[] x = new double[n];
                double max_elem = double.NegativeInfinity;
                int idx_max = 0;

                Console.WriteLine("     enter n values");

                for (int i = 0; i < n; i++)
                {
                    double value;

                    if (!double.TryParse(Console.ReadLine(), out value))
                    {
                        Console.WriteLine("     incorrect format");
                        return;
                    }

                    x[i] = value;

                    if (value > max_elem)
                    {
                        max_elem = value;
                        idx_max = i;
                    }
                }
                x[idx_max] = idx_max;

                string answer = "   answer: ";
                foreach (double v in x)
                {
                    answer += v.ToString();
                    answer += " ";
                }
                Console.WriteLine(answer);

            }
            #endregion

            #region task 15
            Console.WriteLine("task 15");
            {
                int n, m;

                Console.WriteLine("     please enter n");

                while (true)
                {
                    if (!int.TryParse(Console.ReadLine(), out n))
                    {
                        Console.WriteLine("     incorrect format, try again");
                        continue;
                    }

                    if (n <= 0)
                    {
                        Console.WriteLine("     n must be positive, enter again");
                        continue;
                    }
                    break;
                }

                Console.WriteLine("     please enter m");

                while (true)
                {
                    if (!int.TryParse(Console.ReadLine(), out m))
                    {
                        Console.WriteLine("     incorrect format, try again");
                        continue;
                    }

                    if (m <= 0)
                    {
                        Console.WriteLine("     m must be positive, enter again");
                        continue;
                    }
                    break;
                }

                List<double> a = new List<double>();
                double[] b = new double[m];

                Console.WriteLine("     enter n values for A array");

                for (int i = 0; i < n; i++)
                {
                    double v;

                    if (!double.TryParse(Console.ReadLine(), out v))
                    {
                        Console.WriteLine("     incorrect format");
                        return;
                    }
                    a.Add(v);
                }

                Console.WriteLine("     enter m values for B array");
                for (int i = 0; i < m; i++)
                {
                    double v;

                    if (!double.TryParse(Console.ReadLine(), out v))
                    {
                        Console.WriteLine("     incorrect format");
                        return;
                    }
                    b[i] = v;
                }

                int k;
                Console.WriteLine("     please enter k");

                while (true)
                {
                    if (!int.TryParse(Console.ReadLine(), out k))
                    {
                        Console.WriteLine("     incorrect format, try again");
                        continue;
                    }

                    if (k < 0 || k >= n)
                    {
                        Console.WriteLine("     k must be in range [0; n - 1] , enter again");
                        continue;
                    }
                    break;
                }

                a.InsertRange(k, b);

                string answer = "   answer: ";
                foreach (double v in a)
                {
                    answer += v.ToString();
                    answer += " ";
                }
                Console.WriteLine(answer);
            }
            #endregion
            #endregion

            #region level 3
            Console.WriteLine("level 3");

            #region task 1
            Console.WriteLine("task 1");
            {
                int n;

                Console.WriteLine("     enter the length of the array");

                while (true)
                {
                    if (!int.TryParse(Console.ReadLine(), out n))
                    {
                        Console.WriteLine("     incorrect format, try again");
                        continue;
                    }
                    if (n <= 0)
                    {
                        Console.WriteLine("     n > 0, try again");
                        continue;
                    }
                    break;
                }

                Console.WriteLine("     enter n values");
                double[] x = new double[n];
                List<int> indices = new List<int>();
                double max_elem = double.NegativeInfinity;

                for (int i = 0; i <= n; i++)
                {
                    double value;

                    if (!double.TryParse(Console.ReadLine(), out value))
                    {
                        Console.WriteLine("     incorrect format");
                        return;
                    }

                    x[i] = value;
                    if (value > max_elem)
                    {
                        max_elem = value;
                        indices.Clear();
                    }

                    if(value == max_elem)
                    {
                        indices.Add(i);
                    }
                }

                string answer = "   answer: ";
                foreach (int idx in indices)
                {
                    answer += idx.ToString();
                    answer += " ";
                }
                Console.WriteLine(answer);
            }
            #endregion

            #region task 5
            Console.WriteLine("task 5");
            {
                int n;

                Console.WriteLine("     enter n");

                while (true)
                {
                    if (!int.TryParse(Console.ReadLine(), out n))
                    {
                        Console.WriteLine("     incorrect format, try again");
                        continue;
                    }
                    if (n <= 0)
                    {
                        Console.WriteLine("     n > 0, try again");
                        continue;
                    }
                    break;
                }

                double[] x = new double[n];

                Console.WriteLine("     enter n values");

                for (int i = 0; i <= n; i++)
                {
                    double value;

                    if (!double.TryParse(Console.ReadLine(), out value))
                    {
                        Console.WriteLine("     incorrect format");
                        return;
                    }

                    x[i] = value;
                }

                /*
                 * bubble sort
                 */
                for (int i = 0; i < n - 1; i += 2)
                {
                    for (int j = i + 2; j < n - 1; j += 2)
                    {
                        if (x[i] > x[j])
                        {
                            (x[i], x[j]) = (x[j], x[i]);
                        }
                    }
                }

                string answer = "   answer: ";
                foreach (double elem in x)
                {
                    answer += elem.ToString();
                    answer += " ";
                }
                Console.WriteLine(answer);
            }
            #endregion

            #region task 8
            Console.WriteLine("task 8");
            {
                int n;

                Console.WriteLine("     enter n");

                while (true)
                {
                    if (!int.TryParse(Console.ReadLine(), out n))
                    {
                        Console.WriteLine("     incorrect format, try again");
                        continue;
                    }
                    if (n <= 0)
                    {
                        Console.WriteLine("     n > 0, try again");
                        continue;
                    }
                    break;
                }

                double[] x = new double[n];
                List<int> indexes_negative = new List<int>();

                Console.WriteLine("     enter n values");

                for (int i = 0; i <= n; i++)
                {
                    double value;

                    if (!double.TryParse(Console.ReadLine(), out value))
                    {
                        Console.WriteLine("     incorrect format");
                        return;
                    }

                    x[i] = value;

                    if (value < 0)
                    {
                        indexes_negative.Add(i);
                    }
                }

                foreach (int i in indexes_negative)
                {
                    foreach (int j in indexes_negative)
                    {
                        if (x[i] > x[j])
                        {
                            (x[i], x[j]) = (x[j], x[i]);
                        }
                    }
                }

                string answer = "   answer: ";
                foreach (double elem in x)
                {
                    answer += elem.ToString();
                    answer += " ";
                }
                Console.WriteLine(answer);
            }
            #endregion

            #region task 9
            Console.WriteLine("task 9");
            {
                int n;

                Console.WriteLine("     enter n");

                while (true)
                {
                    if (!int.TryParse(Console.ReadLine(), out n))
                    {
                        Console.WriteLine("     incorrect format, try again");
                        continue;
                    }
                    if (n <= 0)
                    {
                        Console.WriteLine("     n > 0, try again");
                        continue;
                    }
                    break;
                }

                double[] x = new double[n];

                Console.WriteLine("     enter n values");

                for (int i = 0; i <= n; i++)
                {
                    double value;

                    if (!double.TryParse(Console.ReadLine(), out value))
                    {
                        Console.WriteLine("     incorrect format");
                        return;
                    }

                    x[i] = value;
                }

                int max_dec = 1, max_inc = 1, running_counter_dec = 0, running_counter_inc = 0;

                for (int i = 0; i < n - 1; i++)
                {
                    if (x[i] > x[i + 1])
                    {
                        running_counter_inc++;
                        max_inc = Math.Max(max_inc, running_counter_inc);
                        running_counter_dec = 1;
                        continue;
                    }

                    if (x[i] < x[i + 1])
                    {
                        running_counter_dec++;
                        max_dec = Math.Max(max_dec, running_counter_dec);
                        running_counter_inc = 1;
                    }
                    max_dec = Math.Max(max_dec, running_counter_dec);
                    max_inc = Math.Max(max_inc, running_counter_inc);
                    running_counter_inc = 1;
                    running_counter_dec = 1;
                }

                Console.WriteLine($"    answer: {Math.Max(max_inc, max_dec)}");
            }
            #endregion

            #region task 12
            Console.WriteLine("task 12");
            {
                int n;

                Console.WriteLine("     enter n");

                while (true)
                {
                    if (!int.TryParse(Console.ReadLine(), out n))
                    {
                        Console.WriteLine("     incorrect format, try again");
                        continue;
                    }
                    if (n <= 0)
                    {
                        Console.WriteLine("     n > 0, try again");
                        continue;
                    }
                    break;
                }

                List<double> x = new List<double>();

                Console.WriteLine("     enter n values");

                for (int i = 0; i <= n; i++)
                {
                    double value;

                    if (!double.TryParse(Console.ReadLine(), out value))
                    {
                        Console.WriteLine("     incorrect format");
                        return;
                    }

                    x[i] = value;
                }

                string answer = "   answer: ";

                foreach (double v in x)
                {
                    if (v < 0)
                    {
                        x.Remove(v);
                    }
                    else
                    {
                        answer += v.ToString();
                        answer += " ";
                    }
                }
                Console.WriteLine(answer);


            }
            #endregion

            #region task 13
            Console.WriteLine("task 13");
            {
                int n;

                Console.WriteLine("     enter n");

                while (true)
                {
                    if (!int.TryParse(Console.ReadLine(), out n))
                    {
                        Console.WriteLine("     incorrect format, try again");
                        continue;
                    }
                    if (n <= 0)
                    {
                        Console.WriteLine("     n > 0, try again");
                        continue;
                    }
                    break;
                }

                List<double> x = new List<double>();
                Dictionary<double, bool> cache = new Dictionary<double, bool>();
                string answer = "   answer: ";

                Console.WriteLine("     enter n values");

                for (int i = 0; i < n; i++)
                {
                    double value;

                    if (!double.TryParse(Console.ReadLine(), out value))
                    {
                        Console.WriteLine("     incorrect format");
                        return;
                    }

                    if (!cache.ContainsKey(value))
                    {
                        x.Add(value);
                        cache.Add(value, true);
                        answer += value.ToString();
                        answer += " ";
                    }
                }
                Console.WriteLine(answer);
            }
            #endregion

            #endregion
        }
    }
}
