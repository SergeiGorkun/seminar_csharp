Console.WriteLine("Здравствуй! Введи первое число");
string a = Console.ReadLine();
Console.WriteLine("Введи второе число");
string b = Console.ReadLine();
Console.WriteLine("Введи третье число");
string c = Console.ReadLine();

int numberA = Convert.ToInt32(a);
int numberB = Convert.ToInt32(b);
int numberC = Convert.ToInt32(c);

int max = numberA;



if(numberB > max){
    max = numberB;
} else if(numberC > max){
    max = numberC;
}
Console.WriteLine("Найдено максимальное из трех чисел: " + max);