// Вид 2 (что-то принимают, ничего не возвращают)

// Первый способ

void Method2(string msg)
{
    Console.WriteLine(msg);
}
//Method2("Текст сообщения");

// Второй способ

void Method21(string msg, int count) // msg - сообщение, count - считать
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
Method21(msg: "Текст сообщения", count: 4);
// Method21("Текст сообщения", 4);  можно писать так
// Method21(count: 4, msg: "Текст сообщения");  можно писать так