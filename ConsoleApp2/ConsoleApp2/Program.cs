// See https://aka.ms/new-console-template for more information
using System;

var random = new Random();
Console.WriteLine("歡迎來到猜數字遊戲");

int anser = random.Next(1, 51);
int guess = 0; 
int min = 1;
int max = 50;
int count;
count = 1;
while (guess != anser)
{
    Console.WriteLine($"請輸入{min}~{max}");
    guess = Convert.ToInt32(Console.ReadLine());
    if (guess > anser && guess >= min && guess <= max)
    {
        Console.WriteLine("數字太大");
        max = guess;
        count++;
            }
    else if (guess < anser && guess >= min && guess <= max) 
        {
        Console.WriteLine("數字太小");
        min = guess;
        count++;
            }
    else 
    {
        Console.WriteLine("請輸入範圍內的數字");
            }

}
Console.WriteLine($"恭喜你猜對了，答案就是{anser}");
Console.WriteLine($"總共猜了{count}次");




