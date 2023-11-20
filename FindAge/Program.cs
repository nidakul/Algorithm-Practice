//Doğum tarihi girilen kişinin yaşını hesaplayan program

DateTime birthDay = Convert.ToDateTime(Console.ReadLine());

int result = Convert.ToInt32(DateTime.Now.Year - birthDay.Year);

Console.WriteLine(result);

// 05/29/2015


