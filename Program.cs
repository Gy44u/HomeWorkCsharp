﻿/*Task 1. Напишите программу, которая на вход принемает два числа
и выдирает большее число.

Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2) 
  Console.WriteLine("max= " + num1);
  else Console.WriteLine("max= " + num2);*/

/*Task 2. Напишите программу, которая принимает на ввод
// три числа и выдаёт максимальное из этих чисел.

Console.Write("Input a first number: ");
    int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
    int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the third nnumber: ");
    int num3 = Convert.ToInt32(Console.ReadLine());

int max = num1;

if (num2 > max) 
{
    max = num2;
}
if (num3 > max) 
{
    max = num3;
}
Console.WriteLine("Max nubber is: " + max);*/

/*Task 3. Напишите программу, которая на вход принемает число 
и выдаёт, является ли число чётным (делиться ли оно на два 
без остатка).

Console.Write("Input number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
if (num1 % 2 == 0)
     
     Console.WriteLine("Yes");

else 
     Console.WriteLine("No" );*/

/*Task 4. Напишите программу, которая на входе принемает
число(N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Iptut a number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
int current = 1;
while (current <= num1)
   { if  (current % 2 == 0) 
    Console.Write (current + " ");
    current++;
    }
return (current);*/

/*Console.Write("Iptut a number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
int current = 2;
while (current <= num1)
    {Console.Write (current + " ");
    current = current + 2;
    }
return (current);*/

________________________________DZ2___________________________________________________

// Task 5. Задача 10: Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.
/*
int SecondRang (int num1)
{
   int Rangsecond = (num1 / 10) % 10;

return Rangsecond;
}
Console.Write("Ipnut third numbet:= ");
int num1 = Convert.ToInt32(Console.ReadLine());
int newNumber = SecondRang (num1);
Console.WriteLine($"Vvedenoe chislo {num1} chislo kotoroe poluchilos {newNumber}");*/

/* Task 6. Задача 13: Напишите программу, которая выводит третью цифру заданного числа.

int ThridRang( int number)
   {while (number >999)
      number = number/10;
   return number % 10;}

Console.Write("Ipnut a numbet:= ");
int Number = Convert.ToInt32(Console.ReadLine());
int newNumber = ThridRang (Number);
Console.WriteLine($"Vvedenoe chislo {Number} chislo kotoroe poluchilos {newNumber}");*/

/* Task 7. Задача 15 :Напишите программу, которая принимает на вход цифру, обозначающую день 
недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет

// Задачу скопировал, но разобрался.
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

string WorkHoliday(int a)
{
    if (a > 0 && a < 8)
    {
        if (a == 7 || a == 6)
        {
            Console.Write("Под цифрой " + a + " - Выходной");
        }
        else
        {
            Console.Write("Под цифрой " + a + " - Рабочий");
        }
    }
    else
    {
        Console.Write("Вы ввели число не в пределах от 1 до 7, поэтому не возможно определить");
    }
    return " день.";
}

int dayNumber = ReadInt("Введите число от 1 до 7: ");
Console.WriteLine(WorkHoliday(dayNumber));*/

              
________________________________DZ3________________________________________________________

//Task 8.Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
/*void Quad (int num)
{
    int count =1;
    while(count<=num)
    {
        Console.WriteLine($"{count} - {count*count*count}");
        count++;
    }
}
Console.WriteLine("");
Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());

Quad(num);*/

/* Task 9. Напишите программу, которая принимает на вход 
координаты двух точек и находит расстояние между ними 
в 3D пространстве. 
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53

double Distans( int x1, int x2, int y1, int y2, int z1, int z2)

{
    double result = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1));
    return result;
 
}
Console.Write("Input x1 ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input y1 ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input z1 ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input x2 ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input y2 ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input z2 ");
int z2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Distans(x1,x2,y1,y2,z1,z2));*/

/* Task 10. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да

 bool isPal(int n)
  {
      int r=0,nn=n;
      while (n>0)
      {
          r=r*10+n%10;
          n=n/10;
      }
      return r==nn;
  }
    int n;  
    Console.Write("n=");
    n=Convert.ToInt32(Console.ReadLine());
    if (isPal(n))
       Console.WriteLine("Палиндром");
    else   
       Console.WriteLine("Не палиндром");
*/
