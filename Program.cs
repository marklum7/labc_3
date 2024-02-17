using System;

public class Main
{
    public Main()
    {
    }
public static void Main1(string[] args)
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine("Таблица умножения на " + i);

            for (int j = 1; j <= 10; j++)
            {
                Console.WriteLine(i + "*" + j + "=" + j * i);
            }
        }
    }
}