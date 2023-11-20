//Girilen sayının faktöriyelini bulan program

int number = Convert.ToInt32(Console.ReadLine());

int fact = 1;

for (int i = number; i >= 1; i--)
{
    fact *= i;
}

Console.WriteLine(fact);