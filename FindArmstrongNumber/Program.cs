int number = Convert.ToInt32(Console.ReadLine());
List<int> numbers = new List<int>();
int pow;
int sum = 0;

int sayı;

for (int i = 10; i <= number * 10; i *= 10)
{
    numbers.Add(number % i);
}
FindArmstrongNumbers();

void FindArmstrongNumbers()
{
    int multiple = 1;
    for (int j = 0; j < numbers.Count; j++)
    {
        sayı = numbers[j] / multiple;
        multiple *= 10;
        pow = Convert.ToInt32(Math.Pow(sayı, numbers.Count));
        sum += pow;
    }
} 

if(sum == number)
{
    Console.WriteLine("The number is armstrong number");
}
else
{
    Console.WriteLine("The number is not armstrong number");

}


