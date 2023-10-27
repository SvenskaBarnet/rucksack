string[] data = File.ReadAllLines("data.txt");
int sum;

foreach (string line in data)
{
    string compartment1 = line.Substring(0, (line.Length / 2));
    string compartment2 = line.Substring(line.Length / 2, line.Length / 2);
    for (int i = 0; i < compartment1.Length; i++)
    {
        if (compartment1[i].Equals(compartment2[i]))
        {
            switch(compartment1[i])
            {

            }

        }
    }
}
