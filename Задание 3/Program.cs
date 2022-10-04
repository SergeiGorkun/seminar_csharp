
Console.WriteLine("Введи номер дня недели");
string NumberStr = Console.ReadLine();
string day = "Нет такого дня";

int Number = Convert.ToInt32(NumberStr);

if(Number == 1) {
    day = "Понедельник";
} else if(Number == 2) {
    day = "Вторник";
} else if(Number == 3) {
    day = "Среда";
} else if(Number == 4) {
    day = "Четверг";
} else if(Number == 5) {
    day = "Пятница";
} else if(Number == 6) {
    day = "Суббота";
} else if(Number == 7) {
    day = "Воскресенье";
}

Console.WriteLine(day);