Console.WriteLine("kullanıcı adı: ");
string ka = Console.ReadLine();
Console.WriteLine("şifre: ");
string şifre = Console.ReadLine();

if (ka == "admin" && şifre == "Admin_32453@")
{
    Console.WriteLine("Giriş Başarılı");
}
else
{
    Console.WriteLine("Giriş Başarısız");
}
Console.ReadKey();
