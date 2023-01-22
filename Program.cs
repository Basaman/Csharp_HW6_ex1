//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

int lenght = GetArrayLenghtFromUser("Введите кол-во чисел M: ");
int[] array = GetArrayFromUser(lenght);
int PositiveNumbers = CountPositiveNumbers(lenght);

Console.Write($"{String.Join(", ", array)} -> {PositiveNumbers}");

int GetArrayLenghtFromUser(string lenghtMessage)
{
    Console.Write(lenghtMessage);
    int userInput = int.Parse(Console.ReadLine() ?? "");
    return userInput;
}

int[] GetArrayFromUser(int size)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        int NumberFromUser = GetNumberFromUser("Введите число: ", "Ошибка ввода! ");
        int GetNumberFromUser(string message, string errorMessage)
        {
            while (true)
            {
                Console.Write(message);
                bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
                if (isCorrect)
                    return userNumber;
                Console.WriteLine(errorMessage);
            }
        }
        result[i] = NumberFromUser;
    }
    return result;
}

int CountPositiveNumbers(int count)
{
    count = 0;
    for (int i = 0; i < lenght; i++)
    {
        if (array[i] > 0) count++;
    }
    return count;
}