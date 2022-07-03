/*Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/
/*
string palindronom(int number1)
{
int n0 = number1 /10000;
int n1 = (number1 /1000) % 10;
int n2 = (number1 /100) % 10;
int n3 = (number1 /10) % 10;
int n4 = number1 % 10;

if (n0 == n4 & n1 == n3) return "The number is palindronom";
return "The number is not palindronom";
}

Console.Write("Input number: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(palindronom(number1)); 
*/


/*Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/
/*
double distance(double x1, double y1, double z1, double x2, double y2, double z2)
{
double result = Math.Sqrt(((x1-x2)*(x1-x2)) + ((y1-y2)*(y1-y2)) + ((z1-z2)*(z1-z2)));
result = Math.Round (result,2);
return result;
}

Console.Write("Input first point x-coordinate: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input first point y-coordinate: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input first point z-coordinate: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second point x-coordinate: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second point y-coordinate: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second point z-coordinate: ");
int z2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("The distance between two points is " + distance(x1,y1,z1,x2,y2,z2));
*/


/*Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

/*
void qube(int n1)
{
    for (int i=1; i<=n1; i++)
    {
        int result = i*i*i;
        Console.Write(result + " ");
    }
}

Console.Write("Input number: ");
int n1 = Convert.ToInt32(Console.ReadLine());
qube(n1);
*/