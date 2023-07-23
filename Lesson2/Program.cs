/* Функции (методы) 
Пример задания с определением максимального числа из 9-ти
*/

int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int a1 = 10;
int b1 = 20;
int c1 = 12;
int a2 = 24;
int b2 = 38;
int c2 = 44;
int a3 = 2;
int b3 = 65;
int c3 = 3;

int max = Max(
    Max(a1, b1, c1),
    Max(a2, b2, c2),
    Max(a3, b3, c3)
    );

Console.WriteLine(max);