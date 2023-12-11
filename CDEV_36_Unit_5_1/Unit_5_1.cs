using System;
class Unit_5_1
{
    

   /* public static void Main()
    {
        var (name, age) = ("Евгения", 27);

        Console.WriteLine("Моё имя: {0}", name);
        Console.WriteLine("Мой возраст: {0}", age);

        Console.Write("Введите имя:");
        name = Console.ReadLine();
        Console.Write("Введите возраст с цифрами:");
        age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ваше имя: {0}", name);
        Console.WriteLine("Ваш возраст: {0}", age);
       
        var favcolors = new string[3];
        for (int i = 0; i < favcolors.Length; i++) 
        {
            favcolors[i] = Metods.ShowColor(name, age);
        }

        Console.WriteLine("Your favotite colors:");
        foreach (string color in favcolors)
        {
            Console.WriteLine(color);
        }

        Console.ReadKey();

    }*/
    private static void Main (string[] args)
    {
        int[] array = Metods.GetArrayFromConsole(10);
        int[] sortedArray = Metods.SortArray(array);
        Metods.ShowArray(sortedArray, true);
    } 
}