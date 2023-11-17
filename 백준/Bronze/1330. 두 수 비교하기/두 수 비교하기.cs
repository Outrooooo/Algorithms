string[] token = Console.ReadLine().Split(' ');

if (Convert.ToInt32(token[0]) > Convert.ToInt32(token[1]))
{
    Console.WriteLine(">");
}
else if(Convert.ToInt32(token[0]) < Convert.ToInt32(token[1]))
{
    Console.WriteLine("<");
}
else
{
    Console.WriteLine("==");
}