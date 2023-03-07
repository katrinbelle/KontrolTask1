//Получение данных от пользователя
string[] GetDateOfUser (string messenge)
{
Console.Write(messenge);
char[] separators =new char[] {' ',',','.'};
string[]splitArrray=Console.ReadLine()!.Split(separators,StringSplitOptions.RemoveEmptyEntries);
return splitArrray;
}
//Печать массива
void PrintArray(string[] dateUser)
{
    for (int i = 0; i < dateUser.Length; i++)
    {
        Console.WriteLine(dateUser[i]);
    }
}
PrintArray(GetDateOfUser("Введите данные -> "));

