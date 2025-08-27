int[] numbers = { 1, 23, 765, 233, 54, 12, 876 };
for (int i = 0; i < numbers.Length; i++)
{
    for (int j = i + 1; j < numbers.Length; j++)
    {
        int target = numbers[i];
        if (numbers[i] < numbers[j])
        {
            numbers[i] = numbers[j];
            numbers[j] = target;
        }
    }
}

foreach (var number in numbers)
{
    Console.WriteLine(number);
}

Array.Sort(numbers);
Array.Reverse(numbers);