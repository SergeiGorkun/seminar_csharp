﻿Console.WriteLine ("ВВести первое число");
string str = Console.ReadLine();
int a = Convert.ToInt32(str);
Console.WriteLine ("ВВести второе число");
str = Console.ReadLine();
int b = Convert.ToInt32(str);

if(a % b == 0) {
    Console.WriteLine("Число " + a + " кратно числу " + b);
} else {
    Console.WriteLine("Число " + a + " не кратно числу " + b);
}
