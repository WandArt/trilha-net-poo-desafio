using DesafioPOO.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        // TODO: Realizar os testes com as classes Nokia e Iphone
        Iphone iphone1 = new Iphone("111111111", "MM", "12334", 10);
        Nokia nokia1 = new Nokia("222222", "NM", "1238934", 26);


        Console.WriteLine("Smartphone Nokia:");
        nokia1.Ligar();
        nokia1.InstalarAplicativo("Telegram");

        Console.WriteLine("\n");

        Console.WriteLine("Smartphone Iphone:");
        iphone1.ReceberLigacao();
        iphone1.InstalarAplicativo("Whatsapp");




    }
}