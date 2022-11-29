// Вид 4

string Method4(int count, string text)   // string строка
{
    int i = 0;
    string result = string.Empty; // пустая строка
    
    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
string res = Method4(10, "z");
Console.WriteLine(res);