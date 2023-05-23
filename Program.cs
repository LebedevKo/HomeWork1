// Console.WriteLine("Введи первое число");
// string a = Console.ReadLine(); 
// int A = Convert.ToInt32(a); 
// Console.WriteLine("Введи второе число");
// string b = Console.ReadLine(); 
// int B = Convert.ToInt32(b); 
 
// if (A == B * B) 
// { 
//    Console.WriteLine("да, первое число является квадратом второго числа"); 
// }  
// else Console.WriteLine("нет, первое число не является квадратом второго числа");

// Console.WriteLine("Введи число");
// string a = Console.ReadLine();
// if (a == "1") Console.WriteLine("понедельник");
// else if (a == "2") Console.WriteLine("вторник");
// else if (a == "3") Console.WriteLine("среда");
// else if (a == "4") Console.WriteLine("четверг");
// else if (a == "5") Console.WriteLine("пятница");
// else if (a == "6") Console.WriteLine("суббота");
// else if (a == "7") Console.WriteLine("воскресенье");
// else Console.WriteLine("нет этого дня недели");

//предыдущая задача другим способом

// Console.WriteLine("Введи номер дня недели");
// int a = Convert.ToInt32(Console.ReadLine());
// switch (a)
// {
//     case 1:
//     Console.WriteLine("понедельник");
//     break;
//     case 2:
//     Console.WriteLine("вторник");
//     break;
//     case 3:
//     Console.WriteLine("среда");
//     break;
//     case 4:
//     Console.WriteLine("четверг");
//     break;
//     case 5:
//     Console.WriteLine("пятница");
//     break;
//     case 6:
//     Console.WriteLine("суббота");
//     break;
//     case 7:
//     Console.WriteLine("воскресенье");
//     break;
//     default:
//     Console.WriteLine("нет такого номера дня недели");
//     break;
// }

//задача. написать прогу в которой будет выводиться все числа от -N  до +N, где N вводится с клавиатуры

// Console.WriteLine("Введи число");
// int N = Convert.ToInt32(Console.ReadLine());
// int negatN = -N;

// while(negatN <= N)
// {
//     Console.Write(negatN + " ");
//     //Console.Write(" ");
//     negatN ++;
//}

/*
Console.WriteLine("Введи трехзначное число");

    int number = Convert.ToInt32(Console.ReadLine());

    if (number >= 100 && number <= 999)
    {
        int lastDigit = number % 10; // int str_length = input.Length;
        Console.WriteLine("Последняя цифра: " + lastDigit); // Console.WriteLine("Последняя цифра " + input[str_length -  1]);
    }
    else
    
        Console.WriteLine("Введенное число не является трехзначным.");


*/


/* сравнивает два числа
Console.WriteLine("Введите первое число:");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число:");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2)
{
    Console.WriteLine("Первое число больше второго.");
    Console.WriteLine("Второе число меньше первого.");
}
else if (number1 < number2)
{
    Console.WriteLine("Второе число больше первого.");
    Console.WriteLine("Первое число меньше второго.");
}
else
{
    Console.WriteLine("Оба числа равны.");
}

*/
/* максимальное из трех чисел
Console.WriteLine("Введите первое число:");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число:");
int number3 = Convert.ToInt32(Console.ReadLine());

int maxNumber = number1;

    if (number2 > maxNumber)
{
    maxNumber = number2;
}
    if (number3 > maxNumber)
{
         maxNumber = number3;
}

Console.WriteLine("Максимальное число: " + maxNumber);

*/

/* является число четным или нет

Console.WriteLine("Введите число:");
int a = Convert.ToInt32(Console.ReadLine());

if (a % 2 == 0)

    Console.WriteLine("Число является четным.");

else
        
    Console.WriteLine("Число не является четным.");
        
*/

// четные числа от 1 до N
/*
Console.WriteLine("Введите число N:");
int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Четные числа от 1 до N" );

for (int i = 2; i <= N; i += 2)
    
Console.WriteLine(i);

*/
