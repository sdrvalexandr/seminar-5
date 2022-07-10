internal class Program
{
    private static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Список заданий:");
        Console.WriteLine("1. Задан массив из случайных цифр на 15 элементов. На вход подаётся трёхзначное натуральное число. Напишите программу, которая определяет, есть в массиве последовательность из трёх элементов, совпадающая с введённым числом\r\n2. На вход подаются два числа случайной длины. Найдите произведение каждого разряда первого числа на каждый разряд второго. Ответ запишите в массив.\r\n3. Найдите все числа от 1 до 1000000, сумма цифр которых в три раза меньше их произведений. \r\n5.Подсчитайте их количество.Дан массив массивов, состоящих из натуральных чисел, размер которого 5. Для каждого элемента-массива определить найти сумму его элементов и вывести массив с наибольшей суммой. Если таких массивов несколько, вывести массив с наименьшим индексом.");
        Console.ResetColor();

        void FillArray(int[] array, int a, int b)
        {
        for (int i = 0; i < array.GetLength(0); i++)
        {
                int randomNumber = new Random().Next(a, b);
                array[i] = randomNumber;
                Console.Write(array[i] + "\t");
        }
        Console.WriteLine();
        }

        void FillStringArray(string readWorld, int[] array)
        {
        //int[] array = new int[readWorld.Length];
        for (int i = 0; i < readWorld.Length; i++)
        {
            int stringNumber = Convert.ToInt32(readWorld[i].ToString());
            array[i] = stringNumber;
            Console.Write(array[i] + "\t");
        }
        Console.WriteLine();
        }
        
        void Zadacha1()
        {
        Console.WriteLine("Задача 1.");
        Console.WriteLine("Введите длину массива");
        int number = Convert.ToInt32(Console.ReadLine());
        int[] myArray = new int[number];
        int count = 0;
        FillArray(myArray, 1, 99);

        for (int i = 0; i < myArray.GetLength(0); i++)
        {
            if(myArray[i] % 2 == 0)
            {
                count++;
            }
        }
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"В массиве из {number} чисел будет {count} четных чисел");
        Console.ResetColor();
        }


        void Zadacha2()
        {
        Console.WriteLine("Задача 2.");
        Console.WriteLine("Введите длину массива");
        int number = Convert.ToInt32(Console.ReadLine());
        int[] myArray = new int[number];
        int count = 0;
        FillArray(myArray, 1, 99);
        for (int i = 0; i < myArray.GetLength(0); i++)
        {
            if((i % 2 != 0)&&(i != 0))
            {
                count=count + myArray[i];
            }
        }        
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"В массиве из {number} сумма чисел на нечетной позиции будет {count}");
        Console.ResetColor();    
        }


        void Zadacha3()
        {
        Console.WriteLine("Задача 3.");
        Console.WriteLine("Введите длину массива");
        int number = Convert.ToInt32(Console.ReadLine());
        int[] myArray = new int[number];
        int max = 0;
        int min = 100;
        FillArray(myArray, 1, 99);
        for (int i = 0; i < myArray.GetLength(0); i++)
        {
           if (myArray[i]<min)
           {
            min = myArray[i];
           }
           if (myArray[i]>max)
           {
            max = myArray[i];
           }
        }        
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Разница максимума {max} и минимума {min} в массиве из {number} чисел будет {max-min}");
        Console.ResetColor();    
        }
        Console.WriteLine("дополнительные задачи");
        void Zadacha4()
        {
        Console.ForegroundColor = ConsoleColor.Yellow;    
        Console.WriteLine("Задача 4.Задан массив из случайных цифр на 15 элементов. На вход подаётся трёхзначное натуральное число. Напишите программу, которая определяет, есть в массиве последовательность из трёх элементов, совпадающая с введённым числом.");
        Console.ResetColor();
        Console.WriteLine("Введите длину массива");
        int number = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите трехзначное число");
        string numberCheck = Console.ReadLine();
        int a = Convert.ToInt32(numberCheck[0].ToString());
        int b = Convert.ToInt32(numberCheck[1].ToString());
        int c = Convert.ToInt32(numberCheck[2].ToString());
        int resault = 0;
        int[] myArray = new int[number];
        FillArray(myArray, 0, 9);
        for (int i = 0; i < myArray.GetLength(0); i++)
        {
           if ((myArray[i] == a)&&(myArray[i+1] == b)&&(myArray[i+2] == c))
           {
            resault = 1;
            //Console.WriteLine("да");
           } else resault = 0; //Console.WriteLine("нет");

        }        
        Console.ForegroundColor = ConsoleColor.Green;
        if(resault == 1)
        {
        Console.WriteLine($"В массиве из {number} есть повторяющееся число {numberCheck}");
        } else Console.WriteLine($"В массиве из {number} нет повторяющегося числа {numberCheck}");
        Console.ResetColor();    
        }


        void Zadacha5()
        {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Задача 5.На вход подаются два числа случайной длины. Найдите произведение каждого разряда первого числа на каждый разряд второго. Ответ запишите в массив.");
        Console.ResetColor();
        Console.WriteLine("число 1");
        string number1 = Console.ReadLine();
        Console.WriteLine("число 2");
        string number2 = Console.ReadLine();
        int resault = 0;
        int count = 0;
        int[] array1 = new int[number1.Length];
        int[] array2 = new int[number2.Length];
        List<int> list = new List<int>();
        FillStringArray(number1, array1);
        FillStringArray(number2, array2);
        //Console.WriteLine("---------------------");
        for (int i = 0; i < array1.GetLength(0); i++)
        {
            for(int j = 0; j < array2.GetLength(0); j++)
            {
             resault = array1[i] * array2[j];
             //Console.Write(resault + "\t");
             count++;
             list.Add(resault);
            }
        }
        Console.WriteLine("");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("массив с произведениями будет:");
        for (int i = 0; i < count; i++)
        {
            Console.Write(list[i] + "\t");
        }
        Console.ResetColor();
        }               
    Zadacha1();
    Zadacha2();
    Zadacha3();
    Zadacha4();
    Zadacha5();
    }
}