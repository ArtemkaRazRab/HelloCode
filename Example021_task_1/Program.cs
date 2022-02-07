// Дан текст. В тексте нужно все пробелы заменить черточками,
// маленькие буквы "к" заменить большими "К",
// а большие буквы "В" заменить маленькими "в".

string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";

// string s = "qwerty"
//             012345
// s[3]  // r

string Replase(string text, char oldValue, char newValue)
{
    string result = String.Empty;  // инициализация пустой строки

    int length = text.Length;  // для того чтобы получить длину нашей строки. 
                               // .Length Показывает количество символов в строке
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";// если текущий символ совпал
                                                                 // с тем символом, который мы хотим заменить,
                                                                 // то в result мы положим новое значение
        else result = result + $"{text[i]}"; // если же совпадений не обнаружено,
                                             // то в result добавим текущий символ
    }
    return result;
}
string newText = Replase(text, ' ', '|');  // заменили пробелы черточками
Console.WriteLine(newText);
Console.WriteLine();
newText = Replase(newText, 'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replase(newText, 'В', 'в');
Console.WriteLine(newText);