int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), s => int.Parse(s));
TimeSpan timeSpan = new TimeSpan(0, 45, 0);
DateTime dateTime = new DateTime(2023, 11, 21, input[0], input[1], 0);
DateTime result = dateTime.Subtract(timeSpan);

Console.WriteLine("{0:H m}", result);