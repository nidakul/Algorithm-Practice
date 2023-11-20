//Girilen sayının kaç basamaklı olduğunu söyleyen program

int number = Convert.ToInt32(Console.ReadLine());
int counter = 0;
for (int i = 1; i <= number; i *= 10)
{
    counter++;

}

Console.WriteLine(counter + " basamaklıdır.");

