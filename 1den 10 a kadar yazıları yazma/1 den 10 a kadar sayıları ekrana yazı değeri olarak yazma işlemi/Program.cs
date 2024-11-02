int sayi;
Console.WriteLine("1'den 10'a kadar bir sayı giriniz");
sayi = int.Parse(Console.ReadLine());

switch (sayi)
{
    case 1:
        Console.WriteLine("Bir");
        break;
    case 2:
        Console.WriteLine("İki");
        break;
    case 3:
        Console.WriteLine("Üç");
        break;
    case 4:
        Console.WriteLine("Dört");
        break;
    case 5:
        Console.WriteLine("Beş");
        break;
    case 6:
        Console.WriteLine("Altı");
        break;
    case 7:
        Console.WriteLine("Yedi");
        break;
    case 8:
        Console.WriteLine("Sekiz");
        break;
    case 9:
        Console.WriteLine("Dokuz");
        break;
    case 10:
        Console.WriteLine("On");
        break;
    default:
        Console.WriteLine("1'den 10'a kadar bir sayı giriniz");
        break;
}