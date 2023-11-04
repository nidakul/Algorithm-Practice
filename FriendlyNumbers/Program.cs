//İki sayı birbirinin kendisi hariç bölenleri toplamına eşitse bu sayılara arkadaş sayılar denir.
//220 : 1 + 2 + 4 + 5 + 10 + 11 + 20 + 22 + 44 + 55 + 110 = 284
//284 : 1 + 2 + 4 + 71 + 142 = 220
//1184-1210 

int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());

if(FindFriendlyNumber(number1) == number2 && FindFriendlyNumber(number2) == number1)
{
    Console.WriteLine("Friendly Numbers");
}
else
{
    Console.WriteLine("Not Friendly Numbers");
}

static int  FindFriendlyNumber(int number1)
{
    int sum = 0;
    for (int i = 1; i < number1; i++)
    {
        if (number1 % i == 0)
        {
            sum += i;
        }
        
    }
    return sum;
}



