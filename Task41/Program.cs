// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь. 
// Ввод чисел останавливается при помощи ввода стоп-слова "stop" и производится при помощи нажатия Enter
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4

int count = 0;  // количество строк в массиве
string[] array = new string[count];
string[] toOldArray; // пришлось создавать два массива, этот массив сохраняем в старый массив строк
string number;
int negCount = 0; // количество отрицательных чисел

Console.WriteLine("Введите числа:");

do
{
    number = Console.ReadLine();
    if (number[0] == '-' && number.Length >= 2) // считаем количество отрицательных чисел, минус без числа не считается
    {
        negCount++; 
    }

    if (number!="") // проверка на пустую строку
    {
        count++;
        toOldArray = new string[count];
          
        for (int i = 0; i < toOldArray.Length - 1; i++) // копируем старый массив в новый
        { 
        toOldArray[i] = array[i];
        toOldArray[count - 1] = number;
        }
        array = toOldArray;
    }
} while (number != "stop");

Console.WriteLine($"Введено {array.Length - 1} чисел(а), из них {negCount} отрицательные");

   
    






