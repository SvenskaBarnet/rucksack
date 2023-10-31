using System.Net.WebSockets;

string[] data = File.ReadAllLines("data.txt");
int count = 0;
int sum = 0;
string? first = null;
string? second = null;
string? third = null;

foreach (string line in data)
{
    Console.WriteLine(count);
    switch (count)
    {
        case 0:
            first = line;
            count++;
            break;
        case 1:
            second = line;
            count++;
            break;
        case 2:
            for (int i = 0; i < line.Length; i++)
            {
                if (first.Contains(line[i]) && second.Contains(line[i]))
                {
                    if ((int)line[i] is > 96 and < 123)
                    {
                        Console.WriteLine(line[i]);
                        Console.WriteLine((int)line[i]);
                        sum += (int)line[i] - 96;
                        Console.WriteLine(sum);
                    }
                    else if ((int)line[i] is > 64 and < 91)
                    {
                        Console.WriteLine(line[i]);
                        Console.WriteLine((int)line[i]);
                        sum += (int)line[i] - 38;
                        Console.WriteLine(sum);
                    }
                }
            }
            count = 0;
            break;
    }
}

Console.WriteLine(sum);
