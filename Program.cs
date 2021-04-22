using System;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*float a, b, res;
              char math_operation;

              Console.WriteLine("Введите первое число: ");
              a = float.Parse(Console.ReadLine());
              Console.WriteLine("Введите второе число: ");
              b = float.Parse(Console.ReadLine());
              Console.WriteLine("Выберите операцию: ");
              math_operation = char.Parse(Console.ReadLine());

              switch (math_operation)
              {

                 case '+':
                     res = a + b;
                     Console.WriteLine("Результат: " + res);
                    break;
                 case '-':
                     res = a - b;
                     Console.WriteLine("Результат: " + res);
                    break;
                 case '*':
                     res = a * b;
                     Console.WriteLine("Результат: " + res);
                    break;
                 case '/':
                     res = a / b;
                     Console.WriteLine("Результат: " + res);
                    break;
               }*/

            /*string str = "9sdfsf";

            int r;

            bool result = int.TryParse(str, out r);

            if (result)
                Console.WriteLine("Операция выполнена успешно, значение = " + r);
            else
                Console.WriteLine("Не удалось конвертировать!");*/

            //float a, b, res;//среднее арифметическое

            //Console.WriteLine("Введите первое число: ");
            //a = float.Parse(Console.ReadLine());
            //Console.WriteLine("Введите второе число: ");
            //b = float.Parse(Console.ReadLine());

            //res = (a + b) / 2;
            //Console.WriteLine(res);

            //int a = 5, b = 8, c = 7;//умножение 3 чисел

            //int res = a + b + c;
            //Console.WriteLine(res);
            //int result = a * b * c;
            //Console.WriteLine(result);

            //float a = 66.2f, b = 2.50f, res;//конвертер валют
            //Console.WriteLine("Введите сумму в USD ");
            //res = float.Parse(Console.ReadLine());

            //Console.WriteLine(res + " USD в RUB = " + res * a);
            //Console.WriteLine(res + " USD в BLR = " + res * b);


            //int a;//проверка числа на четность 

            //Console.WriteLine("Введите число: ");
            //a = int.Parse(Console.ReadLine());

            //if (a % 2 == 0)
            //{
            //    Console.WriteLine("число четное");
            //}
            //else
            //{
            //    Console.WriteLine("число нечетное");
            //}

            //int[] digits = new int[5];//одномерный массив

            //digits[0] = 34;
            //Console.WriteLine(digits[0]);

            //string[] students = new string[] { "Bob", "Mickle", "George", "Alex" };
            //Console.WriteLine(students[1]);

            //int len = students.Length;

            //string[] copyStudents = new string[len];
            //students.CopyTo(copyStudents, 0);
            //Console.WriteLine(copyStudents[1]);

            //int[,] numbers =
            //{
            //    {5, 7, 2 },
            //    {9, 200, 8 },
            //    {7, 0 ,12 }
            //};

            //Console.WriteLine(numbers[1, 1]);

            //List<short> digits = new List<short>() { 1, 0, 93, 75};//динамический массив
            // digits.Add(5);
            // digits.AddRange(new short[] {7, 8, 45 });
            // digits.Insert(1, 178);
            // digits.Remove(0);
            // digits.RemoveAt(2);

            // Console.WriteLine(digits[2]);

            //int[] arr_1 = { 3, 0, 23, 65 };//реализация смены значений у 2 массивов
            //int[] arr_2 = { 7, 5, 56, 98};

            //int[] temp = new int[arr_1.Length];

            //arr_1.CopyTo(temp, 0);
            //Array.Clear(arr_1, 0, arr_1.Length);
            //arr_2.CopyTo(arr_1, 0);
            //Array.Clear(arr_2, 0, arr_2.Length);
            //temp.CopyTo(arr_2, 0);
            //Array.Clear(temp, 0, temp.Length);

            //Console.WriteLine($"1 - { arr_1[0] }, 2 - { arr_2[0] }");

            //List<float> digits = new List<float>() { 2.3f, 4.6f, 10.7f, 5.6f, 12.6f, 1.5f, 3.2f};
            //digits.Sort();
            //Console.WriteLine(digits[4]);

            /*float a, b;
            char math_operation;

            Console.WriteLine("Введите первое число: ");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            b = float.Parse(Console.ReadLine());
            
            Console.WriteLine("Выберите операцию: +, -, *, / ");

            math_operation = char.Parse(Console.ReadLine());

            if (math_operation == '+')
            {
                Console.WriteLine("Результат: " + (a + b));
            }
            else if (math_operation == '-')
            {
                Console.WriteLine("Результат: " + (a - b));
            }
            else if (math_operation == '*')
            {
                Console.WriteLine("Результат: " + (a * b));
            }
            else if (math_operation == '/')
            {
                if (b == 0)
                    Console.WriteLine(0);
                else
                    Console.WriteLine("Результат:" + (a / b));

            }
            else
            {
                Console.WriteLine("Данные некорректны!");
            }*/

            //while (true)//реализация полного калькулятора
            //{
            //    Console.Clear();
            //    float a, b, res;
            //    string math_operation;

            //    try
            //    {
            //        Console.WriteLine("Введите первое число: ");
            //        a = float.Parse(Console.ReadLine());
            //        Console.WriteLine("Введите второе число: ");
            //        b = float.Parse(Console.ReadLine());
            //    }
            //    catch (Exception)
            //    {
            //        Console.WriteLine("Данные некорректны!");
            //        Console.ReadLine();
            //        continue;
            //    }


            //    Console.WriteLine("Выберите операцию: +, -, *, / ");
            //    math_operation = (Console.ReadLine());


            //    switch (math_operation)
            //    {
            //        case "+":
            //            res = a + b;
            //            Console.WriteLine("Результат: " + res);
            //            break;
            //        case "-":
            //            res = a - b;
            //            Console.WriteLine("Результат: " + res);
            //            break;
            //        case "*":
            //            res = a * b;
            //            Console.WriteLine("Результат: " + res);
            //            break;
            //        case "/":
            //            if (b == 0)
            //                Console.WriteLine(0);
            //            else
            //                Console.WriteLine(a / b);
            //            break;

            //        default:
            //            Console.WriteLine("Данные некорректны!");
            //            break;
            //    }

            // for (int i = 100; i >= 10; i /= 2)
            //   Console.WriteLine("Element - " + i);


            /*short f = 1000;

            while (f > 127)
            {
                Console.WriteLine("Element - " + f);
                f -= 100;
            }*/

            /*short f = 100;
            do
            {
                Console.WriteLine("Element - " + f);
                f -= 100;
            } while (f > 127);*/

            /*for(int i = 1; i <= 40; i++)
            {
                if (i == 36)
                    break;
                if (i % 2 == 0)
                    continue;

                Console.WriteLine("El: " + i);
            }*/

            //int[] numbers = {2, 6, 0, 91, 83, 56 };//среднее арифметическое у элементов массива
            //int a;
            //int b = 2;
            //int res;

            //Console.WriteLine("Введите число: ");
            //a = int.Parse(Console.ReadLine());

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //   res = (a + numbers[i]) / b;
            //    Console.WriteLine(res);
            //}

            //int[,] digits = {      //двумерный массив
            //     {56, 3, 0 },
            //     {92, 11, 2 },
            //     {5, 7, 8 }
            //};

            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write(digits[i, j] + " ");
            //    }
            //    Console.WriteLine("");

            //}

            //List<string> str = new List<string>() { "Hello", "world", "some", "other" };//динам массив и цикл форич

            //string[] words = { "Hello", "world", "some", "other" };

            //foreach (string el in str)
            //{
            //    Console.WriteLine(el);
            //}

            // byte rand = 8, user_input;

            // do//цикл do while
            // {
            //     Console.WriteLine("Введите число от 1 до 10: ");
            //     user_input = byte.Parse(Console.ReadLine());
            // } while (user_input != rand);
            // Console.WriteLine("Вы угадали число!");

            //for (int i = 25; i < 30; i++)//цикл for
            //{

            //    if (i == 27)
            //        continue;
            //    Console.WriteLine(i);
            //}

            //int f = 25;// цикл while

            //while (f < 30)
            //{
            //    f++;
            //    if (f == 27)
            //        continue;
            //    Console.WriteLine(f);
            //}

            //int[,] numbers = {  //минимальное число в двумерном массиве
            //    {0, 34, -2 },
            //    {3, -4, 5 }
            //};
            //int min_num = numbers[0, 0];
            //for (int i = 0; i < 2; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        if (numbers[i, j] < min_num)
            //            min_num = numbers[i, j];
            //    }
            //}
            //Console.WriteLine("Minimum number: " + min_num);
            /* while (true)
             {
                 int a;

                 try
                 {
                     a = Convert.ToInt32(Console.ReadLine());
                 }
                 catch (Exception)
                 {
                     break;
                 }


                 for (int i = 0; i < a; i++)
                 {    
                     if (a == 1)
                     {
                         Console.WriteLine("One more iteration");
                         continue;
                     }
                     if (a == 0)
                         break;   
                 }
             }*/

            //List<int> num = new List<int>() { 25, 102, 65, 101, 12, 34, 56 };
            ////макс число в динамик массиве
            //int max_num = num[0];
            //for (int i = 0; i < max_num; i++)
            //{
            //    if (num[i] > max_num)
            //    {
            //        max_num = num[i];
            //        Console.Write(max_num);
            //        Console.ReadLine();
            //    }

            //}
            //uint chet = 0;//сумма и количество чётных и нечётных чисел
            //uint nechet = 0;

            //int oddNumbersSum = 0;
            //int evenNumbersSum = 0;

            //Console.WriteLine("Введите первое число диапозона");
            //int num = int.Parse(Console.ReadLine());
            //Console.WriteLine("Введите последнее число диапозона");
            //int limit = int.Parse(Console.ReadLine());

            //while (num <= limit)
            // {
            //     if (num % 2 == 0)
            //     {
            //         evenNumbersSum += num;
            //         chet++;
            //     }
            //     else
            //     {
            //         oddNumbersSum += num;
            //         nechet++;
            //     }
            //     num++;
            // }
            // Console.WriteLine("Количество чётных чисел: " + chet);
            // Console.WriteLine("Количество нечётных чисел: " + nechet);
            // Console.WriteLine("Сумма чётных чисел: " + evenNumbersSum);
            // Console.WriteLine("Сумма нечётных чисел: " + oddNumbersSum);

            //Console.WriteLine("Введите высоту треугольника: ");//отрисовка фигур с помощью символов
            //int height = int.Parse(Console.ReadLine());

            //for (int i = 0; i < height; i++)
            //{
            //    for (int j = 0; j <= i; j++)
            //    {
            //        Console.Write("#");
            //    }
            //    Console.WriteLine();
            //}

            //Console.Write("Введите количество элементов массива:\t");//ввод массива с клавиатуры

            //int elementsCount = int.Parse(Console.ReadLine());

            //int[] myArray = new int[elementsCount];

            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    Console.Write($"\nВведите элемент массива под индексом {i}:\t ");
            //    myArray[i] = int.Parse(Console.ReadLine());
            //}

            //Console.WriteLine("\nВвывод массива:");

            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    Console.WriteLine(myArray[i]);
            //}

            //int[] myArray = { 2, 3, 99, 49, 64, 77, 4, 42, 5 };//сумма четных чисел массива
            //int result = 0;

            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    if (myArray[i] % 2 == 0)
            //    {
            //        result += myArray[i];
            //    }
            //}
            //Console.WriteLine(result);

            //int[,] myArray = new int[,]//реализация массива в виде матрицы
            //{
            //    {2,45,54,65,23 },
            //    {6,7,8,5,1 },
            //    {1,5,87,35,78},
            //    {6,3,151,5,65 },
            //    {5,1,83,95,3 }
            //};

            //int height = myArray.GetLength(0);
            //int widht = myArray.GetLength(1);

            //for (int y = 0; y < height; y++)
            //{
            //    for (int x = 0; x < widht; x++)
            //    {
            //        Console.Write(myArray[y, x] + "\t");
            //    }
            //    Console.WriteLine();
            //}
            //    print("Приветики", 54);
            //    string name = "Илья";
            //    print(name, 100);
            //    print("Что-то", 10);
            //    print();

            //    Console.ReadLine();


            //public static void print(string words = "Hello", short numbers = 20)
            //{
            //    Console.WriteLine("Переменная: {0}, число: {1}", words, numbers);
            //}
            //int[] digits = { 0, 3, 25, 99, 36, 101, 2 };
            //int[] nums = { 0, 89, 25, 45, 36, 5, 2 };

            //short[] digits_2 = { 0, 3, 25, 99, 36, 101, 2 };
            //short[] nums_2 = { 0, 89, 25, 45, 36, 5, 2 };

            //int max = maxElement(digits);
            //Console.WriteLine(max);
            //Console.WriteLine(maxElement(nums));

            //showArrays<int>(ref digits, ref nums);
            //showArrays<short>(ref digits_2, ref nums_2);



            Console.ReadKey();

        }


        //    public static int maxElement(int[] numbers)
        //{
        //    int max = numbers[0];

        //    foreach (int el in numbers)
        //    {
        //        if (el > max)
        //            max = el;
        //    }
        //    return max;
        //}

        //public static void showArrays<T>(ref T[] digits, ref T[] nums)
        //{
        //    Console.WriteLine("");
        //    foreach (T el in digits)
        //        Console.Write("{0} ", el);
        //    Console.WriteLine("");
        //    foreach (T el in nums)
        //        Console.Write("{0} ", el);

        //    changeArrays(ref digits, ref nums);
        //    Console.WriteLine("");

        //    foreach (T el in digits)
        //        Console.Write("{0} ", el);
        //    Console.WriteLine("");
        //    foreach (T el in nums)
        //        Console.Write("{0} ", el);
        //}

        //public static void changeArrays<Type>(ref Type[] a, ref Type[] b)
        //{


        //    Type[] temp = new Type[a.Length];
        //    a.CopyTo(temp, 0);
        //    Array.Clear(a, 0, a.Length);
        //    b.CopyTo(a, 0);
        //    Array.Clear(b, 0, b.Length);
        //    temp.CopyTo(b, 0);
        //}
    }
}
}
