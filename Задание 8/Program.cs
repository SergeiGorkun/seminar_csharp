Random rnd = new Random();

int value = rnd.Next(10, 99);
 
Console.WriteLine(value);

string str = Convert.ToString(value);

char a = str[0];
char b = str[1];

if(a > b) {
    Console.WriteLine(a);
} else {
    Console.WriteLine(b);
}
