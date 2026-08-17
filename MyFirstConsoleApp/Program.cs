using System.ComponentModel.DataAnnotations;

Console.WriteLine("Привет мир, это моя попытка учить C#!");
//Пара переменных до кучи.
int magicNumber = 42;
string magicString = "42";
bool notMagicBool = false;
string forCicle = "Привет, я Джонни Ноксвил и с вами Чудаки!";

void OperatorExample(string someSrt)
{
    Console.WriteLine(someSrt + " Это магическое число!");
    int width = 3, height = 3, area;
    Console.WriteLine(3 + width++); //Постфиксны инкремент
    Console.WriteLine(width);
    Console.WriteLine(3 + (++height)); //Перфиксный инкремент
    Console.WriteLine(height);

    area = width * height;
    Console.WriteLine($"\nВысота:\t{height}.\nШирина:\t{width}.\n" +
        $"Площадь: {area}.\n" +
        $"{notMagicBool}");

    width = 3;
    width++;

    height = 2 + 4;
    area = width * height;
    Console.WriteLine(area);

    while (area < 20)
    {
        height++;
        area = width * height;
        Console.WriteLine($"Height: {height}, Area: {area}");
    }

    do
    {
        width--;
        area = width * height;
        Console.WriteLine($"Width: {width}, Area: {area}");
    } while (area > 25);

    string result = "The area";
    result = result + " is " + area;
    Console.WriteLine(result);

    bool trueValue = true;
    Console.WriteLine(trueValue);

    do
    {
        int.TryParse(Console.ReadLine(), out magicNumber);

    } while (magicNumber < 10);

    for (int i= 0; i <= forCicle.Length; i++)
    {
        Console.WriteLine(i);    
    }

    int count = 5;
    while (count > 0)
    {
        count = count * 3;
        count = count * -1;
        Console.WriteLine(count);
    }

    int j = 2;
    for (int i = 1; i < 100; i = i * 2)
    {
        j = j - 1;
        while (j < 25)
        {
            j = j + 5;
            Console.WriteLine(j);
        }
    }
    int whileCount = 0;
    int forCount = 0;
    int p = 2;
    for (int q = 2; q < 32; q = q * 2)
    {
        while (p < q)
        {
            p = p * 2;
            whileCount++;
        }
        q = p - q;
        forCount++;
    }

    Console.WriteLine($"Цикл 3 закончен.\n" +
        $"While Count: {whileCount}.\n" +
        $"For Count: {forCount}");
    
}




OperatorExample(magicString);