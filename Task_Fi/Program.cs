// Задача:
// Написать программу,
//  которая из имеющегося массива строк
//    формирует новый массив из строк,
//    длина которых меньше, либо равна 3 символам. 
//     Первоначальный массив можно ввести с клавиатуры,
//     либо задать на старте выполнения алгоритма.
//       При решении не рекомендуется пользоваться коллекциями,
//      лучше обойтись исключительно массивами.

Console.Write("Введите элементы массива через пробел: ");
string[] initArray = Console.ReadLine().Split(new char[] { ' ' });

int i2 = 0;
for (int i = 0; i < initArray.Length; i++)
{
    if (initArray[i].Length <= 3) i2++;
}
string[] resultArray = new string[i2];

i2 = 0;
for (int i = 0; i < initArray.Length; i++)
{
    if (initArray[i].Length <= 3)
    {
        resultArray[i2] = initArray[i];
        i2++;
    }
}
Console.Write("Массив, содержащий до 3х символов = [ ");
for (i2 = 0; i2 < resultArray.Length; i2++)
{
    Console.Write($"'{resultArray[i2]}' ");
}
Console.Write("]");
