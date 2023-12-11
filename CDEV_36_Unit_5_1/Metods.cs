using System;

public class Metods
{
    public static int[] GetArrayFromConsole(int num = 5)
    {
        var result = new int[num];

        for (int i = 0; i < result.Length; i++)
        {
            Console.WriteLine("Введите элемент массива номер {0}", i + 1);
            result[i] = int.Parse(Console.ReadLine());
        }

        return result;
    }
    public static int[] SortArray(int[] result)
    {
        int temp = 0;
        for (int i = 0; i < result.Length; i++)
            for (int j = i + 1; j < result.Length; j++)
                if (result[i] > result[j])
                {
                    temp = result[i];
                    result[i] = result[j];
                    result[j] = temp;
                }
        return result;
    }
    public static string ShowColor(string name, int age)
    {
        Console.WriteLine("{0} {1}\nНапишите свой любимый цвет на английском с маленькой буквы", name, age);
        var color = Console.ReadLine();
        switch (color)
        {
            case "red":
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is red!");
                break;

            case "green":
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is green!");
                break;
            case "cyan":
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is cyan!");
                break;
            default:
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine("Your color is yellow!");
                break;

        }
        return color;

    }

    public static void ShowArray(int[] array, bool IsSort = false)
    {
        var temp = array;
        if (IsSort)
        {
            temp = Metods.SortArray(array);
        }
        foreach (var item in temp)
        {
            Console.WriteLine("Отсортированный массив: " + string.Join(", ", item));
        }
    }
}
