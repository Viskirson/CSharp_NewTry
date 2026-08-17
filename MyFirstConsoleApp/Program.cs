Console.WriteLine("Привет мир, это моя попытка учить C#!");
//Пара переменных до кучи.
int magicNumber = 42;
string magicString = "42";
bool notMagicBool = false;

void OperatorExample(string someSrt)
{
    Console.WriteLine(someSrt + " Это магическое число!");
    int width = 3, height = 3, area;
    Console.WriteLine(3+width++); //Постфиксны инкремент
    Console.WriteLine(width);
    Console.WriteLine(3+(++height)); //Перфиксный инкремент
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

    string result = "The area";
    result = result + " is " + area;
    Console.WriteLine(result);

    bool trueValue = true;
    Console.WriteLine(trueValue);
}




OperatorExample(magicString);