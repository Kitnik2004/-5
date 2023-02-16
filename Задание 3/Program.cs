{
    int x = 5, y = 10, z = 15;
    x += y >> x++ * z;
    Console.WriteLine(x);
}
{
    int x = 5, y = 10, z = 15;
    z = ++x & y * 5;
    Console.WriteLine(z);
}
{
    int x = 5, y = 10, z = 15;
    y /= x + 5 | z;
    Console.WriteLine(y);
}
{
    int x = 5, y = 10, z = 15;
    z = x++ & y * 5;
    Console.WriteLine(z);
}
{
    int x = 5, y = 10, z = 15;
    x = y << x++ ^ z;
    Console.WriteLine(x);
}