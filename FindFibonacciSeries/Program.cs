//fibonacci serisini yaz. (ilk 100 sayı)
int temp;
int initial = 1;
int initialValue = 0;
Console.WriteLine(initial);

for (int i = 1; i < 100; i++)
{
    temp = initialValue;
    initialValue = initial;
    initial = temp + initial;

    Console.WriteLine(initial);
}
