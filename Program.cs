string[] data = File.ReadAllLines("data.txt");
int sum = 0;

foreach (string line in data)
{
    string compartment1 = line.Substring(0, (line.Length / 2));
    string compartment2 = line.Substring(line.Length / 2, line.Length / 2);
    int item = 0;
    for (int i = 0; i < compartment1.Length; i++)
    {
        if (compartment2.Contains(compartment1[i]))
        {
            if ((int) compartment1[i] is > 64 and < 91)
            {
                item = ((int)compartment1[i] - 38);
            }
            else if ((int)compartment1[i] is > 96 and < 123)
            {
                item = ((int)compartment1[i] - 96);
            }
        }
    }
    sum += item;
}
Console.WriteLine(sum);
