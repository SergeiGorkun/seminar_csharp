Random rnd = new Random();
int value = rnd.Next(100, 999);
Console.WriteLine(value);

string str = Convert.ToString(value);

str = str.Remove(1, 1);
Console.WriteLine(str);