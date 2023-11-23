int input = int.Parse(Console.ReadLine());
int[] money = { 500, 100, 50, 10, 5, 1 };
int result = 0;
input = 1000 - input;

for(int i = 0; i < money.Length; i++)
{
    if (input / money[i] < 1)
    {
        continue;
    }
    else
    {
        result = result + (input / money[i]);
        input %= money[i];
    }
}
Console.WriteLine(result);