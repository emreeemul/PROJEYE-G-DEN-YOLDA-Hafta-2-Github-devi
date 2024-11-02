Console.WriteLine("Bir sayı giriniz: ");
int sayi = Convert.ToInt32(Console.ReadLine());
if (sayi % 2 == 0)
{
    Console.WriteLine("Çift Sayıdır");
}
else
{
    Console.WriteLine("Tek Sayıdır");
}
Console.ReadKey();