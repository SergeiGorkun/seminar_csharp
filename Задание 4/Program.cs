Console.WriteLine("Введите число");
string n = Console.ReadLine();
int numberN = Convert.ToInt32(n);

if(numberN % 2 == 0) {
    Console.WriteLine("это число является четным");
}else 
{
    Console.WriteLine("это число не является четным");
}