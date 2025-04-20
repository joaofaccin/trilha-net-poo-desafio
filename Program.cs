using DesafioPOO.Models;

class Program
{
    static void Main()
    {
        Smartphone nokia = new Nokia("111111", "Nokia 3310", "1234567890", "32GB");
        Smartphone iphone = new Iphone("222222", "iPhone 14", "0987654321", "128GB");

        Console.WriteLine("Usando Nokia:");
        nokia.Ligar();
        nokia.InstalarAplicativo("Snake");

        Console.WriteLine("\nUsando iPhone:");
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Instagram");
    }
}
