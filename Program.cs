//Получение данных от пользователя
string[] GetDateOfUser(string messenge)
{
    Console.Write(messenge);
    char[] separators = new char[] { ' ', ',', '.' };
    string[] splitArrray = Console.ReadLine()!.Split(separators, StringSplitOptions.RemoveEmptyEntries);
    return splitArrray;
}
//Печать массива
void PrintArray(string[] dateUser, string Messange)
{   Console.WriteLine(Messange);
    for (int i = 0; i < dateUser.Length; i++)
    {
        Console.Write(dateUser[i]+ " ");
    }
    Console.WriteLine(" ");
}
//Определение длины будущего массива, где символов в массиве от пользователя <=3
int LenghtArrayForNewArray(string[] dateUser)
{
    int count = 0;
    for (int i = 0; i < dateUser.Length; i++)
    {
        if (dateUser[i].Length <= 3)
            count++;
    }
    return count;
}
//Запись в новый массив , где символов не более 4
string[] StringQuantityUpToFour(string[] dateUser, int lenhtArray)
{ if (lenhtArray==0)
{
    string[] emptyArray={"Нет символов, где длина равна или меньше 3 в данных от тебя!"};
return   emptyArray;
}
else {
    int count=0;
    string[] stringQuantityUpToFour = new string[lenhtArray];
    for (int i = 0; i < dateUser.Length; i++)
    {
        int lenght = dateUser[i].Length;
        if (lenght <= 3)
        {
            stringQuantityUpToFour[count] = dateUser[i];
            count++;
        }
    }
    return stringQuantityUpToFour;
}
}


string[] getDateOfUser = GetDateOfUser("Введите данные -> ");
PrintArray(getDateOfUser, "Массив данных от вас");

PrintArray(StringQuantityUpToFour(getDateOfUser,LenghtArrayForNewArray(getDateOfUser ))," Массив данных , где не более 4 символа");