var rand = new Random(4711);
double minValue = 1_000_000_001;
double maxValue = 0;

for (int i = 0; i < 1_000_000; i++)
{
     int randomNumber = rand.Next(1,1_000_000_001);

    minValue = randomNumber < minValue ? randomNumber : minValue;
    maxValue = randomNumber > maxValue ? randomNumber : maxValue;
}

Console.WriteLine((maxValue-minValue)/999_999);

