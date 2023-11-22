int[] chess = Array.ConvertAll(Console.ReadLine().Split(' '), s => int.Parse(s));
int[] result = {1,1,2,2,2,8 };

for(int i = 0; i < chess.Length; i++)
{
    Console.Write(result[i] - chess[i] + " ");
}