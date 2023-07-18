
#region TASK1
static void Percent()
{
    Console.WriteLine("Enter percent:");
    string numberstring = Console.ReadLine();
    int number = Convert.ToInt32(numberstring);
    double[] arr = { 10, 15, 20, 100 };
    double sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < 20)
        {
            arr[i] = arr[i] * number / 100 + arr[i];
        }
        sum += arr[i];
    }
    Console.WriteLine(sum);
}
Percent();
#endregion

#region TASK2
static void Letter()
{
    Console.WriteLine("Enter number:");
    string numberstring = Console.ReadLine();
    int number = Convert.ToInt32(numberstring);
    string text = Console.ReadLine();
    for (int i = 0; i < text.Length; i++)
    {
        if (i == number)
        {
            continue;
        }
        Console.WriteLine(text[i]);
    }
}
Letter();
#endregion

