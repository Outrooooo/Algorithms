int firstInput = int.Parse(Console.ReadLine());
char[] secondInput = Console.ReadLine().ToCharArray();

for(int i = secondInput.Length -1; i>=0; i--)
{ 
    Console.WriteLine( int.Parse(secondInput[i].ToString()) * firstInput);
}
Console.WriteLine(firstInput * int.Parse(string.Concat(secondInput)));