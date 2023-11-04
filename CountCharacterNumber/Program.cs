string str =  Console.ReadLine();

char[] character = str.ToCharArray();
int count;

for (int i = 0; i < character.Length; i++)
{
    count = 0;
    char news = character[i];
    for (int j = 0; j < character.Length; j++)
    {
        if(news == character[j])
        {
            count++;
        }

    }
    Console.WriteLine(news + "-" + count); 
}


