//perfect sayı: sayının bölenlerini topla kendisi hariç bölenlerin toplamı sayının kendisine eşit olmalı.
//28 sayısı bölenleri: 1,2,4,7,14,28 --> 1+2+4+7+14 = 28
//2 ile 1000 arasındaki süper sayıları listeleyen programı bul.

Console.WriteLine("Perfect Numbers:");
for (int number = 1; number < 1000; number++)
{
    int sum = 0;
    for (int divider = 1; divider < number; divider++)
    {
        if (number % divider == 0)
        {
            sum += divider;
        }

    }
    if (sum == number)
    {
        Console.WriteLine(number);
    }
}