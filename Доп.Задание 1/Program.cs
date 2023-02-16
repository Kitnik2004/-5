Console.WriteLine("Введите число");
int i = Console.Read();
bool a = (i != 0) && (i & (i - 1)) == 0 ? true : false;
string b = "NULL";
a = false ? b == "Число не является степенью двойки" : b == "Число является степенью двойки";
Console.WriteLine(b);
//Второе доп задание я не придумал как оформить