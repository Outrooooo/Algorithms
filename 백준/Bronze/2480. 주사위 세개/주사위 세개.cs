int[] dices = Array.ConvertAll(Console.ReadLine().Split(' '), s => int.Parse(s));
int amount = 0;
int same = 0;
int result = 0;

for(int i = 0; i <dices.Length; i++)
{
    for(int j = i+1; j < dices.Length; j++)
    {
        if (dices[i] == dices[j])
        {   
            if(amount == 2)
            {
                break;
            }
            else
            {
                amount++;
                same = dices[i];
            }
        }
    }
}

switch (amount)
{   
    case 1: // 2개가 같음
        result = 1000 + (same * 100);
        break;                
    case 2: // 3개가 같음
        result = 10000 + (same * 1000);
        break;
    default: // 아닐 때
        result = dices.Max() * 100;
        break;
}
Console.WriteLine(result);