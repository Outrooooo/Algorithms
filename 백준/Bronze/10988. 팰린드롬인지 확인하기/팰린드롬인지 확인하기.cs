char[] inputAry = Console.ReadLine().ToCharArray();
string input = new string(inputAry);

Array.Reverse(inputAry);
string output = new string(inputAry);

if(input.Equals(output))
{
    Console.WriteLine(1);
}
else
{
    Console.WriteLine(0);
}