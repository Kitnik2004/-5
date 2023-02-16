Console.WriteLine("Сколько лет вы работаете?");
string a = Console.ReadLine();
uint b = (uint)Convert.ToInt32(a);
if (b < 5)
{
    Console.WriteLine("Премия составит 10%");
}
else
{
    if (b < 10)
    {
        Console.WriteLine("Премия составит 15%");
    }
    else
    {
        if (b < 15)
        {
            Console.WriteLine("Премия составит 25%");
        }
        else
        {
            if (b < 20)
            {
                Console.WriteLine("Премия составит 35%");
            }
            else
            {
                if (b < 25)
                {
                    Console.WriteLine("Премия составит 45%");
                }
                else
                {
                    if (b>=25)
                    {
                        Console.WriteLine("Премия составит 50%");
                    }
                }
            }
        }
    }
}