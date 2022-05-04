int number = int.Parse(Console.ReadLine());
int temp = number;
int i = 10;

while (true)
{
    if (number / 100 == 0)
    {
        if (temp / i == temp % 10 || temp / 10 == 0)
        {
            if (temp / 100 == 0)
            {
                Console.WriteLine("is true");
                break;
            }
        }
        else
        {
            Console.WriteLine("is not true");
            break;
        }

        temp = temp % i / 10;
        i = i / 100;
    }
    else
    {
        number = number / 10;
        i = i * 10;
    }
}
Console.ReadKey();