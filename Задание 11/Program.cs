Random rnd = new Random();
int value = rnd.Next(1, 200);
Console.WriteLine(value);

string str = Convert.ToString(value);

if(str.Length > 2) {
    Console.WriteLine(str[2]);
} else {
    Console.WriteLine("Третья цифра отутствует");
}