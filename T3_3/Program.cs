// Вид 2_1

void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2(msg: "Текст сообщения: ");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
Method21("Текст", 4);   // Сколько раз (4) хотим увидеть это сообщение

