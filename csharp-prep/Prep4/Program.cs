using System;

class Program
{
    static void Main(string[] args)
    {
        List<float> num_list = new List<float>();
        float user_number = -1;
        float sum = 0;
        float avg = 0;
        float i = 0;
        float largest = 0;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (user_number != 0)
        {
            user_number = float.Parse(Console.ReadLine());
            num_list.Add(user_number);
        }
        foreach (float num in num_list)
        {
            sum += num;
            i++;
            if (num > largest)
            {
                largest = num;
            }
        }
        i--;
        Console.WriteLine($"The sum is: {sum}.");
        avg = sum / i;
        Console.WriteLine($"The average is: {avg}.");
        Console.WriteLine($"The largest number is: {largest}.");
    }
}