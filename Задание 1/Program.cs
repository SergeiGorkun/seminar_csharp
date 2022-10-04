Console.WriteLine("Здравствуй, уважаемый пользователь! Введите первое число");
string a = Console.ReadLine();
Console.WriteLine("Введите второе число");
string b = Console.ReadLine();

int numberA = Convert.ToInt32(a);
int numberB = Convert.ToInt32(b);

if(numberA * numberA == numberB) {
    Console.WriteLine("Да, второе число является квадратом первого");
} else {
    Console.WriteLine("Нет, второе число не является квадратом первого!");
}