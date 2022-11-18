Console.WriteLine("Сколько чисел хоите ввести?");
int arrLength = Convert.ToInt32(Console.ReadLine()), counter = 0;
int[] arr = new int[arrLength];
Console.WriteLine("Введите числа через Enter.");
for (int i = 0; i < arrLength; i++)
{
    arr[i] = Convert.ToInt32(Console.ReadLine());
    if (arr[i] > 0) counter++;
}
Console.WriteLine($"Чисел больше нуля: {counter}");