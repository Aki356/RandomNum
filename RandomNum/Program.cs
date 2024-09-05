// See https://aka.ms/new-console-template for more information
Random rand = new Random();
int i = rand.Next(10);
int count = 1;
Console.WriteLine("Компьютер загадал число от 0 до 9. Попробуйте отгадать его за три попытки.");


while (count <= 3)
{
    Console.WriteLine($"Попытка {count}. Введите число:");
    int k = Convert.ToInt32(Console.ReadLine());
    if (i == k)
    {
        Console.WriteLine("Да! Компьютер загадал число " + i + "!");
        break;
    }
    else
    {
        count++;
        if(count == 4)
        {
            Console.WriteLine("Увы, вы не отгадали число. Это было число " + i + "!");
            break;
        }
        Console.WriteLine("Нет, это не число " + k);

    }
}
Console.ReadLine();