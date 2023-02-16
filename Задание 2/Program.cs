Console.Write("Введите число для проверки на чётность: ");
string a = Console.ReadLine();
int b = Convert.ToInt32(a);
Console.Write("Выберите способ проверки: 1- с помощью логики; 2- через остаток");
a = Console.ReadLine();
switch (a)
{
    case "1":
        {
            if ((b & 1) == 0)
            {
                Console.WriteLine("Число чётное");
            }
            else
            {
                Console.WriteLine("Число нечётное");
            }
            break;
        }
    case "2":
        {
            if ((b % 2) == 0)
            {
                Console.WriteLine("Число чётное");
            }
            else
            {
                Console.WriteLine("Число нечётное");
            }
            break;
        }
}
